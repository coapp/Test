using CoApp.Toolkit.DynamicXml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Dynamic;

namespace Test.CoApp.Toolkit.DynamicXml
{
    
    
    /// <summary>
    ///This is a test class for DynamicDataSetTest and is intended
    ///to contain all DynamicDataSetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DynamicDataSetTest
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
        ///A test for DynamicDataSet Constructor
        ///</summary>
        [TestMethod()]
        public void DynamicDataSetConstructorTest()
        {
            DataSet dataSet = null; // TODO: Initialize to an appropriate value
            DynamicDataSet target = new DynamicDataSet(dataSet);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TryGetMember
        ///</summary>
        [TestMethod()]
        public void TryGetMemberTest()
        {
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
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            DataSet dataSet = null; // TODO: Initialize to an appropriate value
            DynamicDataSet target = new DynamicDataSet(dataSet); // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[propertyName];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
