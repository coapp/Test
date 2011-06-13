using CoApp.Toolkit.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Test.CoApp.Toolkit.Collections
{
    
    
    /// <summary>
    ///This is a test class for VirtualEnumeratorTest and is intended
    ///to contain all VirtualEnumeratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VirtualEnumeratorTest
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
        ///A test for VirtualEnumerator`1 Constructor
        ///</summary>
        public void VirtualEnumeratorConstructorTestHelper<T>()
        {
            IEnumerator backingEnumerator = null; // TODO: Initialize to an appropriate value
            Func<IEnumerator, T> fn = null; // TODO: Initialize to an appropriate value
            VirtualEnumerator<T> target = new VirtualEnumerator<T>(backingEnumerator, fn);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void VirtualEnumeratorConstructorTest()
        {
            VirtualEnumeratorConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        public void DisposeTestHelper<T>()
        {
            IEnumerator backingEnumerator = null; // TODO: Initialize to an appropriate value
            Func<IEnumerator, T> fn = null; // TODO: Initialize to an appropriate value
            VirtualEnumerator<T> target = new VirtualEnumerator<T>(backingEnumerator, fn); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void DisposeTest()
        {
            DisposeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MoveNext
        ///</summary>
        public void MoveNextTestHelper<T>()
        {
            IEnumerator backingEnumerator = null; // TODO: Initialize to an appropriate value
            Func<IEnumerator, T> fn = null; // TODO: Initialize to an appropriate value
            VirtualEnumerator<T> target = new VirtualEnumerator<T>(backingEnumerator, fn); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveNext();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MoveNextTest()
        {
            MoveNextTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        public void ResetTestHelper<T>()
        {
            IEnumerator backingEnumerator = null; // TODO: Initialize to an appropriate value
            Func<IEnumerator, T> fn = null; // TODO: Initialize to an appropriate value
            VirtualEnumerator<T> target = new VirtualEnumerator<T>(backingEnumerator, fn); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ResetTest()
        {
            ResetTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Current
        ///</summary>
        public void CurrentTestHelper<T>()
        {
            IEnumerator backingEnumerator = null; // TODO: Initialize to an appropriate value
            Func<IEnumerator, T> fn = null; // TODO: Initialize to an appropriate value
            VirtualEnumerator<T> target = new VirtualEnumerator<T>(backingEnumerator, fn); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.Current;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CurrentTest()
        {
            CurrentTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for System.Collections.IEnumerator.Current
        ///</summary>
        public void CurrentTest1Helper<T>()
        {
            IEnumerator backingEnumerator = null; // TODO: Initialize to an appropriate value
            Func<IEnumerator, T> fn = null; // TODO: Initialize to an appropriate value
            IEnumerator target = new VirtualEnumerator<T>(backingEnumerator, fn); // TODO: Initialize to an appropriate value
            object actual;
            actual = target.Current;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void CurrentTest1()
        {
            CurrentTest1Helper<GenericParameterHelper>();
        }
    }
}
