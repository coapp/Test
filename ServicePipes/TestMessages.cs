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

        private const int Timeout = 5000;
        private const string PipeName = @"CoAppInstaller";
        private static Pipe asyncServer;
        private static Pipe syncServer;
        private static Pipe syncReturn;

        private static string HelpMessage = @"
Usage:  ServicePipes <Sync | Async> <System_Feed_Location> <Session_Feed_Location>

";

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.Out.WriteLine("Insufficient parameters.\n" + HelpMessage);
                return;
            }
            List<Result> Results = new List<Result>();
            asyncServer = new Pipe(new NamedPipeClientStream(PipeName));
            syncServer = new Pipe(new NamedPipeClientStream(PipeName));

            if (args[0].ToLower().Equals("async"))
            {
                Results.Add(AsyncConnect());
                if (Results[Results.Count - 1].Passed)
                {
                    // Add Async tests here
                    AsyncAddSystemFeed(args[1]);
                    AsyncAddSessionFeed(args[2]);
                    AsyncFindFeeds();

                }
            }
            else if (args[0].ToLower().Equals("sync"))
            {
                Results.Add(SyncConnect());
                if (Results[Results.Count - 1].Passed)
                {
                    // Add Sync tests here
                    SyncAddSystemFeed(args[1]);
                    SyncAddSessionFeed(args[2]);
                    SyncFindFeeds();

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
            TestResult.Message = "Failed adding Async feed.";
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


    }
}
