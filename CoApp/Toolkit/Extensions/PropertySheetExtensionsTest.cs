using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for PropertySheetExtensionsTest and is intended
    ///to contain all PropertySheetExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PropertySheetExtensionsTest
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
        ///A test for Prop
        ///</summary>
        [TestMethod()]
        public void PropTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            string prop = string.Empty; // TODO: Initialize to an appropriate value
            RuleProperty expected = null; // TODO: Initialize to an appropriate value
            RuleProperty actual;
            actual = PropertySheetExtensions.Prop(rule, prop);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rule
        ///</summary>
        [TestMethod()]
        public void RuleTest()
        {
            PropertySheet sheet = null; // TODO: Initialize to an appropriate value
            string selector = string.Empty; // TODO: Initialize to an appropriate value
            Rule expected = null; // TODO: Initialize to an appropriate value
            Rule actual;
            actual = PropertySheetExtensions.Rule(sheet, selector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
