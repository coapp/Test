using CoApp.Toolkit.Extensions;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit
{
    
    
    /// <summary>
    ///This is a test class for ObjectExtensionsTest and is intended
    ///to contain all ObjectExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ObjectExtensionsTest
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
        ///A test for CreateHashCode
        ///</summary>
        [TestMethod()]
        public void CreateHashCodeTest()
        {
            object input = ""; // TODO: Initialize to an appropriate value
            string[] objects = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"};

            int expectedFirst = 1271967684; 
            int actualFirst;
            actualFirst = ObjectExtensions.CreateHashCode(input, objects);
            Assert.AreEqual(expectedFirst, actualFirst, "Calculating the hashcode for ten items failed");

            string eleventh = "Eleventh";
            int expectedSecond = expectedFirst + eleventh.GetHashCode();
            int actualSecond = ObjectExtensions.CreateHashCode(input, objects.Concat(new string[] { eleventh }).ToArray());
            Assert.AreEqual(expectedSecond, actualSecond, "Calculating the hashcode for eleven items failed");
            
        }
    }
}
