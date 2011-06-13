using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for SymlinkTest and is intended
    ///to contain all SymlinkTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SymlinkTest
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
        ///A test for Symlink Constructor
        ///</summary>
        [TestMethod()]
        public void SymlinkConstructorTest()
        {
            Symlink target = new Symlink();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ChangeLinkTarget
        ///</summary>
        [TestMethod()]
        public void ChangeLinkTargetTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            string newActualPath = string.Empty; // TODO: Initialize to an appropriate value
            Symlink.ChangeLinkTarget(linkPath, newActualPath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteSymlink
        ///</summary>
        [TestMethod()]
        public void DeleteSymlinkTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            Symlink.DeleteSymlink(linkPath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetActualPath
        ///</summary>
        [TestMethod()]
        public void GetActualPathTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Symlink.GetActualPath(linkPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSymlink
        ///</summary>
        [TestMethod()]
        public void IsSymlinkTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Symlink.IsSymlink(linkPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeDirectoryLink
        ///</summary>
        [TestMethod()]
        public void MakeDirectoryLinkTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            string actualFolderPath = string.Empty; // TODO: Initialize to an appropriate value
            Symlink.MakeDirectoryLink(linkPath, actualFolderPath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MakeFileLink
        ///</summary>
        [TestMethod()]
        public void MakeFileLinkTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            string actualFilePath = string.Empty; // TODO: Initialize to an appropriate value
            Symlink.MakeFileLink(linkPath, actualFilePath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
