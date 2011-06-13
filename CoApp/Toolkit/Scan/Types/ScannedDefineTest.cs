using CoApp.Toolkit.Scan.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scan.Types
{
    
    
    /// <summary>
    ///This is a test class for ScannedDefineTest and is intended
    ///to contain all ScannedDefineTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScannedDefineTest
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
        ///A test for ScannedDefine Constructor
        ///</summary>
        [TestMethod()]
        public void ScannedDefineConstructorTest()
        {
            ScannedDefine target = new ScannedDefine();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToTest()
        {
            ScannedDefine target = new ScannedDefine(); // TODO: Initialize to an appropriate value
            ScannedDefine other = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CompareTo(other);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            ScannedDefine target = new ScannedDefine(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UsedIn
        ///</summary>
        [TestMethod()]
        public void UsedInTest()
        {
            ScannedDefine target = new ScannedDefine(); // TODO: Initialize to an appropriate value
            Dictionary<int, int> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<int, int> actual;
            target.UsedIn = expected;
            actual = target.UsedIn;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UsedInArray
        ///</summary>
        [TestMethod()]
        public void UsedInArrayTest()
        {
            ScannedDefine target = new ScannedDefine(); // TODO: Initialize to an appropriate value
            int[] expected = null; // TODO: Initialize to an appropriate value
            int[] actual;
            target.UsedInArray = expected;
            actual = target.UsedInArray;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Values
        ///</summary>
        [TestMethod()]
        public void ValuesTest()
        {
            ScannedDefine target = new ScannedDefine(); // TODO: Initialize to an appropriate value
            Dictionary<string, int> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> actual;
            target.Values = expected;
            actual = target.Values;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ValuesArray
        ///</summary>
        [TestMethod()]
        public void ValuesArrayTest()
        {
            ScannedDefine target = new ScannedDefine(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            string[] actual;
            target.ValuesArray = expected;
            actual = target.ValuesArray;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
