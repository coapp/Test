using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Windows.Forms;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for SystemHotkeyTest and is intended
    ///to contain all SystemHotkeyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SystemHotkeyTest
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
        ///A test for SystemHotkey Constructor
        ///</summary>
        [TestMethod()]
        public void SystemHotkeyConstructorTest()
        {
            SystemHotkey target = new SystemHotkey();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SystemHotkey Constructor
        ///</summary>
        [TestMethod()]
        public void SystemHotkeyConstructorTest1()
        {
            IContainer container = null; // TODO: Initialize to an appropriate value
            SystemHotkey target = new SystemHotkey(container);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for IsRegistered
        ///</summary>
        [TestMethod()]
        public void IsRegisteredTest()
        {
            SystemHotkey target = new SystemHotkey(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsRegistered = expected;
            actual = target.IsRegistered;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Shortcut
        ///</summary>
        [TestMethod()]
        public void ShortcutTest()
        {
            SystemHotkey target = new SystemHotkey(); // TODO: Initialize to an appropriate value
            Keys expected = new Keys(); // TODO: Initialize to an appropriate value
            Keys actual;
            target.Shortcut = expected;
            actual = target.Shortcut;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
