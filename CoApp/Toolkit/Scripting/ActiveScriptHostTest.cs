using CoApp.Toolkit.Scripting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting
{
    
    
    /// <summary>
    ///This is a test class for ActiveScriptHostTest and is intended
    ///to contain all ActiveScriptHostTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ActiveScriptHostTest
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
        ///A test for ActiveScriptHost Constructor
        ///</summary>
        [TestMethod()]
        public void ActiveScriptHostConstructorTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Close
        ///</summary>
        [TestMethod()]
        public void CloseTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            target.Close();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FullName
        ///</summary>
        [TestMethod()]
        public void FullNameTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FullName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDocVersionString
        ///</summary>
        [TestMethod()]
        public void GetDocVersionStringTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string v = string.Empty; // TODO: Initialize to an appropriate value
            string vExpected = string.Empty; // TODO: Initialize to an appropriate value
            target.GetDocVersionString(out v);
            Assert.AreEqual(vExpected, v);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetItemInfo
        ///</summary>
        [TestMethod()]
        public void GetItemInfoTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string pstrName = string.Empty; // TODO: Initialize to an appropriate value
            uint dwReturnMask = 0; // TODO: Initialize to an appropriate value
            object item = null; // TODO: Initialize to an appropriate value
            object itemExpected = null; // TODO: Initialize to an appropriate value
            IntPtr ppti = new IntPtr(); // TODO: Initialize to an appropriate value
            target.GetItemInfo(pstrName, dwReturnMask, out item, ppti);
            Assert.AreEqual(itemExpected, item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetLCID
        ///</summary>
        [TestMethod()]
        public void GetLCIDTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            uint id = 0; // TODO: Initialize to an appropriate value
            uint idExpected = 0; // TODO: Initialize to an appropriate value
            target.GetLCID(out id);
            Assert.AreEqual(idExpected, id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Invoke
        ///</summary>
        [TestMethod()]
        public void InvokeTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string functionName = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Invoke(functionName, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnEnterScript
        ///</summary>
        [TestMethod()]
        public void OnEnterScriptTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            target.OnEnterScript();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnLeaveScript
        ///</summary>
        [TestMethod()]
        public void OnLeaveScriptTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            target.OnLeaveScript();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnScriptError
        ///</summary>
        [TestMethod()]
        public void OnScriptErrorTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            IActiveScriptError err = null; // TODO: Initialize to an appropriate value
            target.OnScriptError(err);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnScriptTerminate
        ///</summary>
        [TestMethod()]
        public void OnScriptTerminateTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            object result = null; // TODO: Initialize to an appropriate value
            object resultExpected = null; // TODO: Initialize to an appropriate value
            EXCEPINFO info = new EXCEPINFO(); // TODO: Initialize to an appropriate value
            EXCEPINFO infoExpected = new EXCEPINFO(); // TODO: Initialize to an appropriate value
            target.OnScriptTerminate(ref result, ref info);
            Assert.AreEqual(resultExpected, result);
            Assert.AreEqual(infoExpected, info);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnStateChange
        ///</summary>
        [TestMethod()]
        public void OnStateChangeTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            uint state = 0; // TODO: Initialize to an appropriate value
            target.OnStateChange(state);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Quit
        ///</summary>
        [TestMethod()]
        public void QuitTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            target.Quit(i);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Run
        ///</summary>
        [TestMethod()]
        public void RunTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            target.Run();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ScriptFullName
        ///</summary>
        [TestMethod()]
        public void ScriptFullNameTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScriptFullName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScriptName
        ///</summary>
        [TestMethod()]
        public void ScriptNameTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScriptName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for echo
        ///</summary>
        [TestMethod()]
        public void echoTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            target.echo(text);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GlobalMembers
        ///</summary>
        [TestMethod()]
        public void GlobalMembersTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            Dictionary<string, object> actual;
            actual = target.GlobalMembers;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReturnValue
        ///</summary>
        [TestMethod()]
        public void ReturnValueTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ReturnValue;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScriptText
        ///</summary>
        [TestMethod()]
        public void ScriptTextTest()
        {
            ScriptLanguage language = new ScriptLanguage(); // TODO: Initialize to an appropriate value
            ActiveScriptHost target = new ActiveScriptHost(language); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ScriptText = expected;
            actual = target.ScriptText;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
