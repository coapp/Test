using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting.Languages.PropertySheet
{
    
    
    /// <summary>
    ///This is a test class for PropertySheetTest and is intended
    ///to contain all PropertySheetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PropertySheetTest
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
        ///A test for PropertySheet Constructor
        ///</summary>
        [TestMethod()]
        public void PropertySheetConstructorTest()
        {
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet target = new global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet expected = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet actual;
            actual = global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet.Load(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Parse
        ///</summary>
        [TestMethod()]
        public void ParseTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            string originalFilename = string.Empty; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet expected = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet actual;
            actual = global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet.Parse(text, originalFilename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet target = new global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.Save(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet target = new global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet target = new global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet(); // TODO: Initialize to an appropriate value
            string selector = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<Rule> actual;
            actual = target[selector];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        [TestMethod()]
        public void KeysTest()
        {
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet target = new global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet(); // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.Keys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rules
        ///</summary>
        [TestMethod()]
        public void RulesTest()
        {
            global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet target = new global::CoApp.Toolkit.Scripting.Languages.PropertySheet.PropertySheet(); // TODO: Initialize to an appropriate value
            IEnumerable<Rule> actual;
            actual = target.Rules;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
