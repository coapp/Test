using CoApp.Toolkit.Scripting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices.ComTypes;

namespace Test.CoApp.Toolkit.Scripting
{
    
    
    /// <summary>
    ///This is a test class for IActiveScriptErrorTest and is intended
    ///to contain all IActiveScriptErrorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IActiveScriptErrorTest
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


        internal virtual IActiveScriptError CreateIActiveScriptError()
        {
            // TODO: Instantiate an appropriate concrete class.
            IActiveScriptError target = null;
            return target;
        }

        /// <summary>
        ///A test for GetExceptionInfo
        ///</summary>
        [TestMethod()]
        public void GetExceptionInfoTest()
        {
            IActiveScriptError target = CreateIActiveScriptError(); // TODO: Initialize to an appropriate value
            EXCEPINFO excepinfo = new EXCEPINFO(); // TODO: Initialize to an appropriate value
            EXCEPINFO excepinfoExpected = new EXCEPINFO(); // TODO: Initialize to an appropriate value
            target.GetExceptionInfo(out excepinfo);
            Assert.AreEqual(excepinfoExpected, excepinfo);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetSourceLineText
        ///</summary>
        [TestMethod()]
        public void GetSourceLineTextTest()
        {
            IActiveScriptError target = CreateIActiveScriptError(); // TODO: Initialize to an appropriate value
            string sourceLine = string.Empty; // TODO: Initialize to an appropriate value
            string sourceLineExpected = string.Empty; // TODO: Initialize to an appropriate value
            target.GetSourceLineText(out sourceLine);
            Assert.AreEqual(sourceLineExpected, sourceLine);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetSourcePosition
        ///</summary>
        [TestMethod()]
        public void GetSourcePositionTest()
        {
            IActiveScriptError target = CreateIActiveScriptError(); // TODO: Initialize to an appropriate value
            int sourceContext = 0; // TODO: Initialize to an appropriate value
            int sourceContextExpected = 0; // TODO: Initialize to an appropriate value
            int pulLineNumber = 0; // TODO: Initialize to an appropriate value
            int pulLineNumberExpected = 0; // TODO: Initialize to an appropriate value
            int plCharacterPosition = 0; // TODO: Initialize to an appropriate value
            int plCharacterPositionExpected = 0; // TODO: Initialize to an appropriate value
            target.GetSourcePosition(out sourceContext, out pulLineNumber, out plCharacterPosition);
            Assert.AreEqual(sourceContextExpected, sourceContext);
            Assert.AreEqual(pulLineNumberExpected, pulLineNumber);
            Assert.AreEqual(plCharacterPositionExpected, plCharacterPosition);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
