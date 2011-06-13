using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting.Languages.PropertySheet
{
    
    
    /// <summary>
    ///This is a test class for RulePropertyTest and is intended
    ///to contain all RulePropertyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RulePropertyTest
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
        ///A test for RuleProperty Constructor
        ///</summary>
        [TestMethod()]
        public void RulePropertyConstructorTest()
        {
            RuleProperty target = new RuleProperty();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for IsCollection
        ///</summary>
        [TestMethod()]
        public void IsCollectionTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsCollection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsCompoundCollection
        ///</summary>
        [TestMethod()]
        public void IsCompoundCollectionTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsCompoundCollection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsCompoundProperty
        ///</summary>
        [TestMethod()]
        public void IsCompoundPropertyTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsCompoundProperty;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsExpression
        ///</summary>
        [TestMethod()]
        public void IsExpressionTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsExpression;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsValue
        ///</summary>
        [TestMethod()]
        public void IsValueTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsValue;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RawValue
        ///</summary>
        [TestMethod()]
        public void RawValueTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.RawValue = expected;
            actual = target.RawValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Values
        ///</summary>
        [TestMethod()]
        public void ValuesTest()
        {
            RuleProperty target = new RuleProperty(); // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            target.Values = expected;
            actual = target.Values;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
