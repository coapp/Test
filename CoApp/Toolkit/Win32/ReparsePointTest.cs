using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for ReparsePointTest and is intended
    ///to contain all ReparsePointTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ReparsePointTest
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
        ///A test for ChangeReparsePointTarget
        ///</summary>
        [TestMethod()]
        public void ChangeReparsePointTargetTest()
        {
            string reparsePointPath = string.Empty; // TODO: Initialize to an appropriate value
            string newReparsePointTarget = string.Empty; // TODO: Initialize to an appropriate value
            ReparsePoint expected = null; // TODO: Initialize to an appropriate value
            ReparsePoint actual;
            actual = ReparsePoint.ChangeReparsePointTarget(reparsePointPath, newReparsePointTarget);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateJunction
        ///</summary>
        [TestMethod()]
        public void CreateJunctionTest()
        {
            string junctionPath = string.Empty; // TODO: Initialize to an appropriate value
            string targetDirectory = string.Empty; // TODO: Initialize to an appropriate value
            ReparsePoint expected = null; // TODO: Initialize to an appropriate value
            ReparsePoint actual;
            actual = ReparsePoint.CreateJunction(junctionPath, targetDirectory);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateSymlink
        ///</summary>
        [TestMethod()]
        public void CreateSymlinkTest()
        {
            string symlinkPath = string.Empty; // TODO: Initialize to an appropriate value
            string linkTarget = string.Empty; // TODO: Initialize to an appropriate value
            ReparsePoint expected = null; // TODO: Initialize to an appropriate value
            ReparsePoint actual;
            actual = ReparsePoint.CreateSymlink(symlinkPath, linkTarget);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            actual = ReparsePoint.GetActualPath(linkPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsReparsePoint
        ///</summary>
        [TestMethod()]
        public void IsReparsePointTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = ReparsePoint.IsReparsePoint(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            ReparsePoint expected = null; // TODO: Initialize to an appropriate value
            ReparsePoint actual;
            actual = ReparsePoint.Open(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsMountPoint
        ///</summary>
        [TestMethod()]
        public void IsMountPointTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ReparsePoint_Accessor target = new ReparsePoint_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsMountPoint;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsRelativeSymlink
        ///</summary>
        [TestMethod()]
        public void IsRelativeSymlinkTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ReparsePoint_Accessor target = new ReparsePoint_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsRelativeSymlink;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSymlinkOrJunction
        ///</summary>
        [TestMethod()]
        public void IsSymlinkOrJunctionTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ReparsePoint_Accessor target = new ReparsePoint_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsSymlinkOrJunction;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PrintName
        ///</summary>
        [TestMethod()]
        public void PrintNameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ReparsePoint_Accessor target = new ReparsePoint_Accessor(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.PrintName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubstituteName
        ///</summary>
        [TestMethod()]
        public void SubstituteNameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ReparsePoint_Accessor target = new ReparsePoint_Accessor(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SubstituteName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
