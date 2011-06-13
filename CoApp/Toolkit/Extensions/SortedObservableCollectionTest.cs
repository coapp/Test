using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for SortedObservableCollectionTest and is intended
    ///to contain all SortedObservableCollectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SortedObservableCollectionTest
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
        ///A test for SortedObservableCollection`1 Constructor
        ///</summary>
        public void SortedObservableCollectionConstructorTestHelper<T>()
            where T : IComparable
        {
            SortedObservableCollection<T> target = new SortedObservableCollection<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SortedObservableCollectionConstructorTest()
        {
            SortedObservableCollectionConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Sort
        ///</summary>
        public void SortTestHelper<T, TKey>()
            where T : IComparable
        {
            SortedObservableCollection<T> target = new SortedObservableCollection<T>(); // TODO: Initialize to an appropriate value
            Func<T, TKey> keySelector = null; // TODO: Initialize to an appropriate value
            target.Sort<TKey>(keySelector);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void SortTest()
        {
            SortTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Sort
        ///</summary>
        public void SortTest1Helper<T, TKey>()
            where T : IComparable
        {
            SortedObservableCollection<T> target = new SortedObservableCollection<T>(); // TODO: Initialize to an appropriate value
            Func<T, TKey> keySelector = null; // TODO: Initialize to an appropriate value
            IComparer<TKey> comparer = null; // TODO: Initialize to an appropriate value
            target.Sort<TKey>(keySelector, comparer);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void SortTest1()
        {
            SortTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
