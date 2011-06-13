using CoApp.Toolkit.Scan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scan.Types;

namespace Test.CoApp.Toolkit.Scan
{
    
    
    /// <summary>
    ///This is a test class for ProjectScannerTest and is intended
    ///to contain all ProjectScannerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProjectScannerTest
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
        ///A test for ProjectScanner Constructor
        ///</summary>
        [TestMethod()]
        public void ProjectScannerConstructorTest()
        {
            ProjectScanner target = new ProjectScanner();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Scan
        ///</summary>
        [TestMethod()]
        public void ScanTest()
        {
            ProjectScanner target = new ProjectScanner(); // TODO: Initialize to an appropriate value
            string rootDirectory = string.Empty; // TODO: Initialize to an appropriate value
            ScanReport expected = null; // TODO: Initialize to an appropriate value
            ScanReport actual;
            actual = target.Scan(rootDirectory);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Verbose
        ///</summary>
        [TestMethod()]
        public void VerboseTest()
        {
            ProjectScanner target = new ProjectScanner(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Verbose = expected;
            actual = target.Verbose;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
