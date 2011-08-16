using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for DebugExtensionsTest and is intended
    ///to contain all DebugExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DebugExtensionsTest
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
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest()
        {
            byte[] buf = null; // TODO: Initialize to an appropriate value
            DebugExtensions.Debug(buf);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest1()
        {
            string buf = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            DebugExtensions.Debug(buf, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for StackDump
        ///</summary>
        [TestMethod()]
        public void StackDumpTest()
        {
            DebugExtensions.StackDump();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
