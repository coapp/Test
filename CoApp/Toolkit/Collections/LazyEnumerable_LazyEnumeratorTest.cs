using CoApp.Toolkit.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Collections
{
    
    
    /// <summary>
    ///This is a test class for LazyEnumerable_LazyEnumeratorTest and is intended
    ///to contain all LazyEnumerable_LazyEnumeratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LazyEnumerable_LazyEnumeratorTest
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
        ///A test for LazyEnumerator`1 Constructor
        ///</summary>
        public void LazyEnumerable_LazyEnumeratorConstructorTestHelper<T, TT>()
        {
            LazyEnumerable<TT> collection = null; // TODO: Initialize to an appropriate value
            LazyEnumerable_Accessor<T>.LazyEnumerator<TT> target = new LazyEnumerable_Accessor<T>.LazyEnumerator<TT>(collection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void LazyEnumerable_LazyEnumeratorConstructorTest()
        {
            LazyEnumerable_LazyEnumeratorConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        public void DisposeTestHelper<T, TT>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            LazyEnumerable_Accessor<T>.LazyEnumerator<TT> target = new LazyEnumerable_Accessor<T>.LazyEnumerator<TT>(param0); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void DisposeTest()
        {
            DisposeTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MoveNext
        ///</summary>
        public void MoveNextTestHelper<T, TT>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            LazyEnumerable_Accessor<T>.LazyEnumerator<TT> target = new LazyEnumerable_Accessor<T>.LazyEnumerator<TT>(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveNext();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void MoveNextTest()
        {
            MoveNextTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        public void ResetTestHelper<T, TT>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            LazyEnumerable_Accessor<T>.LazyEnumerator<TT> target = new LazyEnumerable_Accessor<T>.LazyEnumerator<TT>(param0); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void ResetTest()
        {
            ResetTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Current
        ///</summary>
        public void CurrentTestHelper<T, TT>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            LazyEnumerable_Accessor<T>.LazyEnumerator<TT> target = new LazyEnumerable_Accessor<T>.LazyEnumerator<TT>(param0); // TODO: Initialize to an appropriate value
            TT actual;
            actual = target.Current;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void CurrentTest()
        {
            CurrentTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for System.Collections.IEnumerator.Current
        ///</summary>
        public void CurrentTest1Helper<T, TT>()
        {
            // Class inheritance across assemblies is not preserved by private accessors. However, a static method AttachShadow() is provided in each private accessor class to transfer a private object from one private accessor class to another.
            Assert.Inconclusive("Class inheritance across assemblies is not preserved by private accessors. Howeve" +
                    "r, a static method AttachShadow() is provided in each private accessor class to " +
                    "transfer a private object from one private accessor class to another.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void CurrentTest1()
        {
            CurrentTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
