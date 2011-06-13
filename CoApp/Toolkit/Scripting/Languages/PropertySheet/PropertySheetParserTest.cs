using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Scripting.Languages.PropertySheet
{
    
    
    /// <summary>
    ///This is a test class for PropertySheetParserTest and is intended
    ///to contain all PropertySheetParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PropertySheetParserTest
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
        ///A test for Parse
        ///</summary>
        [TestMethod()]
        public void ParseTest()
        {
            string propertySheetText = string.Empty; // TODO: Initialize to an appropriate value
            string originalFilename = string.Empty; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet propertySheet = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet expected = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet actual;
            actual = PropertySheetParser.Parse(propertySheetText, originalFilename, propertySheet);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
