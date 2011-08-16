using CoApp.Toolkit.DynamicXml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Collections.Generic;

namespace Test.Toolkit.Engine.Core
{
    
    
    /// <summary>
    ///This is a test class for TestDynamicDataTable and is intended
    ///to contain all TestDynamicDataTable Unit Tests
    ///</summary>
    [TestClass()]
    public class TestDynamicDataTable
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
        ///A test for DynamicDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void TestDynamicDataTableConstructor()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            DynamicDataTable target = new DynamicDataTable(table);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        [TestMethod()]
        public void TestGetEnumerator()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            DynamicDataTable target = new DynamicDataTable(table); // TODO: Initialize to an appropriate value
            IEnumerator<DynamicDataRow> expected = null; // TODO: Initialize to an appropriate value
            IEnumerator<DynamicDataRow> actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void TestItem()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            DynamicDataTable target = new DynamicDataTable(table); // TODO: Initialize to an appropriate value
            object keyValue = null; // TODO: Initialize to an appropriate value
            DynamicDataRow actual;
            actual = target[keyValue];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void TestItem1()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            DynamicDataTable target = new DynamicDataTable(table); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            DynamicDataRow actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
