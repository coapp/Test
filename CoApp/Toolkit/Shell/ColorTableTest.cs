using CoApp.Toolkit.Shell;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Shell
{
    
    
    /// <summary>
    ///This is a test class for ColorTableTest and is intended
    ///to contain all ColorTableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColorTableTest
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
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            long item = 0; // TODO: Initialize to an appropriate value
            target.Add(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        [TestMethod()]
        public void ClearTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Commit
        ///</summary>
        [TestMethod()]
        public void CommitTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            target.Commit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Contains
        ///</summary>
        [TestMethod()]
        public void ContainsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            long item = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Contains(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CopyTo
        ///</summary>
        [TestMethod()]
        public void CopyToTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            long[] array = null; // TODO: Initialize to an appropriate value
            int arrayIndex = 0; // TODO: Initialize to an appropriate value
            target.CopyTo(array, arrayIndex);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        [TestMethod()]
        public void GetEnumeratorTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            IEnumerator<long> expected = null; // TODO: Initialize to an appropriate value
            IEnumerator<long> actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IndexOf
        ///</summary>
        [TestMethod()]
        public void IndexOfTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            long item = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.IndexOf(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        [TestMethod()]
        public void InsertTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            long item = 0; // TODO: Initialize to an appropriate value
            target.Insert(index, item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        [TestMethod()]
        public void RemoveTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            long item = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Remove(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemoveAt
        ///</summary>
        [TestMethod()]
        public void RemoveAtTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            target.RemoveAt(index);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsReadOnly
        ///</summary>
        [TestMethod()]
        public void IsReadOnlyTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsReadOnly;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ColorTable_Accessor target = new ColorTable_Accessor(param0); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target[index] = expected;
            actual = target[index];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
