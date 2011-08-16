using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for ConsoleExtensionsTest and is intended
    ///to contain all ConsoleExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConsoleExtensionsTest
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
        ///A test for ConsoleOut
        ///</summary>
        [TestMethod()]
        public void ConsoleOutTest()
        {
            IEnumerable<string> strings = null; // TODO: Initialize to an appropriate value
            ConsoleExtensions.ConsoleOut(strings);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PrintProgressBar
        ///</summary>
        [TestMethod()]
        public void PrintProgressBarTest()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            long progress = 0; // TODO: Initialize to an appropriate value
            ConsoleExtensions.PrintProgressBar(message, progress);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToTable
        ///</summary>
        [TestMethod()]
        public void ToTableTest()
        {
            IEnumerable<object> data = null; // TODO: Initialize to an appropriate value
            int maxWidth = 0; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = ConsoleExtensions.ToTable(data, maxWidth);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ErrorRedirected
        ///</summary>
        [TestMethod()]
        public void ErrorRedirectedTest()
        {
            bool actual;
            actual = ConsoleExtensions.ErrorRedirected;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InputRedirected
        ///</summary>
        [TestMethod()]
        public void InputRedirectedTest()
        {
            bool actual;
            actual = ConsoleExtensions.InputRedirected;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsConsole
        ///</summary>
        [TestMethod()]
        public void IsConsoleTest()
        {
            bool actual;
            actual = ConsoleExtensions.IsConsole;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OutputRedirected
        ///</summary>
        [TestMethod()]
        public void OutputRedirectedTest()
        {
            bool actual;
            actual = ConsoleExtensions.OutputRedirected;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
