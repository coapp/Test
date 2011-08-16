using System.Data;
using CoApp.Toolkit.DynamicXml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Toolkit.Engine.Core.DynamicXml
{
    
    
    /// <summary>
    ///This is a test class for TestDynamicDataRow and is intended
    ///to contain all TestDynamicDataRow Unit Tests
    ///</summary>
    [TestClass()]
    public class TestDynamicDataRow
    {
        private System.Data.DataRow dataRow;

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
            DataTable DT = new DataTable();
            DT.Columns.Add("First", typeof (int));
            DT.Columns.Add("Next", typeof (string));
            DT.Columns.Add("Another", typeof (string));
            DT.Columns.Add("Last", typeof (string));
            DT.AcceptChanges();
            dataRow = DT.NewRow();
            dataRow.BeginEdit();
            dataRow["First"] = 42;
            dataRow["Next"] = "Look at your man, now back to me,";
            dataRow["Another"] = "Now back at your man, now back to me.";
            dataRow["Last"] = "I'm on a horse...";
            dataRow.EndEdit();
            DT.AcceptChanges();
        }
        //
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            dataRow = null;
        }
        //
        #endregion


        /// <summary>
        ///A test for DynamicDataRow Constructor
        ///</summary>
        [TestMethod()]
        public void TestDynamicDataRowConstructor()
        {
            try
            {
                DynamicDataRow target = new DynamicDataRow(dataRow);
                Assert.IsTrue(true);
            }
            catch
            { Assert.Fail("Failed to construct DynamicDataRow."); }
        }

        /// <summary>
        ///A test for TryGetMember
        ///</summary>
        [TestMethod()]
        public void TestTryGetMember()
        {
            Assert.Inconclusive("This method is under review for removal.");
            /*
            DynamicDataRow target = new DynamicDataRow(dataRow);
            System.Dynamic.GetMemberBinder binder = null; // TODO: Initialize to an appropriate value
            object result = null; // TODO: Initialize to an appropriate value
            object resultExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TryGetMember(binder, out result);
            Assert.AreEqual(resultExpected, result);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
             * */
        }
    }
}
