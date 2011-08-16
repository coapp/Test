using CoApp.Toolkit.DynamicXml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Dynamic;

namespace Test.Toolkit.Engine.Core.DynamicXml
{
    
    
    /// <summary>
    ///This is a test class for TestDynamicDataSet and is intended
    ///to contain all TestDynamicDataSet Unit Tests
    ///</summary>
    [TestClass()]
    public class TestDynamicDataSet
    {
        private DataSet dataSet;

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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            dataSet = new DataSet("TestSet");
            dataSet.Tables.Add("Property");
            dataSet.Tables["Property"].Columns.Add("Property", typeof (string));
            dataSet.Tables["Property"].Columns.Add("Value", typeof(string));
            dataSet.Tables["Property"].Rows.Add(new object[] {"MyName", "Put Stuff Here" });
            dataSet.AcceptChanges();
        }
        //
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            dataSet = null;
        }
        //
        #endregion


        /// <summary>
        ///A test for DynamicDataSet Constructor
        ///</summary>
        [TestMethod()]
        public void TestDynamicDataSetConstructor()
        {
            try
            {
                DynamicDataSet target = new DynamicDataSet(dataSet);
                Assert.IsTrue(true);
            }
            catch
            { Assert.Fail("Failed to construct DynamicDataSet"); }
        }

        /// <summary>
        ///A test for TryGetMember
        ///</summary>
        [TestMethod()]
        public void TestTryGetMember()
        {
            Assert.Inconclusive("This method is under review for removal.");
            /*
            DataSet dataSet = null; // TODO: Initialize to an appropriate value
            DynamicDataSet target = new DynamicDataSet(dataSet); // TODO: Initialize to an appropriate value
            GetMemberBinder binder = null; // TODO: Initialize to an appropriate value
            object result = null; // TODO: Initialize to an appropriate value
            object resultExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TryGetMember(binder, out result);
            Assert.AreEqual(resultExpected, result);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
            */
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void TestItem()
        {
            DynamicDataSet target = new DynamicDataSet(dataSet); // TODO: Initialize to an appropriate value
            string propertyName = "MyName";
            string expected = "Put Stuff Here";
            string actual;
            actual = target[propertyName];
            Assert.AreEqual(expected, actual);
        }
    }
}
