using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for CollectionExtensionsTest and is intended
    ///to contain all CollectionExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CollectionExtensionsTest
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
        ///A test for AddRange
        ///</summary>
        public void AddRangeTestHelper<T>()
        {
            Collection<T> destination = null; // TODO: Initialize to an appropriate value
            IEnumerable<T> collection = null; // TODO: Initialize to an appropriate value
            CollectionExtensions.AddRange<T>(destination, collection);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddRangeTest()
        {
            AddRangeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Combine
        ///</summary>
        [TestMethod()]
        public void CombineTest()
        {
            List<string> list = null; // TODO: Initialize to an appropriate value
            string separator = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CollectionExtensions.Combine(list, separator);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Combine
        ///</summary>
        [TestMethod()]
        public void CombineTest1()
        {
            List<string> list = null; // TODO: Initialize to an appropriate value
            char separator = '\0'; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CollectionExtensions.Combine(list, separator);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetOrDefault
        ///</summary>
        public void GetOrDefaultTestHelper<TKey, TValue>()
        {
            Dictionary<TKey, TValue> dictionary = null; // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            TValue expected = default(TValue); // TODO: Initialize to an appropriate value
            TValue actual;
            actual = CollectionExtensions.GetOrDefault<TKey, TValue>(dictionary, key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetOrDefaultTest()
        {
            GetOrDefaultTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsNullOrEmpty
        ///</summary>
        public void IsNullOrEmptyTestHelper<T>()
        {
            IEnumerable<T> collection = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CollectionExtensions.IsNullOrEmpty<T>(collection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            IsNullOrEmptyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Merge
        ///</summary>
        [TestMethod()]
        public void MergeTest()
        {
            Dictionary<string, IEnumerable<string>> result = null; // TODO: Initialize to an appropriate value
            IDictionary<string, IEnumerable<string>> more = null; // TODO: Initialize to an appropriate value
            Dictionary<string, IEnumerable<string>> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, IEnumerable<string>> actual;
            actual = CollectionExtensions.Merge(result, more);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SplitToList
        ///</summary>
        [TestMethod()]
        public void SplitToListTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char[] separator = null; // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = CollectionExtensions.SplitToList(str, separator);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Uniq
        ///</summary>
        [TestMethod()]
        public void UniqTest()
        {
            List<string> list = null; // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = CollectionExtensions.Uniq(list);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Uniq
        ///</summary>
        [TestMethod()]
        public void UniqTest1()
        {
            IEnumerable<string> collection = null; // TODO: Initialize to an appropriate value
            StringComparison stringComparison = new StringComparison(); // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = CollectionExtensions.Uniq(collection, stringComparison);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Uniq
        ///</summary>
        [TestMethod()]
        public void UniqTest2()
        {
            List<string> list = null; // TODO: Initialize to an appropriate value
            StringComparison stringComparison = new StringComparison(); // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = CollectionExtensions.Uniq(list, stringComparison);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Uniq
        ///</summary>
        [TestMethod()]
        public void UniqTest3()
        {
            IEnumerable<string> collection = null; // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = CollectionExtensions.Uniq(collection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
