using CoApp.Toolkit.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Test.CoApp.Toolkit.Collections
{
    
    
    /// <summary>
    ///This is a test class for ExpiringDictionaryTest and is intended
    ///to contain all ExpiringDictionaryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExpiringDictionaryTest
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
        ///A test for ExpiringDictionary`2 Constructor
        ///</summary>
        public void ExpiringDictionaryConstructorTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ExpiringDictionaryConstructorTest()
        {
            ExpiringDictionaryConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        public void AddTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            KeyValuePair<key, val> item = new KeyValuePair<key, val>(); // TODO: Initialize to an appropriate value
            target.Add(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddTest()
        {
            AddTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        public void AddTest1Helper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            key key1 = default(key); // TODO: Initialize to an appropriate value
            val value = default(val); // TODO: Initialize to an appropriate value
            target.Add(key1, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddTest1()
        {
            AddTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ClearTest()
        {
            ClearTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Contains
        ///</summary>
        public void ContainsTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            KeyValuePair<key, val> item = new KeyValuePair<key, val>(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Contains(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContainsTest()
        {
            ContainsTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContainsKey
        ///</summary>
        public void ContainsKeyTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            key key1 = default(key); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ContainsKey(key1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContainsKeyTest()
        {
            ContainsKeyTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CopyTo
        ///</summary>
        public void CopyToTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            KeyValuePair<key, val>[] array = null; // TODO: Initialize to an appropriate value
            int arrayIndex = 0; // TODO: Initialize to an appropriate value
            target.CopyTo(array, arrayIndex);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void CopyToTest()
        {
            CopyToTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        public void GetEnumeratorTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            IEnumerator<KeyValuePair<key, val>> expected = null; // TODO: Initialize to an appropriate value
            IEnumerator<KeyValuePair<key, val>> actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {
            GetEnumeratorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        public void RemoveTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            KeyValuePair<key, val> item = new KeyValuePair<key, val>(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Remove(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void RemoveTest()
        {
            RemoveTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        public void RemoveTest1Helper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            key key1 = default(key); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Remove(key1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void RemoveTest1()
        {
            RemoveTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for System.Collections.IEnumerable.GetEnumerator
        ///</summary>
        public void GetEnumeratorTest1Helper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            IEnumerable target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            IEnumerator expected = null; // TODO: Initialize to an appropriate value
            IEnumerator actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void GetEnumeratorTest1()
        {
            GetEnumeratorTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TryGetValue
        ///</summary>
        public void TryGetValueTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            key key1 = default(key); // TODO: Initialize to an appropriate value
            val value = default(val); // TODO: Initialize to an appropriate value
            val valueExpected = default(val); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TryGetValue(key1, out value);
            Assert.AreEqual(valueExpected, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TryGetValueTest()
        {
            TryGetValueTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CountTest()
        {
            CountTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsReadOnly
        ///</summary>
        public void IsReadOnlyTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsReadOnly;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsReadOnlyTest()
        {
            IsReadOnlyTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        public void ItemTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            key key1 = default(key); // TODO: Initialize to an appropriate value
            val expected = default(val); // TODO: Initialize to an appropriate value
            val actual;
            target[key1] = expected;
            actual = target[key1];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ItemTest()
        {
            ItemTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        public void KeysTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            ICollection<key> actual;
            actual = target.Keys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void KeysTest()
        {
            KeysTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Values
        ///</summary>
        public void ValuesTestHelper<key, val>()
        {
            int timeoutMsec = 0; // TODO: Initialize to an appropriate value
            ExpiringDictionary<key, val> target = new ExpiringDictionary<key, val>(timeoutMsec); // TODO: Initialize to an appropriate value
            ICollection<val> actual;
            actual = target.Values;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ValuesTest()
        {
            ValuesTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
