using CoApp.Toolkit.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Engine
{
    
    
    /// <summary>
    ///This is a test class for MultiplexedPropertyTest and is intended
    ///to contain all MultiplexedPropertyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MultiplexedPropertyTest
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
        ///A test for Value
        ///</summary>
        public void ValueTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ValueTest()
        {
            ValueTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for OtherValues
        ///</summary>
        public void OtherValuesTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            IEnumerable<T> actual;
            actual = target.OtherValues;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void OtherValuesTest()
        {
            OtherValuesTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for HasOtherValues
        ///</summary>
        public void HasOtherValuesTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasOtherValues;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void HasOtherValuesTest()
        {
            HasOtherValuesTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        public void op_ImplicitTestHelper<T>()
        {
            MultiplexedProperty<T> property = null; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = property;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ImplicitTest()
        {
            op_ImplicitTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        public void ToStringTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            ToStringTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        public void GetEnumeratorTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
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
        ///A test for ContainsValue
        ///</summary>
        public void ContainsValueTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            T value = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ContainsValue(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContainsValueTest()
        {
            ContainsValueTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        public void AddTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            T newValue = default(T); // TODO: Initialize to an appropriate value
            target.Add(newValue);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddTest()
        {
            AddTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        public void AddTest1Helper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins); // TODO: Initialize to an appropriate value
            IEnumerable<T> values = null; // TODO: Initialize to an appropriate value
            target.Add(values);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddTest1()
        {
            AddTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MultiplexedProperty`1 Constructor
        ///</summary>
        public void MultiplexedPropertyConstructorTestHelper<T>()
        {
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(lastValueWins);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MultiplexedPropertyConstructorTest()
        {
            MultiplexedPropertyConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MultiplexedProperty`1 Constructor
        ///</summary>
        public void MultiplexedPropertyConstructorTest1Helper<T>()
        {
            EventHandler onChanged = null; // TODO: Initialize to an appropriate value
            bool lastValueWins = false; // TODO: Initialize to an appropriate value
            MultiplexedProperty<T> target = new MultiplexedProperty<T>(onChanged, lastValueWins);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MultiplexedPropertyConstructorTest1()
        {
            MultiplexedPropertyConstructorTest1Helper<GenericParameterHelper>();
        }
    }
}
