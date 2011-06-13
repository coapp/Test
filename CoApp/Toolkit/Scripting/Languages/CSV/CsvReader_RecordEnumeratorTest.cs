using CoApp.Toolkit.Scripting.Languages.CSV;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSV
{
    
    
    /// <summary>
    ///This is a test class for CsvReader_RecordEnumeratorTest and is intended
    ///to contain all CsvReader_RecordEnumeratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CsvReader_RecordEnumeratorTest
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
        ///A test for RecordEnumerator Constructor
        ///</summary>
        [TestMethod()]
        public void CsvReader_RecordEnumeratorConstructorTest()
        {
            CsvReader reader = null; // TODO: Initialize to an appropriate value
            CsvReader.RecordEnumerator target = new CsvReader.RecordEnumerator(reader);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            CsvReader.RecordEnumerator target = new CsvReader.RecordEnumerator(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveNext
        ///</summary>
        [TestMethod()]
        public void MoveNextTest()
        {
            CsvReader.RecordEnumerator target = new CsvReader.RecordEnumerator(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveNext();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        public void ResetTest()
        {
            CsvReader.RecordEnumerator target = new CsvReader.RecordEnumerator(); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Current
        ///</summary>
        [TestMethod()]
        public void CurrentTest()
        {
            CsvReader.RecordEnumerator target = new CsvReader.RecordEnumerator(); // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.Current;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
