using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Utility;
using System.Diagnostics;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for PEInfoTest and is intended
    ///to contain all PEInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PEInfoTest
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
        ///A test for RvaToVa
        ///</summary>
        [TestMethod()]
        public void RvaToVaTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            long rva = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = target.RvaToVa(rva);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Scan
        ///</summary>
        [TestMethod()]
        public void ScanTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            PEInfo expected = null; // TODO: Initialize to an appropriate value
            PEInfo actual;
            actual = PEInfo.Scan(filename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecutableInfo
        ///</summary>
        [TestMethod()]
        public void ExecutableInfoTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            ExecutableInfo actual;
            actual = target.ExecutableInfo;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileVersion
        ///</summary>
        [TestMethod()]
        public void FileVersionTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FileVersion;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileVersionLong
        ///</summary>
        [TestMethod()]
        public void FileVersionLongTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            ulong actual;
            actual = target.FileVersionLong;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Is32Bit
        ///</summary>
        [TestMethod()]
        public void Is32BitTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Is32Bit;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Is32BitPE
        ///</summary>
        [TestMethod()]
        public void Is32BitPETest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Is32BitPE;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Is64Bit
        ///</summary>
        [TestMethod()]
        public void Is64BitTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Is64Bit;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Is64BitPE
        ///</summary>
        [TestMethod()]
        public void Is64BitPETest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Is64BitPE;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsAny
        ///</summary>
        [TestMethod()]
        public void IsAnyTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsAny;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsConsole
        ///</summary>
        [TestMethod()]
        public void IsConsoleTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsConsole;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsManaged
        ///</summary>
        [TestMethod()]
        public void IsManagedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsManaged;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsNative
        ///</summary>
        [TestMethod()]
        public void IsNativeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsNative;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MetaDataRoot
        ///</summary>
        [TestMethod()]
        public void MetaDataRootTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.MetaDataRoot;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VersionInfo
        ///</summary>
        [TestMethod()]
        public void VersionInfoTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PEInfo_Accessor target = new PEInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileVersionInfo actual;
            actual = target.VersionInfo;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
