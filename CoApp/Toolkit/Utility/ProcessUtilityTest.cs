using CoApp.Toolkit.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Utility
{
    
    
    /// <summary>
    ///This is a test class for ProcessUtilityTest and is intended
    ///to contain all ProcessUtilityTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcessUtilityTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ProcessUtility Constructor
        ///</summary>
        [TestMethod()]
        public void ProcessUtilityConstructorTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AttachToConsoleForProcess
        ///</summary>
        [TestMethod()]
        public void AttachToConsoleForProcessTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            target.AttachToConsoleForProcess();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Exec
        ///</summary>
        [TestMethod()]
        public void ExecTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Exec(args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Exec
        ///</summary>
        [TestMethod()]
        public void ExecTest1()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Exec(arguments, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecAsync
        ///</summary>
        [TestMethod()]
        public void ExecAsyncTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            target.ExecAsync(arguments, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecAsync
        ///</summary>
        [TestMethod()]
        public void ExecAsyncTest1()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            target.ExecAsync(args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecAsyncNoRedirections
        ///</summary>
        [TestMethod()]
        public void ExecAsyncNoRedirectionsTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            target.ExecAsyncNoRedirections(arguments, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecAsyncNoStdInRedirect
        ///</summary>
        [TestMethod()]
        public void ExecAsyncNoStdInRedirectTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            target.ExecAsyncNoStdInRedirect(arguments, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecNoRedirections
        ///</summary>
        [TestMethod()]
        public void ExecNoRedirectionsTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ExecNoRedirections(arguments, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecWithStdin
        ///</summary>
        [TestMethod()]
        public void ExecWithStdinTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string stdIn = string.Empty; // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            string[] args = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ExecWithStdin(stdIn, arguments, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Kill
        ///</summary>
        [TestMethod()]
        public void KillTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            target.Kill();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SendToStandardIn
        ///</summary>
        [TestMethod()]
        public void SendToStandardInTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            target.SendToStandardIn(text);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WaitForExit
        ///</summary>
        [TestMethod()]
        public void WaitForExitTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            target.WaitForExit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WaitForExit
        ///</summary>
        [TestMethod()]
        public void WaitForExitTest1()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            int milliseconds = 0; // TODO: Initialize to an appropriate value
            target.WaitForExit(milliseconds);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExitCode
        ///</summary>
        [TestMethod()]
        public void ExitCodeTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ExitCode;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Failed
        ///</summary>
        [TestMethod()]
        public void FailedTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Failed = expected;
            actual = target.Failed;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsRunning
        ///</summary>
        [TestMethod()]
        public void IsRunningTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsRunning;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StandardError
        ///</summary>
        [TestMethod()]
        public void StandardErrorTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.StandardError;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StandardOut
        ///</summary>
        [TestMethod()]
        public void StandardOutTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ProcessUtility target = new ProcessUtility(filename); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.StandardOut;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
