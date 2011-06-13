using CoApp.Toolkit.Scan.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scan.Types
{
    
    
    /// <summary>
    ///This is a test class for ScanReportTest and is intended
    ///to contain all ScanReportTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScanReportTest
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
        ///A test for ScanReport Constructor
        ///</summary>
        [TestMethod()]
        public void ScanReportConstructorTest()
        {
            ScanReport target = new ScanReport();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddDefine
        ///</summary>
        [TestMethod()]
        public void AddDefineTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            string identifier = string.Empty; // TODO: Initialize to an appropriate value
            int foundInFileId = 0; // TODO: Initialize to an appropriate value
            target.AddDefine(identifier, foundInFileId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddDefine
        ///</summary>
        [TestMethod()]
        public void AddDefineTest1()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            ScannedDefine define = null; // TODO: Initialize to an appropriate value
            target.AddDefine(define);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddDefineValue
        ///</summary>
        [TestMethod()]
        public void AddDefineValueTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            string identifier = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            int foundInFileId = 0; // TODO: Initialize to an appropriate value
            target.AddDefineValue(identifier, value, foundInFileId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddFile
        ///</summary>
        [TestMethod()]
        public void AddFileTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            ScannedFile file = null; // TODO: Initialize to an appropriate value
            target.AddFile(file);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Deserialize
        ///</summary>
        [TestMethod()]
        public void DeserializeTest()
        {
            string xml = string.Empty; // TODO: Initialize to an appropriate value
            ScanReport expected = null; // TODO: Initialize to an appropriate value
            ScanReport actual;
            actual = ScanReport.Deserialize(xml);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindDefine
        ///</summary>
        [TestMethod()]
        public void FindDefineTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            string define = string.Empty; // TODO: Initialize to an appropriate value
            ScannedDefine expected = null; // TODO: Initialize to an appropriate value
            ScannedDefine actual;
            actual = target.FindDefine(define);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindFile
        ///</summary>
        [TestMethod()]
        public void FindFileTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ScannedFile expected = null; // TODO: Initialize to an appropriate value
            ScannedFile actual;
            actual = target.FindFile(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Serialize
        ///</summary>
        [TestMethod()]
        public void SerializeTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Serialize();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Defines
        ///</summary>
        [TestMethod()]
        public void DefinesTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            Dictionary<string, ScannedDefine> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, ScannedDefine> actual;
            target.Defines = expected;
            actual = target.Defines;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DefinesArray
        ///</summary>
        [TestMethod()]
        public void DefinesArrayTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            ScannedDefine[] expected = null; // TODO: Initialize to an appropriate value
            ScannedDefine[] actual;
            target.DefinesArray = expected;
            actual = target.DefinesArray;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Files
        ///</summary>
        [TestMethod()]
        public void FilesTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            Dictionary<int, ScannedFile> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<int, ScannedFile> actual;
            target.Files = expected;
            actual = target.Files;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FilesArray
        ///</summary>
        [TestMethod()]
        public void FilesArrayTest()
        {
            ScanReport target = new ScanReport(); // TODO: Initialize to an appropriate value
            ScannedFile[] expected = null; // TODO: Initialize to an appropriate value
            ScannedFile[] actual;
            target.FilesArray = expected;
            actual = target.FilesArray;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
