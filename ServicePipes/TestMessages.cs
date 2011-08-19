using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using CoApp.Toolkit.Engine;

namespace ServicePipes
{
    class TestMessages
    {
        private class Pipe
        {
            private NamedPipeClientStream _pipe;
            public NamedPipeClientStream pipe { get { return _pipe; } }
            public Pipe(NamedPipeClientStream pipe) { _pipe = pipe; }
            public void Connect() {_pipe.Connect();}
            public void Connect(int Timeout) { _pipe.Connect(Timeout); }
            public void Close() {_pipe.Close();}
            public void Write(string msg)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(msg);
                _pipe.Write(bytes,0,bytes.Length);
            }
            public string Read()
            {
                List<byte> received = new List<byte>();
                byte[] bytes = new byte[256];
                do
                {
                    bytes.Initialize();
                    _pipe.Read(bytes, 0, bytes.Length);
                    received.AddRange(bytes);
                } while (!_pipe.IsMessageComplete);

                return Encoding.UTF8.GetString(received.ToArray());
            }
         
            // This is the wrong way to do this, but I don't care right now.
            private class ReadCallBack
            {
                private readonly NamedPipeClientStream __pipe;
                public bool Done { get; private set; }
                public string Msg { get; private set; }
                private byte[] Bytes;
                List<byte> received;
                public ReadCallBack(NamedPipeClientStream pipe)
                {
                    __pipe = pipe;
                    Bytes = new byte[256];
                    received = new List<byte>();
                    Done = false;
                }

                public void Read()
                {
                    __pipe.BeginRead(Bytes, 0, Bytes.Length, ReadDone, new object());
                }

                private void ReadDone(IAsyncResult result)
                {
                    received.AddRange(Bytes);
                    Bytes.Initialize();
                    if(__pipe.IsMessageComplete)
                    {
                        Msg = Encoding.UTF8.GetString(received.ToArray());
                        Done = true;
                    }
                    else
                    {
                        __pipe.BeginRead(Bytes, 0, Bytes.Length, ReadDone, new object());
                    }
                    __pipe.EndRead(result);
                }
            }
            public string Read(int Timeout)
            {
                ReadCallBack RCB = new ReadCallBack(_pipe);
                RCB.Read();
                int Timer = 0;
                while (!RCB.Done)
                {
                    if (Timer < Timeout)
                    {
                        Timer += 100; //I arbitrarily chose 100 ms intervals
                        System.Threading.Thread.Sleep(100);
                    }
                    else
                    {
                        throw new TimeoutException();
                    }
                }
                return RCB.Msg;
            }
        }

        private struct Result
        {
            public string Name;
            public bool Passed;
            public string Message;
        }

        private const string ServerName = ".";
        private static int Timeout = 3000;
        private const string PipeName = @"CoAppInstaller";
        private static Pipe asyncServer;
        private static Pipe syncServer;
        private static Pipe syncReturn;

        private static string HelpMessage = 
            "\nUsage:  ServicePipes <Sync | Async> <System_Feed_Location> <Session_Feed_Location> <Local_Package_Name> [Timeout]"+
            "\n\n<Local_Package_Name>\tThis should be the path to a package not contained in any feed.\n"+
            "Timeout\t[optional]  Pipe communication timeout, in milliseconds (ms).\n\n";

        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.Out.WriteLine("Insufficient parameters.\n" + HelpMessage);
                return;
            }
            if (args.Length > 4)
                if (!(Int32.TryParse(args[4], out Timeout)))
                    Timeout = 3000;
            
            if (args[0].ToLower().Equals("async"))
            {
                asyncServer = new Pipe(new NamedPipeClientStream(ServerName, PipeName, PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.Impersonation, HandleInheritability.Inheritable));
                if (AsyncConnect().Passed)
                {
                    // Add Async tests here
                    Output(AsyncAddSystemFeed(args[1]));
                    Output(AsyncAddSessionFeed(args[2]));
                    Output(AsyncFindFeeds());
                    Output(AsyncFindAllPackages());
                    Output(AsyncFindPackage_Failure());
                    UrlEncodedMessage LocalPackage, FeedPackage;
                    Output(AsyncRecognizeFile(args[3]));
                    Output(AsyncFindFirstPackageByName(args[3], out LocalPackage));
                    Output(AsyncFindFirstUninstalledPackage(out FeedPackage));
                    Output(AsyncVerifySig(args[3]));
                    Output(AsyncVerifySig(args[3],true));
                    Output(AsyncUnableToAcquire());
                    string LocalPackageCName = "LocalPackage_Failed_To_Be_Found";
                    string FeedPackageCName = "FeedPackage_Failed_To_Be_Found";
                    if (LocalPackage != null)
                        LocalPackageCName = LocalPackage["canonical-name"];
                    if (FeedPackage != null)
                        FeedPackageCName = FeedPackage["canonical-name"];
                    Output(AsyncPackageDetails(FeedPackageCName));
                    Output(AsyncInstallImmaginaryPackage());
                    Output(AsyncInstallLocalPackage(LocalPackageCName));
                    Output(AsyncSetPackageAttribs(LocalPackageCName,null,null,false));
                    Output(AsyncRemovePackage(LocalPackageCName));
                    Output(AsyncRemoveSessionFeed(args[2]));
                    Output(AsyncRemoveSystemFeed(args[1]));

                    asyncServer.Close();
                }
            }
            else if (args[0].ToLower().Equals("sync"))
            {
                syncServer = new Pipe(new NamedPipeClientStream(ServerName, PipeName, PipeDirection.Out, PipeOptions.None, TokenImpersonationLevel.Impersonation, HandleInheritability.Inheritable));
                if (SyncConnect().Passed)
                {
                    // Add Sync tests here
                    Output(SyncAddSystemFeed(args[1]));
                    Output(SyncAddSessionFeed(args[2]));
                    Output(SyncFindFeeds());
                    Output(SyncFindAllPackages());
                    Output(SyncFindPackage_Failure());
                    UrlEncodedMessage LocalPackage, FeedPackage;
                    Output(SyncRecognizeFile(args[3]));
                    Output(SyncFindFirstPackageByName(args[3], out LocalPackage));
                    Output(SyncFindFirstUninstalledPackage(out FeedPackage));
                    Output(SyncVerifySig(args[3]));
                    Output(SyncVerifySig(args[3], true));
                    Output(SyncUnableToAcquire());
                    string LocalPackageCName = LocalPackage["canonical-name"];
                    string FeedPackageCName = FeedPackage["canonical-name"];
                    Output(SyncPackageDetails(FeedPackageCName));
                    Output(SyncInstallImmaginaryPackage());
                    Output(SyncInstallLocalPackage(LocalPackageCName));
                    Output(SyncSetPackageAttribs(LocalPackageCName, null, null, false));
                    Output(SyncRemovePackage(LocalPackageCName));
                    Output(SyncRemoveSessionFeed(args[2]));
                    Output(SyncRemoveSystemFeed(args[1]));


                    syncServer.Close();
                    syncReturn.Close();
                }
            }
            else
            {
                Console.Out.WriteLine("Invalid initial parameter.\n" + HelpMessage);
                return;
            }

        }

        private static void Output(Result result)
        {
            ConsoleColor fg = Console.ForegroundColor;
            if (!result.Passed)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Out.Write(result.Name);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Out.WriteLine(":  " + result.Message + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Out.WriteLine(result.Name);
            }
            Console.ForegroundColor = fg;
        }

        /** Example of test method to be called by Main()
         
        private static Result TestMethod()
        {
            Result TestResult = new Result();
            TestResult.Message = "Message for if I fail.";
            //Do stuff here.
            TestResult.Passed = false;
            return TestResult;
        }
        
        **/

        private static Result AsyncConnect()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed async connection.";
            TestResult.Passed = false;
            try
            {
                //Send the connection message
                asyncServer.Connect(Timeout); // 5 second maximum wait time for initial connect.
                asyncServer.pipe.ReadMode = PipeTransmissionMode.Message;
                UrlEncodedMessage msg = new UrlEncodedMessage("start-session", new Dictionary<string, string>());
                msg.Add("client","AsyncTestClient");
                msg.Add("id","MyUniqueID");
                asyncServer.Write(msg.ToString());

                //Receive the response
                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                // check the command and data to make sure it's correct;
                switch (response.Command.ToLower())
                {
                    case "session-started":
                        TestResult.Passed = true;
                        break;
                    default:
                        break;
                }
            }
            catch (TimeoutException)
                { TestResult.Message += "  Timeout expired."; }
            catch {}

            return TestResult;
        }

        private static Result SyncConnect()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed sync connection.";
            TestResult.Passed = false;
            try
            {
                //Send the connection message
                syncServer.Connect(Timeout);
                syncServer.pipe.ReadMode = PipeTransmissionMode.Message;
                UrlEncodedMessage msg = new UrlEncodedMessage("start-session", new Dictionary<string, string>());
                msg.Add("client","SyncTestClient");
                msg.Add("id","SyncUniqueID");
                msg.Add("async","false");
                syncServer.Write(msg.ToString());

                //Receive the response
                syncReturn = new Pipe(new NamedPipeClientStream(ServerName, PipeName + "-SyncUniqueID", PipeDirection.In, PipeOptions.None, TokenImpersonationLevel.Impersonation, HandleInheritability.Inheritable));
                syncReturn.Connect(Timeout);
                syncReturn.pipe.ReadMode = PipeTransmissionMode.Message;
                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                // check the command and data to make sure it's correct;
                switch (response.Command)
                {
                    case "session-started":
                        TestResult.Passed = true;
                        break;
                    default:
                        break;
                }
            }
            catch (TimeoutException)
                { TestResult.Message += "  Timeout expired."; }
            catch { }

            return TestResult;
        }

        private static Result AsyncAddSystemFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed adding Async feed.";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("add-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result SyncAddSystemFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed adding Sync feed.";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("add-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result AsyncAddSessionFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed adding Async feed.";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("add-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                msg.Add("session", "true");
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result SyncAddSessionFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed adding Sync feed.";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("add-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                msg.Add("session", "true");
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result AsyncFindFeeds()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed adding Async feed.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-feeds", new Dictionary<string, string>());
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-feed"))
                        TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncFindFeeds()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find feeds.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-feeds", new Dictionary<string, string>());
                syncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-feed"))
                        TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncFindAllPackages()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find packages.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-package"))
                        TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncFindPackage_Failure()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to fail properly when finding an invalid package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("name", "IAm_A_nonExistant_package_NaMe");
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("no-packages-found"))
                    TestResult.Passed = true;
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncFindFirstUninstalledPackage(out UrlEncodedMessage package)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find any uninstalled packages.";
            TestResult.Passed = false;
            package = null;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("installed", "false");
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-package"))
                    {
                        TestResult.Passed = true;
                        package = package ?? response;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncFindFirstPackageByName(string name, out UrlEncodedMessage package, string installed = "all")
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find a package by the name \""+name+"\".";
            TestResult.Passed = false;
            package = null;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("name", "false");
                msg.Add("installed",installed);
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-package"))
                    {
                        TestResult.Passed = true;
                        package = package ?? response;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncInstallImmaginaryPackage()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to fail properly on installing an invalid package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("install-package", new Dictionary<string, string>());
                msg.Add("canonical-name", "IAm_A_nonExistant_package-1.0.0.0-any");
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("unknown-package"))
                {
                    TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncInstallLocalPackage(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to installe package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("install-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                bool running = true;
                while (running)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "signature-validation":
                            //do nothing
                            break;
                        case "installed-package":
                            TestResult.Passed = true;
                            break;
                        case "installing-package":
                            //do nothing
                            break;
                        case "failed-install-package":
                            TestResult.Passed = false;
                            break;
                        case "package-is-blocked":
                            TestResult.Passed = false;
                            break;
                        case "unknown-package":
                            TestResult.Passed = false;
                            break;
                        case "operation-requires-permission":
                            TestResult.Passed = false;
                            break;
                        case "message-argument-error":
                            TestResult.Passed = false;
                            break;
                        case "require-remote-file":
                            TestResult.Passed = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncRecognizeFile(string Location, string Remote = null, bool isPackage = true)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to recognize file.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("recognize-file", new Dictionary<string, string>());
                msg.Add("location", Location);
                if (Remote != null)
                    msg.Add("remote-location", Remote);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("found-package") && isPackage)
                {
                    TestResult.Passed = true;
                }
            }
            catch (TimeoutException) { if (!isPackage) TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result AsyncPackageDetails(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to get package details.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("get-package-details", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("package-details"))
                {
                    TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncVerifySig(string FileName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to verify signature.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("verify-file-signature", new Dictionary<string, string>());
                msg.Add("filename", FileName);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("signature-validation"))
                {
                    TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncVerifySig(string FileName, bool isValid)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to verify signature.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("verify-file-signature", new Dictionary<string, string>());
                msg.Add("filename", FileName);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("signature-validation"))
                {
                    bool? validValue = (response["is-valid"]);
                    bool valid = validValue ?? false;
                    TestResult.Passed = (valid == isValid);
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncRemovePackage(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove package: \""+CanonicalName+"\".";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                bool running = true;
                while (running)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "removed-package":
                            TestResult.Passed = true;
                            break;
                        case "removing-package":
                            //do nothing
                            break;
                        case "failed-install-package":
                            TestResult.Passed = false;
                            break;
                        case "package-is-blocked":
                            TestResult.Passed = false;
                            break;
                        case "unknown-package":
                            TestResult.Passed = false;
                            break;
                        case "operation-requires-permission":
                            TestResult.Passed = false;
                            break;
                        case "message-argument-error":
                            TestResult.Passed = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AsyncUnableToAcquire(string RemoteLocation = "Bad_File_Location")
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Error sending message of type: \"unable-to-acquire\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("unable-to-acquire", new Dictionary<string, string>());
                msg.Add("remote-location", RemoteLocation);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result AsyncRemoveSystemFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove system feed: \"" + Location + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result AsyncRemoveSessionFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove session feed: \"" + Location + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                msg.Add("session", "true");
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        /// <summary>
        /// Attempts to set the attributes of a package.
        /// </summary>
        /// <param name="CanonicalName">Canonical Name of the package to alter.</param>
        /// <param name="Active">Set to True or False.  Pass 'null' to leave unchanged.</param>
        /// <param name="Required">Set to True or False.  Pass 'null' to leave unchanged.</param>
        /// <param name="Blocked">Set to True or False.  Pass 'null' to leave unchanged.</param>
        /// <returns></returns>
        private static Result AsyncSetPackageAttribs(string CanonicalName, bool? Active, bool? Required, bool? Blocked)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to set package attributes for package: \"" + CanonicalName + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                if (Active != null)
                {
                    bool _val = Active ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                if (Required != null)
                {
                    bool _val = Required ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                if (Blocked != null)
                {
                    bool _val = Blocked ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) {TestResult.Passed = true;}
            catch {}

            //verify that the change occurred
            UrlEncodedMessage check = AsyncGetPackage(CanonicalName);
            if (check != null)
            {
                if (Active != null)
                    if (Active != ((bool?) check["active"] ?? false))
                        TestResult.Passed = false;
                if (Required != null)
                    if (Required != ((bool?) check["required"] ?? false))
                        TestResult.Passed = false;
                if (Blocked != null)
                    if (Blocked != ((bool?) check["blocked"] ?? false))
                        TestResult.Passed = false;
            }
            else
            {
                TestResult.Message += "\n\tUnable to confirm successful settings change.";
                TestResult.Passed = false;
            }

            return TestResult;
        }

        private static UrlEncodedMessage AsyncGetPackage(string CanonicalName, bool? Installed = null)
        {
            UrlEncodedMessage ret = null;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                msg.Add("installed", (Installed != null ? ((Installed ?? false) ? "true" : "false") : "all"));
                asyncServer.Write(msg.ToString());

                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    if (response.Command.Equals("found-package"))
                    {
                        ret = ret ?? response;
                    }
                }
            }
            catch { }
            return ret;
        }

        private static Result SyncFindAllPackages()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find packages.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                syncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-package"))
                        TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncFindPackage_Failure()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to fail properly when seeking an invalid package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("name", "IAm_A_nonExistant_package_NaMe");
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("no-packages-found"))
                    TestResult.Passed = true;
            }
            catch { }

            return TestResult;
        }

        private static Result SyncFindFirstUninstalledPackage(out UrlEncodedMessage package)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find any uninstalled packages.";
            TestResult.Passed = false;
            package = null;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("installed", "false");
                syncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-package"))
                    {
                        TestResult.Passed = true;
                        package = package ?? response;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncFindFirstPackageByName(string name, out UrlEncodedMessage package, string installed = "all")
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find a package by the name \"" + name + "\".";
            TestResult.Passed = false;
            package = null;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("name", "false");
                msg.Add("installed", installed);
                syncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    if (response.Command.Equals("found-package"))
                    {
                        TestResult.Passed = true;
                        package = package ?? response;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncInstallImmaginaryPackage()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to fail properly on installing invalid package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("install-package", new Dictionary<string, string>());
                msg.Add("canonical-name", "IAm_A_nonExistant_package-1.0.0.0-any");
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("unknown-package"))
                {
                    TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncInstallLocalPackage(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to install package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("install-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                syncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                bool running = true;
                while (running)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "signature-validation":
                            //do nothing
                            break;
                        case "installed-package":
                            TestResult.Passed = true;
                            break;
                        case "installing-package":
                            //do nothing
                            break;
                        case "failed-install-package":
                            TestResult.Passed = false;
                            break;
                        case "package-is-blocked":
                            TestResult.Passed = false;
                            break;
                        case "unknown-package":
                            TestResult.Passed = false;
                            break;
                        case "operation-requires-permission":
                            TestResult.Passed = false;
                            break;
                        case "message-argument-error":
                            TestResult.Passed = false;
                            break;
                        case "require-remote-file":
                            TestResult.Passed = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncRecognizeFile(string Location, string Remote = null, bool isPackage = true)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to recognize file.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("recognize-file", new Dictionary<string, string>());
                msg.Add("location", Location);
                if (Remote != null)
                    msg.Add("remote-location", Remote);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("found-package") && isPackage)
                {
                    TestResult.Passed = true;
                }
            }
            catch (TimeoutException) { if (!isPackage) TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result SyncPackageDetails(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to get package details.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("get-package-details", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("package-details"))
                {
                    TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncVerifySig(string FileName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find packages.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("verify-file-signature", new Dictionary<string, string>());
                msg.Add("filename", FileName);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("signature-validation"))
                {
                    TestResult.Passed = true;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncVerifySig(string FileName, bool isValid)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to verify signature.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("verify-file-signature", new Dictionary<string, string>());
                msg.Add("filename", FileName);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("signature-validation"))
                {
                    bool? validValue = (response["is-valid"]);
                    bool valid = validValue ?? false;
                    TestResult.Passed = (valid == isValid);
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncRemovePackage(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove package: \"" + CanonicalName + "\".";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                syncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                bool running = true;
                while (running)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "removed-package":
                            TestResult.Passed = true;
                            break;
                        case "removing-package":
                            //do nothing
                            break;
                        case "failed-install-package":
                            TestResult.Passed = false;
                            break;
                        case "package-is-blocked":
                            TestResult.Passed = false;
                            break;
                        case "unknown-package":
                            TestResult.Passed = false;
                            break;
                        case "operation-requires-permission":
                            TestResult.Passed = false;
                            break;
                        case "message-argument-error":
                            TestResult.Passed = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result SyncUnableToAcquire(string RemoteLocation = "Bad_File_Location")
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Error sending message of type: \"unable-to-acquire\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("unable-to-acquire", new Dictionary<string, string>());
                msg.Add("remote-location", RemoteLocation);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result SyncRemoveSystemFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove system feed: \"" + Location + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result SyncRemoveSessionFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove session feed: \"" + Location + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                msg.Add("session", "true");
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        /// <summary>
        /// Attempts to set the attributes of a package.
        /// </summary>
        /// <param name="CanonicalName">Canonical Name of the package to alter.</param>
        /// <param name="Active">Set to True or False.  Pass 'null' to leave unchanged.</param>
        /// <param name="Required">Set to True or False.  Pass 'null' to leave unchanged.</param>
        /// <param name="Blocked">Set to True or False.  Pass 'null' to leave unchanged.</param>
        /// <returns></returns>
        private static Result SyncSetPackageAttribs(string CanonicalName, bool? Active, bool? Required, bool? Blocked)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to set package attributes for package: \"" + CanonicalName + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                if (Active != null)
                {
                    bool _val = Active ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                if (Required != null)
                {
                    bool _val = Required ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                if (Blocked != null)
                {
                    bool _val = Blocked ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                syncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                //in this test, receiving a message means that a failure has occurred.
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static UrlEncodedMessage SyncGetPackage(string CanonicalName, bool? Installed = null)
        {
            UrlEncodedMessage ret = null;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                msg.Add("installed", (Installed != null ? ((Installed ?? false) ? "true" : "false") : "all"));
                syncServer.Write(msg.ToString());

                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(syncReturn.Read(Timeout));
                    if (response.Command.Equals("found-package"))
                    {
                        ret = ret ?? response;
                    }
                }
            }
            catch { }
            return ret;
        }



    }
}
