using CoApp.Toolkit.Spec;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;

namespace Test.CoApp.Toolkit.Spec
{
    
    
    /// <summary>
    ///This is a test class for FileGroupTest and is intended
    ///to contain all FileGroupTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FileGroupTest
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
        ///A test for FileGroup Constructor
        ///</summary>
        [TestMethod()]
        public void FileGroupConstructorTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            FileGroup target = new FileGroup(rule);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
