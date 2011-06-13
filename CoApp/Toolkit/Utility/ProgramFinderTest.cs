using CoApp.Toolkit.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Utility
{
    
    
    /// <summary>
    ///This is a test class for ProgramFinderTest and is intended
    ///to contain all ProgramFinderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramFinderTest
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
        ///A test for ProgramFinder Constructor
        ///</summary>
        [TestMethod()]
        public void ProgramFinderConstructorTest()
        {
            string searchPath = string.Empty; // TODO: Initialize to an appropriate value
            string recursivePath = string.Empty; // TODO: Initialize to an appropriate value
            ProgramFinder target = new ProgramFinder(searchPath, recursivePath);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ProgramFinder Constructor
        ///</summary>
        [TestMethod()]
        public void ProgramFinderConstructorTest1()
        {
            string searchPath = string.Empty; // TODO: Initialize to an appropriate value
            ProgramFinder target = new ProgramFinder(searchPath);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ScanForFile
        ///</summary>
        [TestMethod()]
        public void ScanForFileTest()
        {
            string searchPath = string.Empty; // TODO: Initialize to an appropriate value
            ProgramFinder target = new ProgramFinder(searchPath); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            string minimumVersion = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<string> filters = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanForFile(filename, minimumVersion, filters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScanForFile
        ///</summary>
        [TestMethod()]
        public void ScanForFileTest1()
        {
            string searchPath = string.Empty; // TODO: Initialize to an appropriate value
            ProgramFinder target = new ProgramFinder(searchPath); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ExecutableInfo executableType = new ExecutableInfo(); // TODO: Initialize to an appropriate value
            string minimumVersion = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<string> filters = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanForFile(filename, executableType, minimumVersion, filters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScanForFile
        ///</summary>
        [TestMethod()]
        public void ScanForFileTest2()
        {
            string searchPath = string.Empty; // TODO: Initialize to an appropriate value
            ProgramFinder target = new ProgramFinder(searchPath); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            ExecutableInfo executableType = new ExecutableInfo(); // TODO: Initialize to an appropriate value
            IEnumerable<string> filters = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanForFile(filename, executableType, filters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
