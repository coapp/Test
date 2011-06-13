using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for ClipboardNotifierTest and is intended
    ///to contain all ClipboardNotifierTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ClipboardNotifierTest
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
        ///A test for ClipboardNotifier Constructor
        ///</summary>
        [TestMethod()]
        public void ClipboardNotifierConstructorTest()
        {
            ClipboardNotifier target = new ClipboardNotifier();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ClipboardNotifier Constructor
        ///</summary>
        [TestMethod()]
        public void ClipboardNotifierConstructorTest1()
        {
            IContainer container = null; // TODO: Initialize to an appropriate value
            ClipboardNotifier target = new ClipboardNotifier(container);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
