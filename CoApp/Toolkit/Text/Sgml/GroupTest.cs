using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for GroupTest and is intended
    ///to contain all GroupTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GroupTest
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
        ///A test for Group Constructor
        ///</summary>
        [TestMethod()]
        public void GroupConstructorTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddConnector
        ///</summary>
        [TestMethod()]
        public void AddConnectorTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
            char c = '\0'; // TODO: Initialize to an appropriate value
            target.AddConnector(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddGroup
        ///</summary>
        [TestMethod()]
        public void AddGroupTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
            Group g = null; // TODO: Initialize to an appropriate value
            target.AddGroup(g);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddOccurrence
        ///</summary>
        [TestMethod()]
        public void AddOccurrenceTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
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
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
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
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            SgmlDtd dtd = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CanContain(name, dtd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Occurrence
        ///</summary>
        [TestMethod()]
        public void OccurrenceTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
            Occurrence actual;
            actual = target.Occurrence;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Parent
        ///</summary>
        [TestMethod()]
        public void ParentTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
            Group actual;
            actual = target.Parent;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TextOnly
        ///</summary>
        [TestMethod()]
        public void TextOnlyTest()
        {
            Group parent = null; // TODO: Initialize to an appropriate value
            Group target = new Group(parent); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TextOnly;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
