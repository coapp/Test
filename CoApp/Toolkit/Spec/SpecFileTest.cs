using CoApp.Toolkit.Spec;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Spec
{
    
    
    /// <summary>
    ///This is a test class for SpecFileTest and is intended
    ///to contain all SpecFileTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SpecFileTest
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
        ///A test for SpecFile Constructor
        ///</summary>
        [TestMethod()]
        public void SpecFileConstructorTest()
        {
            SpecFile target = new SpecFile();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            SpecFile expected = null; // TODO: Initialize to an appropriate value
            SpecFile actual;
            actual = SpecFile.Load(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            SpecFile target = new SpecFile(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.Save(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Validate
        ///</summary>
        [TestMethod()]
        public void ValidateTest()
        {
            SpecFile target = new SpecFile(); // TODO: Initialize to an appropriate value
            target.Validate();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        [TestMethod()]
        public void KeysTest()
        {
            SpecFile target = new SpecFile(); // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.Keys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Link
        ///</summary>
        [TestMethod()]
        public void LinkTest()
        {
            SpecFile target = new SpecFile(); // TODO: Initialize to an appropriate value
            Link actual;
            actual = target.Link;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProductInfo
        ///</summary>
        [TestMethod()]
        public void ProductInfoTest()
        {
            SpecFile target = new SpecFile(); // TODO: Initialize to an appropriate value
            ProductInfo actual;
            actual = target.ProductInfo;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
