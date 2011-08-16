using CoApp.Autopackage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevTools
{
    
    
    /// <summary>
    ///This is a test class for TestTempedFile and is intended
    ///to contain all TestTempedFile Unit Tests
    ///</summary>
    [TestClass()]
    public class TestTempedFile
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
        ///A test for TempedFile Constructor
        ///</summary>
        [TestMethod()]
        public void TestTempedFileConstructor()
        {
            TempedFile target = new TempedFile();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void TestEquals()
        {
            TempedFile target = new TempedFile(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void TestGetHashCode()
        {
            TempedFile target = new TempedFile(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Tempify
        ///</summary>
        [TestMethod()]
        public void TestTempify()
        {
            TempedFile target = new TempedFile(); // TODO: Initialize to an appropriate value
            string tempDirectory = string.Empty; // TODO: Initialize to an appropriate value
            target.Tempify(tempDirectory);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        [TestMethod()]
        public void Testop_Implicit()
        {
            TempedFile t = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = t;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        [TestMethod()]
        public void Testop_Implicit1()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            TempedFile expected = null; // TODO: Initialize to an appropriate value
            TempedFile actual;
            actual = path;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
