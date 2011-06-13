using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting.Languages.PropertySheet
{
    
    
    /// <summary>
    ///This is a test class for IndexerTest and is intended
    ///to contain all IndexerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IndexerTest
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
        ///A test for Indexer`1 Constructor
        ///</summary>
        public void IndexerConstructorTestHelper<T>()
            where T : class
        {
            Func<IEnumerable<string>> keysFn = null; // TODO: Initialize to an appropriate value
            Func<string, IEnumerable<Rule>> lookupFn = null; // TODO: Initialize to an appropriate value
            Func<string, Rule> newRuleFn = null; // TODO: Initialize to an appropriate value
            Indexer<T> target = new Indexer<T>(keysFn, lookupFn, newRuleFn);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void IndexerConstructorTest()
        {
            IndexerConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        public void GetEnumeratorTestHelper<T>()
            where T : class
        {
            Func<IEnumerable<string>> keysFn = null; // TODO: Initialize to an appropriate value
            Func<string, IEnumerable<Rule>> lookupFn = null; // TODO: Initialize to an appropriate value
            Func<string, Rule> newRuleFn = null; // TODO: Initialize to an appropriate value
            Indexer<T> target = new Indexer<T>(keysFn, lookupFn, newRuleFn); // TODO: Initialize to an appropriate value
            IEnumerator<T> expected = null; // TODO: Initialize to an appropriate value
            IEnumerator<T> actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {
            GetEnumeratorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        public void ItemTestHelper<T>()
            where T : class
        {
            Func<IEnumerable<string>> keysFn = null; // TODO: Initialize to an appropriate value
            Func<string, IEnumerable<Rule>> lookupFn = null; // TODO: Initialize to an appropriate value
            Func<string, Rule> newRuleFn = null; // TODO: Initialize to an appropriate value
            Indexer<T> target = new Indexer<T>(keysFn, lookupFn, newRuleFn); // TODO: Initialize to an appropriate value
            string index = string.Empty; // TODO: Initialize to an appropriate value
            T actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ItemTest()
        {
            ItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        public void KeysTestHelper<T>()
            where T : class
        {
            Func<IEnumerable<string>> keysFn = null; // TODO: Initialize to an appropriate value
            Func<string, IEnumerable<Rule>> lookupFn = null; // TODO: Initialize to an appropriate value
            Func<string, Rule> newRuleFn = null; // TODO: Initialize to an appropriate value
            Indexer<T> target = new Indexer<T>(keysFn, lookupFn, newRuleFn); // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.Keys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void KeysTest()
        {
            KeysTestHelper<GenericParameterHelper>();
        }
    }
}
