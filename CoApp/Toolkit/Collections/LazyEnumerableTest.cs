using CoApp.Toolkit.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Test.CoApp.Toolkit.Collections
{
    
    
    /// <summary>
    ///This is a test class for LazyEnumerableTest and is intended
    ///to contain all LazyEnumerableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LazyEnumerableTest
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
        ///A test for LazyEnumerable`1 Constructor
        ///</summary>
        public void LazyEnumerableConstructorTestHelper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            LazyEnumerable<T> target = new LazyEnumerable<T>(source);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void LazyEnumerableConstructorTest()
        {
            LazyEnumerableConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        public void GetEnumeratorTestHelper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            LazyEnumerable<T> target = new LazyEnumerable<T>(source); // TODO: Initialize to an appropriate value
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
        ///A test for IsOk
        ///</summary>
        public void IsOkTestHelper<T>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            LazyEnumerable_Accessor<T> target = new LazyEnumerable_Accessor<T>(param0); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOk(index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void IsOkTest()
        {
            IsOkTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for System.Collections.IEnumerable.GetEnumerator
        ///</summary>
        public void GetEnumeratorTest1Helper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            IEnumerable target = new LazyEnumerable<T>(source); // TODO: Initialize to an appropriate value
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
            GetEnumeratorTest1Helper<GenericParameterHelper>();
        }
    }
}
