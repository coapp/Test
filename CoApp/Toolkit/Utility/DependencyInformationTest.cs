using CoApp.Toolkit.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Utility
{
    
    
    /// <summary>
    ///This is a test class for DependencyInformationTest and is intended
    ///to contain all DependencyInformationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DependencyInformationTest
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
        ///A test for DependencyInformation Constructor
        ///</summary>
        [TestMethod()]
        public void DependencyInformationConstructorTest()
        {
            DependencyInformation target = new DependencyInformation();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ActualBase
        ///</summary>
        [TestMethod()]
        public void ActualBaseTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ActualBase = expected;
            actual = target.ActualBase;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Attr
        ///</summary>
        [TestMethod()]
        public void AttrTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Attr = expected;
            actual = target.Attr;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CPU
        ///</summary>
        [TestMethod()]
        public void CPUTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.CPU = expected;
            actual = target.CPU;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileSize
        ///</summary>
        [TestMethod()]
        public void FileSizeTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FileSize = expected;
            actual = target.FileSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileTimeStamp
        ///</summary>
        [TestMethod()]
        public void FileTimeStampTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FileTimeStamp = expected;
            actual = target.FileTimeStamp;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileVer
        ///</summary>
        [TestMethod()]
        public void FileVerTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FileVer = expected;
            actual = target.FileVer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Filename
        ///</summary>
        [TestMethod()]
        public void FilenameTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Filename = expected;
            actual = target.Filename;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImageVer
        ///</summary>
        [TestMethod()]
        public void ImageVerTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ImageVer = expected;
            actual = target.ImageVer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LinkChecksum
        ///</summary>
        [TestMethod()]
        public void LinkChecksumTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LinkChecksum = expected;
            actual = target.LinkChecksum;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LinkTimeStamp
        ///</summary>
        [TestMethod()]
        public void LinkTimeStampTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LinkTimeStamp = expected;
            actual = target.LinkTimeStamp;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LinkerVer
        ///</summary>
        [TestMethod()]
        public void LinkerVerTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LinkerVer = expected;
            actual = target.LinkerVer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LoadOrder
        ///</summary>
        [TestMethod()]
        public void LoadOrderTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LoadOrder = expected;
            actual = target.LoadOrder;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Module
        ///</summary>
        [TestMethod()]
        public void ModuleTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Module = expected;
            actual = target.Module;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OSVer
        ///</summary>
        [TestMethod()]
        public void OSVerTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.OSVer = expected;
            actual = target.OSVer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PreferredBase
        ///</summary>
        [TestMethod()]
        public void PreferredBaseTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.PreferredBase = expected;
            actual = target.PreferredBase;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProductVer
        ///</summary>
        [TestMethod()]
        public void ProductVerTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ProductVer = expected;
            actual = target.ProductVer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RealChecksum
        ///</summary>
        [TestMethod()]
        public void RealChecksumTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.RealChecksum = expected;
            actual = target.RealChecksum;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Status
        ///</summary>
        [TestMethod()]
        public void StatusTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Status = expected;
            actual = target.Status;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Subsystem
        ///</summary>
        [TestMethod()]
        public void SubsystemTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Subsystem = expected;
            actual = target.Subsystem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubsystemVer
        ///</summary>
        [TestMethod()]
        public void SubsystemVerTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SubsystemVer = expected;
            actual = target.SubsystemVer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Symbols
        ///</summary>
        [TestMethod()]
        public void SymbolsTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Symbols = expected;
            actual = target.Symbols;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VirtualSize
        ///</summary>
        [TestMethod()]
        public void VirtualSizeTest()
        {
            DependencyInformation target = new DependencyInformation(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.VirtualSize = expected;
            actual = target.VirtualSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
