using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for LinqExtensionsTest and is intended
    ///to contain all LinqExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LinqExtensionsTest
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
        ///A test for ByIndex
        ///</summary>
        public void ByIndexTestHelper<T>()
        {
            IList<T> lst = null; // TODO: Initialize to an appropriate value
            IEnumerable<int> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<int> actual;
            actual = LinqExtensions.ByIndex<T>(lst);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ByIndexTest()
        {
            ByIndexTestHelper<GenericParameterHelper>();
        }

/*  TR01: TODO: Need to correct this helper method to not die horribly.
        /// <summary>
        ///A test for MaxElement
        ///</summary>
        public void MaxElementTestHelper<T, U>()

            where U : IComparable<T>
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            Func<T, U> selector = null; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = LinqExtensions.MaxElement<T, U>(source, selector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
 */

        [TestMethod()]
        public void MaxElementTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of U. " +
                    "Please call MaxElementTestHelper<T, U>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for SingleItemAsEnumerable
        ///</summary>
        public void SingleItemAsEnumerableTestHelper<T>()
        {
            T source = default(T); // TODO: Initialize to an appropriate value
            IEnumerable<T> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<T> actual;
            actual = LinqExtensions.SingleItemAsEnumerable<T>(source);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SingleItemAsEnumerableTest()
        {
            SingleItemAsEnumerableTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TakeAllBut
        ///</summary>
        public void TakeAllButTestHelper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            IEnumerable<T> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<T> actual;
            actual = LinqExtensions.TakeAllBut<T>(source, count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TakeAllButTest()
        {
            TakeAllButTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TakeFromEnd
        ///</summary>
        public void TakeFromEndTestHelper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            IEnumerable<T> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<T> actual;
            actual = LinqExtensions.TakeFromEnd<T>(source, count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TakeFromEndTest()
        {
            TakeFromEndTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Traverse
        ///</summary>
        public void TraverseTestHelper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            Func<T, IEnumerable<T>> recurseFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<T> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<T> actual;
            actual = LinqExtensions.Traverse<T>(source, recurseFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TraverseTest()
        {
            TraverseTestHelper<GenericParameterHelper>();
        }
    }
}
