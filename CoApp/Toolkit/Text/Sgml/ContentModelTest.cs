using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for ContentModelTest and is intended
    ///to contain all ContentModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContentModelTest
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
        ///A test for ContentModel Constructor
        ///</summary>
        [TestMethod()]
        public void ContentModelConstructorTest()
        {
            ContentModel target = new ContentModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddConnector
        ///</summary>
        [TestMethod()]
        public void AddConnectorTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            char c = '\0'; // TODO: Initialize to an appropriate value
            target.AddConnector(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddOccurrence
        ///</summary>
        [TestMethod()]
        public void AddOccurrenceTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            char c = '\0'; // TODO: Initialize to an appropriate value
            target.AddOccurrence(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddSymbol
        ///</summary>
        [TestMethod()]
        public void AddSymbolTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            string sym = string.Empty; // TODO: Initialize to an appropriate value
            target.AddSymbol(sym);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CanContain
        ///</summary>
        [TestMethod()]
        public void CanContainTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            SgmlDtd dtd = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CanContain(name, dtd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PopGroup
        ///</summary>
        [TestMethod()]
        public void PopGroupTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.PopGroup();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PushGroup
        ///</summary>
        [TestMethod()]
        public void PushGroupTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            target.PushGroup();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetDeclaredContent
        ///</summary>
        [TestMethod()]
        public void SetDeclaredContentTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            string dc = string.Empty; // TODO: Initialize to an appropriate value
            target.SetDeclaredContent(dc);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CurrentDepth
        ///</summary>
        [TestMethod()]
        public void CurrentDepthTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CurrentDepth;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeclaredContent
        ///</summary>
        [TestMethod()]
        public void DeclaredContentTest()
        {
            ContentModel target = new ContentModel(); // TODO: Initialize to an appropriate value
            DeclaredContent actual;
            actual = target.DeclaredContent;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
