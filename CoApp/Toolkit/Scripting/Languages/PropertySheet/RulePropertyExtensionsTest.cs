using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting.Languages.PropertySheet
{
    
    
    /// <summary>
    ///This is a test class for RulePropertyExtensionsTest and is intended
    ///to contain all RulePropertyExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RulePropertyExtensionsTest
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


/*  TR01: TODO: This helper method needs to be reworked to not die horribly.
        /// <summary>
        ///A test for As
        ///</summary>
        public void AsTestHelper<T>()
            where T : struct
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            T defaultValue = new T(); // TODO: Initialize to an appropriate value
            T expected = new T(); // TODO: Initialize to an appropriate value
            T actual;
            actual = RulePropertyExtensions.As<T>(properties, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
*/
        [TestMethod()]
        public void AsTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call AsTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for AsBoolean
        ///</summary>
        [TestMethod()]
        public void AsBooleanTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            bool defaultValue = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = RulePropertyExtensions.AsBoolean(properties, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AsConstrainedString
        ///</summary>
        [TestMethod()]
        public void AsConstrainedStringTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> possibleValues = null; // TODO: Initialize to an appropriate value
            string defaultValue = string.Empty; // TODO: Initialize to an appropriate value
            bool failOnNonCompoundValues = false; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = RulePropertyExtensions.AsConstrainedString(properties, possibleValues, defaultValue, failOnNonCompoundValues);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AsDictionary
        ///</summary>
        [TestMethod()]
        public void AsDictionaryTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            bool failOnNonCompoundValues = false; // TODO: Initialize to an appropriate value
            IDictionary<string, IEnumerable<string>> expected = null; // TODO: Initialize to an appropriate value
            IDictionary<string, IEnumerable<string>> actual;
            actual = RulePropertyExtensions.AsDictionary(properties, failOnNonCompoundValues);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AsInt
        ///</summary>
        [TestMethod()]
        public void AsIntTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            int defaultValue = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = RulePropertyExtensions.AsInt(properties, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AsString
        ///</summary>
        [TestMethod()]
        public void AsStringTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            string defaultValue = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = RulePropertyExtensions.AsString(properties, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AsStrings
        ///</summary>
        [TestMethod()]
        public void AsStringsTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = RulePropertyExtensions.AsStrings(properties);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            IEnumerable<RuleProperty> properties = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = RulePropertyExtensions.Name(properties);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
