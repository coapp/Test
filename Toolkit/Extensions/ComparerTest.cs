using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for ComparerTest and is intended
    ///to contain all ComparerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ComparerTest
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
        ///A test for Comparer`1 Constructor
        ///</summary>
        public void ComparerConstructorTestHelper<T>()
        {
            Func<T, T, int> compareFn = null; // TODO: Initialize to an appropriate value
            Comparer<T> target = new Comparer<T>(compareFn);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ComparerConstructorTest()
        {
            ComparerConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Compare
        ///</summary>
        public void CompareTestHelper<T>()
        {
            Func<T, T, int> compareFn = null; // TODO: Initialize to an appropriate value
            Comparer<T> target = new Comparer<T>(compareFn); // TODO: Initialize to an appropriate value
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Compare(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CompareTest()
        {
            CompareTestHelper<GenericParameterHelper>();
        }
    }
}
