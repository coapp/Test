using CoApp.Toolkit.Trace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Trace
{
    
    
    /// <summary>
    ///This is a test class for FileIndexerTest and is intended
    ///to contain all FileIndexerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FileIndexerTest
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
        ///A test for FileIndexer Constructor
        ///</summary>
        [TestMethod()]
        public void FileIndexerConstructorTest()
        {
            List<File> collection = null; // TODO: Initialize to an appropriate value
            FileIndexer target = new FileIndexer(collection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            List<File> collection = null; // TODO: Initialize to an appropriate value
            FileIndexer target = new FileIndexer(collection); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            File actual;
            actual = target[path];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
