using CoApp.Toolkit.Scripting.Languages.CSV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSV
{
    
    
    /// <summary>
    ///This is a test class for CsvReaderTest and is intended
    ///to contain all CsvReaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CsvReaderTest
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
        ///A test for MoveTo
        ///</summary>
        [TestMethod()]
        public void MoveToTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            long record = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveTo(record);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFieldIndex
        ///</summary>
        [TestMethod()]
        public void GetFieldIndexTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            string header = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetFieldIndex(header);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFieldHeaders
        ///</summary>
        [TestMethod()]
        public void GetFieldHeadersTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.GetFieldHeaders();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        [TestMethod()]
        public void GetEnumeratorTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            CsvReader.RecordEnumerator expected = new CsvReader.RecordEnumerator(); // TODO: Initialize to an appropriate value
            CsvReader.RecordEnumerator actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCurrentRawData
        ///</summary>
        [TestMethod()]
        public void GetCurrentRawDataTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetCurrentRawData();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CopyCurrentRecordTo
        ///</summary>
        [TestMethod()]
        public void CopyCurrentRecordToTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            string[] array = null; // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            target.CopyCurrentRecordTo(array, index);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CopyCurrentRecordTo
        ///</summary>
        [TestMethod()]
        public void CopyCurrentRecordToTest1()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            string[] array = null; // TODO: Initialize to an appropriate value
            target.CopyCurrentRecordTo(array);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReaderConstructorTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders, delimiter);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReaderConstructorTest1()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders, bufferSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReaderConstructorTest2()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReaderConstructorTest3()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            char quote = '\0'; // TODO: Initialize to an appropriate value
            char escape = '\0'; // TODO: Initialize to an appropriate value
            char comment = '\0'; // TODO: Initialize to an appropriate value
            ValueTrimmingOptions trimmingOptions = new ValueTrimmingOptions(); // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders, delimiter, quote, escape, comment, trimmingOptions, bufferSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReaderConstructorTest4()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            char quote = '\0'; // TODO: Initialize to an appropriate value
            char escape = '\0'; // TODO: Initialize to an appropriate value
            char comment = '\0'; // TODO: Initialize to an appropriate value
            ValueTrimmingOptions trimmingOptions = new ValueTrimmingOptions(); // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders, delimiter, quote, escape, comment, trimmingOptions);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CsvReader Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReaderConstructorTest5()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            char delimiter = '\0'; // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders, delimiter, bufferSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ReadNextRecord
        ///</summary>
        [TestMethod()]
        public void ReadNextRecordTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ReadNextRecord();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BufferSize
        ///</summary>
        [TestMethod()]
        public void BufferSizeTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.BufferSize;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Comment
        ///</summary>
        [TestMethod()]
        public void CommentTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            char actual;
            actual = target.Comment;
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
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.CurrentRecordIndex;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DefaultParseErrorAction
        ///</summary>
        [TestMethod()]
        public void DefaultParseErrorActionTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            ParseErrorAction expected = new ParseErrorAction(); // TODO: Initialize to an appropriate value
            ParseErrorAction actual;
            target.DefaultParseErrorAction = expected;
            actual = target.DefaultParseErrorAction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delimiter
        ///</summary>
        [TestMethod()]
        public void DelimiterTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            char actual;
            actual = target.Delimiter;
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
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.EndOfStream;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Escape
        ///</summary>
        [TestMethod()]
        public void EscapeTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            char actual;
            actual = target.Escape;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FieldCount
        ///</summary>
        [TestMethod()]
        public void FieldCountTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FieldCount;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasHeaders
        ///</summary>
        [TestMethod()]
        public void HasHeadersTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasHeaders;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsDisposed
        ///</summary>
        [TestMethod()]
        public void IsDisposedTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsDisposed;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            int record = 0; // TODO: Initialize to an appropriate value
            string field = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[record, field];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest1()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            int record = 0; // TODO: Initialize to an appropriate value
            int field = 0; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[record, field];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest2()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            int field = 0; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[field];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest3()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            string field = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[field];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MissingFieldAction
        ///</summary>
        [TestMethod()]
        public void MissingFieldActionTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            MissingFieldAction expected = new MissingFieldAction(); // TODO: Initialize to an appropriate value
            MissingFieldAction actual;
            target.MissingFieldAction = expected;
            actual = target.MissingFieldAction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MissingFieldFlag
        ///</summary>
        [TestMethod()]
        public void MissingFieldFlagTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MissingFieldFlag;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParseErrorFlag
        ///</summary>
        [TestMethod()]
        public void ParseErrorFlagTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ParseErrorFlag;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Quote
        ///</summary>
        [TestMethod()]
        public void QuoteTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            char actual;
            actual = target.Quote;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SkipEmptyLines
        ///</summary>
        [TestMethod()]
        public void SkipEmptyLinesTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.SkipEmptyLines = expected;
            actual = target.SkipEmptyLines;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SupportsMultiline
        ///</summary>
        [TestMethod()]
        public void SupportsMultilineTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.SupportsMultiline = expected;
            actual = target.SupportsMultiline;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrimmingOption
        ///</summary>
        [TestMethod()]
        public void TrimmingOptionTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            bool hasHeaders = false; // TODO: Initialize to an appropriate value
            CsvReader target = new CsvReader(reader, hasHeaders); // TODO: Initialize to an appropriate value
            ValueTrimmingOptions actual;
            actual = target.TrimmingOption;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
