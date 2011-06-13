using CoApp.Toolkit.Scripting.Languages.CSV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSV
{
    
    
    /// <summary>
    ///This is a test class for CachedCsvReaderTest and is intended
    ///to contain all CachedCsvReaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CachedCsvReaderTest
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
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            int field = 0; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[field];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EndOfStream
        ///</summary>
        [TestMethod()]
        public void EndOfStreamTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.EndOfStream;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentRecordIndex
        ///</summary>
        [TestMethod()]
        public void CurrentRecordIndexTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.CurrentRecordIndex;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadToEnd
        ///</summary>
        [TestMethod()]
        public void ReadToEndTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            target.ReadToEnd();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveToStart
        ///</summary>
        [TestMethod()]
        public void MoveToStartTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            target.MoveToStart();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveToLastCachedRecord
        ///</summary>
        [TestMethod()]
        public void MoveToLastCachedRecordTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            target.MoveToLastCachedRecord();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveTo
        ///</summary>
        [TestMethod()]
        public void MoveToTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            long record = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveTo(record);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CachedCsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CachedCsvReaderConstructorTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders, delimiter);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CachedCsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CachedCsvReaderConstructorTest1()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders, bufferSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CachedCsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CachedCsvReaderConstructorTest2()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CachedCsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CachedCsvReaderConstructorTest3()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            char quote = '\0'; // TODO: Initialize to an appropriate value
            char escape = '\0'; // TODO: Initialize to an appropriate value
            char comment = '\0'; // TODO: Initialize to an appropriate value
            ValueTrimmingOptions trimmingOptions = new ValueTrimmingOptions(); // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders, delimiter, quote, escape, comment, trimmingOptions, bufferSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CachedCsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CachedCsvReaderConstructorTest4()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            char quote = '\0'; // TODO: Initialize to an appropriate value
            char escape = '\0'; // TODO: Initialize to an appropriate value
            char comment = '\0'; // TODO: Initialize to an appropriate value
            ValueTrimmingOptions trimmingOptions = new ValueTrimmingOptions(); // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders, delimiter, quote, escape, comment, trimmingOptions);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CachedCsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CachedCsvReaderConstructorTest5()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            CachedCsvReader target = new CachedCsvReader(reader, hasHeaders, delimiter, bufferSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
