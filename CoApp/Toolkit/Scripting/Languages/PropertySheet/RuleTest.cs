using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting.Languages.PropertySheet
{
    
    
    /// <summary>
    ///This is a test class for RuleTest and is intended
    ///to contain all RuleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RuleTest
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
        ///A test for Rule Constructor
        ///</summary>
        [TestMethod()]
        public void RuleConstructorTest()
        {
            Rule target = new Rule();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ClearProperties
        ///</summary>
        [TestMethod()]
        public void ClearPropertiesTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            target.ClearProperties(name);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CompoundPropertyAsList
        ///</summary>
        [TestMethod()]
        public void CompoundPropertyAsListTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string LValue = string.Empty; // TODO: Initialize to an appropriate value
            IList<string> expected = null; // TODO: Initialize to an appropriate value
            IList<string> actual;
            actual = target.CompoundPropertyAsList(name, LValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CompoundPropertyKeys
        ///</summary>
        [TestMethod()]
        public void CompoundPropertyKeysTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.CompoundPropertyKeys(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasCompoundProperty
        ///</summary>
        [TestMethod()]
        public void HasCompoundPropertyTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string LValue = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasCompoundProperty(name, LValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasProperty
        ///</summary>
        [TestMethod()]
        public void HasPropertyTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasProperty(propertyName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PropertyAsList
        ///</summary>
        [TestMethod()]
        public void PropertyAsListTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            IList<string> expected = null; // TODO: Initialize to an appropriate value
            IList<string> actual;
            actual = target.PropertyAsList(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemoveCompoundPropertyValues
        ///</summary>
        [TestMethod()]
        public void RemoveCompoundPropertyValuesTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string LValue = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.RemoveCompoundPropertyValues(name, LValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetSingleValue
        ///</summary>
        [TestMethod()]
        public void SetSingleValueTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            target.SetSingleValue(name, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FullSelector
        ///</summary>
        [TestMethod()]
        public void FullSelectorTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FullSelector;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            Rule target = new Rule(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<RuleProperty> actual;
            actual = target[name];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
