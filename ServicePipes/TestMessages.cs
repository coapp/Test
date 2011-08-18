using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
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

        private static int Timeout = 3000;
        private const string PipeName = @"CoAppInstaller";
        private static Pipe asyncServer;
        private static Pipe syncServer;
        private static Pipe syncReturn;

        private static string HelpMessage = @"
Usage:  ServicePipes <Sync | Async> <System_Feed_Location> <Session_Feed_Location> <Local_Package_Name> [Timeout]

<Local_Package_Name>\tThis should be the path to a package not contained in any feed.
Timeout\t[optional]  Pipe communication timeout, in milliseconds (ms).

";

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
            List<Result> Results = new List<Result>();
            asyncServer = new Pipe(new NamedPipeClientStream(PipeName));
            syncServer = new Pipe(new NamedPipeClientStream(PipeName));

            if (args[0].ToLower().Equals("async"))
            {
                Results.Add(AsyncConnect());
                if (Results[Results.Count - 1].Passed)
                {
                    // Add Async tests here
                    Results.Add(AsyncAddSystemFeed(args[1]));
                    Results.Add(AsyncAddSessionFeed(args[2]));
                    Results.Add(AsyncFindFeeds());
                    Results.Add(AsyncFindAllPackages());
                    Results.Add(AsyncFindPackage_Failure());
                    UrlEncodedMessage LocalPackage, FeedPackage;
                    Results.Add(AsyncRecognizeFile(args[3]));
                    Results.Add(AsyncFindFirstPackageByName(args[3], out LocalPackage));
                    Results.Add(AsyncFindFirstUninstalledPackage(out FeedPackage));
                    Results.Add(AsyncVerifySig(args[3]));
                    Results.Add(AsyncVerifySig(args[3],true));
                    Results.Add(AsyncUnableToAcquire());
                    string LocalPackageCName = LocalPackage["canonical-name"];
                    string FeedPackageCName = FeedPackage["canonical-name"];
                    Results.Add(AsyncPackageDetails(FeedPackageCName));
                    Results.Add(AsyncInstallImmaginaryPackage());
                    Results.Add(AsyncInstallLocalPackage(LocalPackageCName));
                    Results.Add(AsyncSetPackageAttribs(LocalPackageCName,null,null,false));
                    Results.Add(AsyncRemovePackage(LocalPackageCName));
                    Results.Add(AsyncRemoveSessionFeed(args[2]));
                    Results.Add(AsyncRemoveSystemFeed(args[1]));
                }
            }
            else if (args[0].ToLower().Equals("sync"))
            {
                Results.Add(SyncConnect());
                if (Results[Results.Count - 1].Passed)
                {
                    // Add Sync tests here
                    Results.Add(SyncAddSystemFeed(args[1]));
                    Results.Add(SyncAddSessionFeed(args[2]));
                    Results.Add(SyncFindFeeds());
                    Results.Add(SyncFindAllPackages());
                    Results.Add(SyncFindPackage_Failure());
                    UrlEncodedMessage LocalPackage, FeedPackage;
                    Results.Add(SyncRecognizeFile(args[3]));
                    Results.Add(SyncFindFirstPackageByName(args[3], out LocalPackage));
                    Results.Add(SyncFindFirstUninstalledPackage(out FeedPackage));
                    Results.Add(SyncVerifySig(args[3]));
                    Results.Add(SyncVerifySig(args[3], true));
                    Results.Add(SyncUnableToAcquire());
                    string LocalPackageCName = LocalPackage["canonical-name"];
                    string FeedPackageCName = FeedPackage["canonical-name"];
                    Results.Add(SyncPackageDetails(FeedPackageCName));
                    Results.Add(SyncInstallImmaginaryPackage());
                    Results.Add(SyncInstallLocalPackage(LocalPackageCName));
                    Results.Add(SyncSetPackageAttribs(LocalPackageCName, null, null, false));
                    Results.Add(SyncRemovePackage(LocalPackageCName));
                    Results.Add(SyncRemoveSessionFeed(args[2]));
                    Results.Add(SyncRemoveSystemFeed(args[1]));
                }
            }
            else
            {
                Console.Out.WriteLine("Invalid initial parameter.\n" + HelpMessage);
                return;
            }

            // display results
            foreach (Result result in Results)
            {
                ConsoleColor fg = Console.ForegroundColor;
                if (!result.Passed)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Out.Write(result.Name);
                
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Out.WriteLine(":  "+result.Message+"\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Out.WriteLine(result.Name);
                }
                Console.ForegroundColor = fg;
            }
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
            TestResult.Message = "Failed sync connection.";
            TestResult.Passed = false;
            try
            {
                //Send the connection message
                asyncServer.Connect(Timeout); // 5 second maximum wait time for initial connect.
                UrlEncodedMessage msg = new UrlEncodedMessage("start-session",new Dictionary<string, string>());
                msg.Add("client","SyncTestClient");
                msg.Add("id","MyUniqueID");
                asyncServer.Write(msg.ToString());

                //Receive the response
                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
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
            catch {}

            return TestResult;
        }

        private static Result SyncConnect()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed async connection.";
            TestResult.Passed = false;
            try
            {
                //Send the connection message
                syncServer.Connect(Timeout);
                UrlEncodedMessage msg = new UrlEncodedMessage("start-session",new Dictionary<string, string>());
                msg.Add("client","AsyncTestClient");
                msg.Add("id","AsyncUniqueID");
                msg.Add("async","false");
                syncServer.Write(msg.ToString());

                //Receive the response
                syncReturn = new Pipe(new NamedPipeClientStream(PipeName + "-AsyncUniqueID"));
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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
                syncServer.Write(msg.ToString());

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
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            //verify that the change occurred
            UrlEncodedMessage check = AsyncGetPackage(CanonicalName);
            if (Active != null)
                if (Active != ((bool?)check["active"] ?? false))
                    TestResult.Passed = false;
            if (Required != null)
                if (Required != ((bool?)check["required"] ?? false))
                    TestResult.Passed = false;
            if (Blocked != null)
                if (Blocked != ((bool?)check["blocked"] ?? false))
                    TestResult.Passed = false;
            

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
                syncServer.Write(msg.ToString());

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
                asyncServer.Write(msg.ToString());

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
                asyncServer.Write(msg.ToString());

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
                asyncServer.Write(msg.ToString());

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
                asyncServer.Write(msg.ToString());

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
