using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Security.Principal;
using System.Text;
using CoApp.Toolkit.Pipes;

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
                public IAsyncResult Current { get; private set; }
                public string Msg { get; private set; }
                private byte[] Bytes;
                List<byte> received;
                public ReadCallBack(NamedPipeClientStream pipe)
                {
                    __pipe = pipe;
                    Bytes = new byte[8192];
                    received = new List<byte>();
                    Done = false;
                }

                public void Read()
                {
                    Current = __pipe.BeginRead(Bytes, 0, Bytes.Length, ReadDone, new object());
                }

                private void ReadDone(IAsyncResult result)
                {
                    __pipe.EndRead(result);
                    int i = 0;
                    while (i < Bytes.Length && Bytes[i] > 0)
                        received.Add(Bytes[i++]);

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
                        _pipe.EndRead(RCB.Current);
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
            public string Success;
            public UrlEncodedMessage Command;
        }

        private const string ServerName = ".";
        private static int DefaultTimeout = 15000;
        private static int Timeout = 15000;
        private const string PipeName = @"CoAppInstaller";
        private static Pipe asyncServer;

        private const string StartError = "\x1b[40;1;31m";
        private const string EndError = "\x1b[m";
        private static bool ANSI = false;
        private static int ErrCount;

        private const string HelpMessage = 
            "\nUsage:  ServicePipes --sysfeed=<System_Feed_Location> --sesfeed=<Session_Feed_Location> --package=<Local_Package_Name> [optional switches]"+
            "\n\n<Local_Package_Name>\tThis should be the path to a package not contained in any feed.\n"+
            "\n[optional parameters]\n"+
            "\ttimeout\tPipe communication timeout, in milliseconds (ms).\n"+
            "\tANSI\tOutput will use ANSI color instead of Windows Console color.\n\n";

        static int Main(string[] args)
        {
            args.Switches();
            ErrCount = 0;

            if (args.SwitchValue("help") != null)
            {
                Console.Out.WriteLine(HelpMessage);
                return -1;
            }

            if (args.SwitchValue("timeout") != null)
                if (!(Int32.TryParse(args.SwitchValue("timeout"), out Timeout)))
                    Timeout = DefaultTimeout;

            string sysfeed = args.SwitchValue("sysfeed");
            string sesfeed = args.SwitchValue("sesfeed");
            string pack = args.SwitchValue("package");

            if (args.SwitchValue("ansi") != null)
                ANSI = true;
            
            if (sysfeed == null || sesfeed == null || pack == null)
            {
                Console.Out.WriteLine(HelpMessage);
                return -1;
            }

            asyncServer = new Pipe(new NamedPipeClientStream(ServerName, PipeName, PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.Impersonation, HandleInheritability.Inheritable));
            //asyncServer = new Pipe(new NamedPipeClientStream(PipeName));
            if (Connect().Passed)
            {
                // Add Async tests here
                Output(AddSystemFeed(sysfeed));
                Output(AddSessionFeed(sesfeed));
                Output(FindFeeds());
                Output(FindPackage_Failure());
                UrlEncodedMessage LocalPackage, FeedPackage;
                Output(RecognizeFile(pack));
                Output(FindAllPackages());
                string LocalName = pack.Substring(pack.LastIndexOf(@"\") + 1);
                LocalName = LocalName.Substring(0, LocalName.IndexOf('-'));
                Output(FindFirstPackageByName(LocalName, out LocalPackage));
                Output(FindFirstUninstalledPackage(out FeedPackage));
                Output(VerifySig(pack));
                Output(VerifySig(pack,true));
                Output(UnableToAcquire());
                string LocalPackageCName = "LocalPackage_Failed_To_Be_Found";
                string FeedPackageCName = "FeedPackage_Failed_To_Be_Found";
                if (LocalPackage != null)
                    LocalPackageCName = LocalPackage["canonical-name"];
                if (FeedPackage != null)
                    FeedPackageCName = FeedPackage["canonical-name"];
                Output(PackageDetails(FeedPackageCName));
                Output(InstallImmaginaryPackage());
                Output(InstallLocalPackage(LocalPackageCName));
                Output(SetPackageAttribs(LocalPackageCName,null,null,false));
                Output(RemovePackage(LocalPackageCName));
                Output(RemoveSessionFeed(sesfeed));
                Output(RemoveSystemFeed(sysfeed));

                asyncServer.Close();
            }

            return ErrCount;
        }

        private static void Output(Result result)
        {
            ConsoleColor fg = Console.ForegroundColor;
            if (!result.Passed)
            {
                ErrCount += 1;

                if (ANSI)
                {
                    Console.Out.Write(StartError);
                    Console.Out.WriteLine(result.Name);
                    Console.Out.Write(EndError);
                    Console.Out.WriteLine("Command sent: " + result.Command.ToString());
                    Console.Out.WriteLine("\t" + result.Message + "\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Out.WriteLine(result.Name);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Out.WriteLine("Command sent: " + result.Command.ToString());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Out.WriteLine("\t" + result.Message + "\n");
                }
            }
            else
            {
                if (ANSI)
                {
                    Console.Out.Write(result.Name);
                    Console.Out.WriteLine(result.Success ?? string.Empty);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Out.Write(result.Name);
                    //Console.ForegroundColor = ConsoleColor.DarkGreen;
                    //Console.Out.Write(" -- " + result.Command.ToString());
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Out.WriteLine(result.Success ?? string.Empty);
                }
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

        private static Result Connect()
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

        private static Result AddSystemFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed adding Async feed.";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("add-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                switch (response.Command)
                {
                    case "feed-added":
                        TestResult.Passed = true;
                        break;
                    default:
                        break;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result AddSessionFeed(string Location)
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
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                switch (response.Command)
                {
                    case "feed-added":
                        TestResult.Passed = true;
                        break;
                    default:
                        break;
                }
            }
            catch { }

            return TestResult;
        }

        private static Result FindFeeds()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find feeds.";
            TestResult.Passed = false;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-feeds", new Dictionary<string, string>());
                msg.Add("rqid",TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "found-feed":
                            TestResult.Passed = true;
                            break;
                        case "task-complete":
                            Loop = false;
                            break;
                        default:
                            TestResult.Success += "\n\tUnexpected Message: " + response.ToString();
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result FindAllPackages()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find packages.";
            TestResult.Passed = false;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-packages", new Dictionary<string, string>());
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "found-package":
                            TestResult.Passed = true;
                            //TestResult.Success += "\n" + response["canonical-name"];
                            break;
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            TestResult.Success += "\n\tUnexpected Message: " + response.ToString();
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result FindPackage_Failure()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to fail properly when finding an invalid package.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-packages", new Dictionary<string, string>());
                msg.Add("name", "IAm_A_nonExistant_package_NaMe");
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("require-remote-file"))
                {
                    bool KeepGoing = true;
                    int remoteNum = 0;
                    string destination = Path.Combine(response["destination"], response["canonical-name"]);
                    while (KeepGoing)
                    {
                        if (!(response["remote-locations[" + remoteNum + "]"].Equals(String.Empty)))
                            try
                            {
                                System.Net.WebClient WC = new System.Net.WebClient();
                                WC.DownloadFile(response["remote-locations[" + remoteNum++ + "]"], destination);
                                if (File.Exists(destination))
                                    KeepGoing = false;
                            }
                            catch (Exception E)
                            {
                                KeepGoing = false;
                            }
                        else
                            KeepGoing = false;
                    }

                    UrlEncodedMessage msg2;
                    if (File.Exists(destination))
                    {
                        msg2 = new UrlEncodedMessage("recognize-file", new Dictionary<string, string>());
                        msg2.Add("local-location", destination);
                    }
                    else
                    {
                        msg2 = new UrlEncodedMessage("unable-to-acquire", new Dictionary<string, string>());
                    }
                    msg2.Add("canonical-name", response["canonical-name"].ToString());
                    asyncServer.Write(msg2.ToString());

                    response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("  Received message:\n\t" + response.ToString());
                }
                if (response.Command.Equals("no-packages-found"))
                    TestResult.Passed = true;
            }
            catch { }

            return TestResult;
        }

        private static Result FindFirstUninstalledPackage(out UrlEncodedMessage package)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find any uninstalled packages.";
            TestResult.Passed = false;
            package = null;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-packages", new Dictionary<string, string>());
                msg.Add("installed", "false");
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "found-package":
                            TestResult.Passed = true;
                            package = package ?? response;
                            break;
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            TestResult.Success += "\n\tUnexpected Message: " + response.ToString();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result FindFirstPackageByName(string name, out UrlEncodedMessage package, string installed = "all")
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to find a package by the name \""+name+"\".";
            TestResult.Passed = false;
            package = null;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-packages", new Dictionary<string, string>());
                msg.Add("name", name);
                msg.Add("installed",installed);
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "found-package":
                            TestResult.Passed = true;
                            package = package ?? response;
                            break;
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            TestResult.Success += "\n\tUnexpected Message: " + response.ToString();
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result InstallImmaginaryPackage()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to fail properly on installing an invalid package.";
            TestResult.Passed = false;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("install-package", new Dictionary<string, string>());
                msg.Add("canonical-name", "IAm_A_nonExistant_package-1.0.0.0-any-da642a7e5cd46921");
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("  Received message:\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "unknown-package":
                            TestResult.Passed = true;
                            break;
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            TestResult.Success += "\n\tUnexpected Message: " + response.ToString();
                            break;
                    }
                }
            }
            catch { }

            return TestResult;
        }

        private static Result InstallLocalPackage(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to install package.";
            TestResult.Passed = false;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("install-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (Loop)
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
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result RecognizeFile(string Location, string Remote = null, bool valid = true, bool? isPackage = true)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to recognize file.";
            TestResult.Passed = false;
            bool Loop = true;
                
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("recognize-file", new Dictionary<string, string>());
                msg.Add("local-location", Location);
                if (Remote != null)
                    msg.Add("remote-location", Remote);
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                                TestResult.Message += "  Received message(s):";
                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("  Received message:\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "found-package":
                            if (isPackage ?? true)
                                TestResult.Passed = true;
                            else
                                TestResult.Passed = false;
                            break;
                        case "found-feed":
                            if (!(isPackage ?? false))
                                TestResult.Passed = true;
                            else
                                TestResult.Passed = false;
                            break;
                        case "unable-to-recognize-file":
                            if (!valid)
                                TestResult.Passed = true;
                            else
                                TestResult.Passed = false;
                            break;
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result PackageDetails(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to get package details.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("get-package-details", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                TestResult.Command = msg;
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

        private static Result VerifySig(string FileName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to verify signature.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("verify-file-signature", new Dictionary<string, string>());
                msg.Add("filename", FileName);
                TestResult.Command = msg;
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

        private static Result VerifySig(string FileName, bool isValid)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to verify signature.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("verify-file-signature", new Dictionary<string, string>());
                msg.Add("filename", FileName);
                TestResult.Command = msg;
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

        private static Result RemovePackage(string CanonicalName)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove package: \""+CanonicalName+"\".";
            TestResult.Passed = false;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (Loop)
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
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                                Loop = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result UnableToAcquire(string CanonicalName = "Bad_Location-1.0.0.0-any-da642a7e5cd46921")
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Error sending message of type: \"unable-to-acquire\".";
            TestResult.Passed = false;
            bool Loop = true;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("unable-to-acquire", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                msg.Add("rqid", TestResult.Name);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                while (Loop)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("  Received message:\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "task-complete":
                            if (response["rqid"] == TestResult.Name)
                            {
                                Loop = false;
                                TestResult.Passed = true;
                            }
                            break;
                        default:
                            TestResult.Success += "\n\tUnexpected Message: " + response.ToString();
                            break;
                    }
                }
            }
            catch
            {
                if (Loop)
                {
                    TestResult.Passed = false;
                    TestResult.Message += "\n\tException thrown before operation completed.";
                }
            }

            return TestResult;
        }

        private static Result RemoveSystemFeed(string Location)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to remove system feed: \"" + Location + "\".";
            TestResult.Passed = false;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("remove-feed", new Dictionary<string, string>());
                msg.Add("location", Location);
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("feed-removed"))
                {
                    if (Location.Equals(response["location"]))
                        TestResult.Passed = true;
                }
            }
            catch (TimeoutException) { TestResult.Passed = true; }
            catch { }

            return TestResult;
        }

        private static Result RemoveSessionFeed(string Location)
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
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + response.ToString());
                if (response.Command.Equals("feed-removed"))
                {
                    if (Location.Equals(response["location"]))
                        TestResult.Passed = true;
                }
            }
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
        private static Result SetPackageAttribs(string CanonicalName, bool? Active, bool? Required, bool? Blocked)
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to set package attributes for package: \"" + CanonicalName + "\".";
            TestResult.Passed = false;

            UrlEncodedMessage check = null;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("set-package", new Dictionary<string, string>());
                msg.Add("canonical-name", CanonicalName);
                if (Active != null)
                {
                    bool _val = Active ?? false; // Active should never be null at this point in the code.
                    msg.Add("active", _val ? "true" : "false");
                }
                if (Required != null)
                {
                    bool _val = Required ?? false; // Active should never be null at this point in the code.
                    msg.Add("required", _val ? "true" : "false");
                }
                if (Blocked != null)
                {
                    bool _val = Blocked ?? false; // Active should never be null at this point in the code.
                    msg.Add("blocked", _val ? "true" : "false");
                }
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                check = new UrlEncodedMessage(asyncServer.Read(Timeout));
                TestResult.Message += ("  Received message:\n\t" + check.ToString());
                if (check.Command.Equals("found-package"))
                    TestResult.Passed = true;
            }
            catch {}

            //verify that the change occurred
            //UrlEncodedMessage check = GetPackage(CanonicalName);
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

        private static UrlEncodedMessage GetPackage(string CanonicalName, bool? Installed = null)
        {
            UrlEncodedMessage ret = null;
            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("find-packages", new Dictionary<string, string>());
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

        private static Result StupidLongAddFeedRequest()
        {
            Result TestResult = new Result();
            TestResult.Name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            TestResult.Message = "Failed to parse a stupidly long request message.";
            TestResult.Passed = false;

            try
            {
                UrlEncodedMessage msg = new UrlEncodedMessage("add-feed",new Dictionary<string, string>());
                msg.Add("session",true);
                msg.Add("rant", "This is BS data that I have written here solely for the purpose of trying to break a piece of software that I have been detailed with testing.  There is no other task with which humanity has become adept at since the dawning of time than that of destruction, and I now find myself tasked with attempting to systematically pull apart software such that I can acurately and precisely describe the means by which it was broken.  As I have now reached the end of my tirade, the next value will consist solely of Lorem Ipsum text.");
                msg.Add("lorem ipsum1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius aliquam vehicula. Nulla facilisi. Nulla pulvinar arcu non erat aliquet suscipit mollis augue molestie. Maecenas feugiat laoreet posuere. Maecenas congue ante eget lectus dignissim sit amet egestas neque congue. Vivamus dictum quam quis arcu faucibus dignissim. Duis sed massa vel nisi hendrerit rhoncus eget ac eros. Sed porttitor orci non ipsum dictum sed molestie mi egestas. Nunc pulvinar, enim in sollicitudin semper, augue quam venenatis quam, nec faucibus nibh urna nec libero. Pellentesque accumsan auctor massa, in aliquet lacus varius eu. Vestibulum nec nunc sit amet sem rutrum molestie in vel massa. Fusce sodales pharetra tortor at tempus. Nunc lorem leo, viverra ut cursus a, auctor eget magna. Vivamus vel nunc fringilla ipsum vulputate dapibus vel non quam. Nunc fringilla magna id purus imperdiet quis porttitor nisl laoreet. Vestibulum sit amet libero et tellus vestibulum vulputate. Donec venenatis lorem eu nisi tempor et rhoncus mauris scelerisque. Cras scelerisque pharetra dui sagittis feugiat. Phasellus porttitor congue lectus sit amet ullamcorper. Sed justo lorem, sagittis at fermentum id, sagittis id leo. Duis vehicula ipsum sit amet nisl accumsan dapibus. Sed accumsan, lectus eu aliquam commodo, velit urna dapibus sem, et varius nulla sapien ac purus. Curabitur luctus dictum nisi, sit amet malesuada ligula blandit vel. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Curabitur viverra tempus interdum. Etiam tincidunt dolor a mi blandit ornare. Aliquam in dolor leo. In hac habitasse platea dictumst. Cras semper urna at augue hendrerit et elementum nibh dapibus. Aenean luctus pretium purus at condimentum. Duis vulputate imperdiet neque vel varius. Nulla placerat iaculis felis. Phasellus nibh tellus, congue nec egestas in, varius iaculis augue. Nullam et urna nec est tincidunt gravida ullamcorper vel metus. Ut volutpat ullamcorper tellus nec iaculis. Duis vestibulum semper molestie. In vehicula neque ac nunc mattis adipiscing at tempus orci. Fusce non est tortor. Etiam convallis aliquet risus, eu condimentum orci molestie vel. Nunc elementum sem tempus augue volutpat rutrum. Donec vitae dui arcu. Vestibulum vel nisi diam, pretium porttitor augue. Sed dictum, magna at fermentum sodales, nulla ante iaculis est, eget cursus eros sem sed leo. Vestibulum in enim non nisl tempus cursus nec quis nulla. Cras dapibus, lectus a feugiat rhoncus, velit elit hendrerit dolor, eu scelerisque tellus quam sed velit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nunc non mi metus, non ultrices lectus. Etiam lobortis, nisi ut rutrum iaculis, nisi mauris sodales mauris, in congue tellus sem mollis risus. Integer ut tempor felis. Nulla facilisi. Duis sed viverra mi. Donec pulvinar pulvinar vulputate. Maecenas in diam eu diam ullamcorper porttitor quis iaculis mauris. Curabitur tincidunt velit id ipsum aliquam et aliquet purus iaculis. Nulla at felis libero, vitae imperdiet ipsum. Sed vehicula, justo non mollis aliquam, felis magna fringilla tortor, et gravida mauris massa vitae sapien. Ut at tellus justo. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse feugiat, elit non consectetur hendrerit, sem libero fermentum felis, et convallis nisl orci sit amet erat. Nulla vitae mollis arcu. Aenean leo nisi, cursus in interdum id, congue quis arcu. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque accumsan ante ut leo euismod non viverra massa sagittis. Donec lobortis cursus tincidunt. Sed quis nisl erat. Fusce faucibus aliquam sollicitudin. Phasellus ac auctor ligula. Aenean semper augue id nibh faucibus eu vestibulum quam tincidunt. Donec non urna orci. Maecenas nec eleifend urna. Nulla lacinia lorem in velit semper tincidunt. Proin vitae dolor nec purus pharetra congue ornare eget sem. Nulla consequat, est at dictum pulvinar, purus nibh posuere ante, et elementum lacus lacus et elit. Cras lobortis dolor vel neque tempus dapibus. Aliquam erat volutpat. Vivamus vehicula scelerisque rutrum. Integer viverra nunc nec purus vehicula accumsan. Aenean a convallis erat. Etiam orci mi, congue vel volutpat in, blandit vel nunc. Nam suscipit nunc sed lorem tempor in tempus turpis ultrices. Aliquam in nisl pretium lacus interdum tincidunt. Aliquam non erat justo, non sagittis sapien. Sed ullamcorper, elit a fringilla laoreet, urna quam commodo ligula, et ornare velit turpis in nisl. Nullam aliquet gravida interdum. Aenean eu nulla a arcu mattis auctor. Nunc aliquet sollicitudin enim iaculis facilisis. Donec faucibus purus felis. Morbi arcu diam, commodo id condimentum quis, posuere dapibus nisi. Donec rutrum, elit at bibendum sodales, erat ante tincidunt massa, ut euismod augue lectus vitae sem. Nam tempus risus sed risus consequat elementum rutrum lacus porta. Nullam id orci felis, ac luctus nunc. Donec rhoncus cursus leo non iaculis. In rutrum mauris sed quam posuere fringilla. Vestibulum hendrerit pellentesque commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Ut porta arcu et lectus molestie at venenatis nunc scelerisque. Ut facilisis egestas pharetra. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Duis in dolor nec nunc semper lacinia et non enim. Aliquam non consequat sapien. Proin molestie egestas diam, in tempus mi eleifend nec. Aliquam ac purus nunc. Pellentesque ornare tempor nunc, eget fringilla nulla volutpat at. Proin molestie purus id lacus mattis ac vehicula urna commodo. Ut congue suscipit nibh, posuere semper purus fringilla a. Pellentesque bibendum auctor sapien in elementum. Donec tincidunt laoreet nisl, viverra consectetur dui pellentesque in. Maecenas sed diam eu augue auctor tristique eu sed dolor. Vivamus dignissim nibh et leo commodo nec pulvinar augue suscipit. Fusce viverra molestie luctus. Sed vel ante odio, viverra auctor arcu. Vestibulum faucibus, elit eu placerat tempus, arcu libero faucibus nisl, nec imperdiet neque eros ac justo. Praesent vel orci vitae tortor fringilla lobortis. Phasellus ultricies, mi id accumsan dapibus, lorem ante malesuada lorem, ut pellentesque dui est nec quam. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nullam vestibulum congue nibh, pulvinar malesuada neque feugiat sit amet. Maecenas iaculis augue sed purus congue sit amet congue sem consectetur. Suspendisse at leo eget quam rhoncus blandit at ut nulla. Praesent a massa eu sem dictum volutpat. Aenean sit amet convallis mauris. Sed nec ipsum nulla, at viverra tortor. Integer urna nisi, ultrices quis bibendum vel, dapibus id mi. Integer facilisis vestibulum neque eget euismod. Curabitur diam lorem, lacinia sit amet eleifend quis, varius quis urna. Sed suscipit accumsan faucibus. Sed et nisl libero. Pellentesque interdum tincidunt eros, in tristique quam euismod a. Proin vel quam nec ligula tincidunt lobortis. Suspendisse blandit massa eros. Duis hendrerit elit in orci feugiat congue. In dignissim est tellus, et vehicula tellus. Phasellus in erat mauris. Pellentesque velit diam, bibendum nec varius lobortis, interdum vitae nisl. Nam sed odio sagittis nulla bibendum ornare ut sit amet diam. Nulla facilisi. Quisque quis tristique augue. Quisque dictum, lectus et vehicula iaculis, augue justo ullamcorper arcu, sed placerat mauris sapien molestie ipsum. Integer facilisis, tortor non fringilla consectetur, urna tortor porttitor risus, a accumsan enim turpis ac mi. Phasellus facilisis eros eu neque adipiscing sit amet interdum lacus venenatis. Aliquam sit amet nulla vitae nibh aliquet hendrerit eget sed sem. Duis leo lorem, dictum et vestibulum sit amet, commodo sit amet elit. Integer ac diam tortor, quis tempor magna. Ut lacinia mauris condimentum diam imperdiet pellentesque ac ac neque. Vivamus consectetur nulla vestibulum leo scelerisque lobortis. Fusce eleifend varius lacus, eget dignissim lorem dictum in. Morbi dictum, ante eu aliquet cursus, ante sapien tempus nisl, et rhoncus magna nunc sit amet lorem. Nulla magna ipsum, dapibus non pellentesque nec, interdum vitae mauris. Nam quis ante est. Nulla turpis velit, aliquet sed lacinia volutpat, ultrices quis massa. Cras convallis, risus quis porttitor eleifend, felis purus pellentesque tellus, eu commodo ipsum tellus eget dui. Phasellus viverra, lorem sit amet euismod semper, nulla mauris feugiat erat, at hendrerit massa lectus eget elit. Donec id lectus sapien, in auctor leo. Suspendisse nisl neque, venenatis in consectetur vel, pellentesque tristique tortor. Etiam viverra tempor augue, at pharetra leo luctus quis. Fusce pretium odio id enim elementum eu commodo lorem ultrices. Praesent id viverra neque. Phasellus molestie iaculis interdum. Praesent faucibus dui vitae nibh eleifend vitae sagittis purus blandit. Proin cursus venenatis nisi porta sagittis. Mauris varius accumsan mauris. Vivamus viverra condimentum accumsan. Vestibulum in nulla id eros pulvinar eleifend eleifend a diam. Phasellus ultrices porta sapien at venenatis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nam quis eros volutpat tellus tincidunt posuere pretium varius sapien. Donec in felis risus, a sollicitudin erat. Sed vel cursus leo. Sed dictum turpis sed augue venenatis tempus. Morbi dapibus, diam eget consequat malesuada, dui metus posuere lorem, in suscipit metus sem consectetur sapien. Sed nisl elit, lobortis ornare pellentesque at, iaculis id magna.");
                msg.Add("lorem ipsum2", "Nunc in odio eu erat laoreet ullamcorper. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Curabitur feugiat erat eu purus varius eu pulvinar quam vestibulum. Pellentesque dignissim consectetur magna. Etiam mollis dictum venenatis. Etiam commodo, neque a interdum commodo, enim nunc dapibus leo, quis semper ipsum magna sed odio. Praesent a pellentesque sem. Phasellus sagittis egestas blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam at ipsum purus. Ut commodo urna ac urna congue consectetur. Proin pellentesque euismod aliquam. Suspendisse turpis odio, consectetur in imperdiet at, auctor non eros. Fusce sagittis condimentum dui nec placerat. Etiam risus odio, faucibus eget feugiat vitae, condimentum ut tortor. Duis nunc tortor, pharetra non luctus vel, tincidunt eget quam. Pellentesque imperdiet lacus ut sapien condimentum ullamcorper eu vitae enim. Sed libero metus, facilisis at dignissim vitae, placerat a tortor. Duis dolor enim, ornare at pharetra at, pharetra nec nibh. Aenean id euismod elit. Cras tristique urna eget elit cursus euismod laoreet lacus blandit. Sed mattis metus ullamcorper libero aliquet sed aliquet tortor adipiscing. Nullam quam nulla, gravida vel fringilla eget, rhoncus ut metus. Quisque id viverra magna. Sed imperdiet, tortor at ultrices volutpat, augue urna molestie arcu, in egestas ante massa a arcu. Aenean consequat turpis a leo volutpat eget pulvinar nibh aliquam. Quisque faucibus ultrices libero, nec mattis diam tincidunt ut. Nam sollicitudin eleifend orci, sollicitudin posuere urna viverra ut. Phasellus sit amet neque mi, gravida vehicula quam. Duis sit amet eros mi, vel vulputate tellus. Maecenas eget auctor libero. Duis nec ornare sapien. Donec quis orci nunc. Duis eget lorem ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nam consequat justo et nisl elementum pharetra. Pellentesque leo massa, hendrerit a tincidunt non, feugiat id felis. Proin dictum mollis purus in hendrerit. Quisque nec metus et elit iaculis faucibus at sed ligula. Fusce condimentum scelerisque massa ac molestie. Nam tristique dictum ligula, id suscipit mauris imperdiet at. Maecenas feugiat velit vel est semper ut aliquet eros scelerisque. Mauris eget massa risus, eget pellentesque eros. Integer lectus velit, dapibus quis vestibulum non, sodales at augue. Maecenas commodo tellus sit amet elit pretium vitae lobortis justo aliquet. Fusce ligula erat, faucibus ac dapibus vel, porttitor a ipsum. Curabitur vel libero ut ipsum elementum aliquam. Praesent massa metus, vestibulum vitae porttitor sed, hendrerit id leo. Maecenas interdum adipiscing ante a tempus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin tempus tempor nisl, in lobortis velit pulvinar a. Aliquam pretium libero non metus euismod sodales eget et mi. Integer luctus eros eget erat dictum commodo. In euismod lobortis lorem, sed placerat ligula suscipit vulputate. In eu consequat dui. Aliquam dictum pellentesque iaculis. Mauris ut mattis est. In non quam mauris, sed facilisis erat. Cras aliquam, felis non tincidunt iaculis, leo ante ultricies velit, ac semper quam mi eget nunc. Cras sodales nunc eget mauris mollis sit amet tincidunt turpis ornare. Vivamus vestibulum sollicitudin tortor ac commodo. Mauris venenatis blandit arcu, non feugiat elit blandit non. Nulla pharetra augue non magna varius rhoncus. Mauris tempor mauris in nisl rhoncus suscipit. Aenean porttitor venenatis elit, nec volutpat est ornare vitae. Quisque iaculis posuere auctor. Curabitur eget auctor ante. Quisque ornare tortor id erat consectetur aliquet. Integer posuere sollicitudin sapien ut luctus. Nulla dolor quam, molestie eget placerat a, interdum ac odio. Etiam laoreet, est vel congue pretium, est elit tincidunt tortor, eu vestibulum tellus sapien et leo. Proin non varius nunc. Integer mollis velit non arcu auctor euismod cursus justo gravida. Integer augue sapien, lobortis vel ornare ac, cursus id risus. Sed dictum egestas nulla vitae vestibulum. Vivamus ac lorem in orci vestibulum convallis in ut massa. Phasellus a nisl ac mi gravida rhoncus at consequat quam. Nullam sit amet lacus ac odio aliquet gravida. Nulla facilisi. Nunc sed nisl ligula. In accumsan metus commodo ligula sodales nec malesuada nulla ornare. Aliquam nisl leo, iaculis a ultricies vitae, imperdiet eu libero. Cras urna quam, tincidunt ac ullamcorper eu, pellentesque at sapien. Ut in tortor tellus, placerat imperdiet nunc. In accumsan magna ut orci pellentesque aliquam. Donec blandit dictum lobortis. Donec consectetur mattis odio sed aliquam. Nunc id ante sed orci lobortis gravida. Integer arcu magna, tempus in tempor non, malesuada vitae eros. Ut gravida arcu suscipit sem volutpat tincidunt tincidunt neque semper. Pellentesque auctor, odio eget consectetur hendrerit, nisi nisl luctus odio, vitae tincidunt dolor lectus vel odio. Nullam consectetur nunc sapien. Donec suscipit porta ante, at pellentesque magna egestas vel. In et justo dolor, et tempor felis. Maecenas quis mi ornare ligula ornare varius eu nec nisl. Suspendisse lobortis neque non nisl pretium venenatis. In eros lacus, iaculis quis mollis vel, eleifend vel nibh. Curabitur pulvinar sollicitudin turpis eu porttitor. In aliquet neque ac nulla tempus tincidunt. Etiam vel tortor odio. Etiam suscipit est a leo tempor consequat. Nunc at luctus turpis. Donec ac hendrerit nibh. Duis molestie nisl aliquet ante convallis placerat. Pellentesque ut massa ante, non tempor sem. Fusce quis dolor non odio rutrum tincidunt. Donec quis augue ac nibh semper sodales vel sed nibh. Vestibulum vestibulum, tellus a adipiscing commodo, mi neque cursus mi, vitae condimentum libero tellus in lacus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Proin vel odio diam. Suspendisse sed mauris id nunc lobortis viverra. Etiam diam mauris, iaculis rutrum aliquet consequat, vestibulum consectetur mauris. In hac habitasse platea dictumst. Sed ut metus nulla. Duis aliquet mollis risus et tempus. Praesent sem ligula, hendrerit sed.");
                msg.Add("location", @"C:\tmp\nofeed\");
                TestResult.Command = msg;
                asyncServer.Write(msg.ToString());

                TestResult.Message += "  Received message(s):";
                while (true)
                {
                    UrlEncodedMessage response = new UrlEncodedMessage(asyncServer.Read(Timeout));
                    TestResult.Message += ("\n\t" + response.ToString());
                    switch (response.Command)
                    {
                        case "found-feed":
                            TestResult.Passed = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch {}

            return TestResult;
        }


    }
}
