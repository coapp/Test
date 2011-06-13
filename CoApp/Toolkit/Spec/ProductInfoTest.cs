using CoApp.Toolkit.Spec;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;

namespace Test.CoApp.Toolkit.Spec
{
    
    
    /// <summary>
    ///This is a test class for ProductInfoTest and is intended
    ///to contain all ProductInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductInfoTest
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
        ///A test for ProductInfo Constructor
        ///</summary>
        [TestMethod()]
        public void ProductInfoConstructorTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for License
        ///</summary>
        [TestMethod()]
        public void LicenseTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.License = expected;
            actual = target.License;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OriginalAuthor
        ///</summary>
        [TestMethod()]
        public void OriginalAuthorTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.OriginalAuthor = expected;
            actual = target.OriginalAuthor;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OriginalSourceLocation
        ///</summary>
        [TestMethod()]
        public void OriginalSourceLocationTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.OriginalSourceLocation = expected;
            actual = target.OriginalSourceLocation;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OriginalSourceWebsite
        ///</summary>
        [TestMethod()]
        public void OriginalSourceWebsiteTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.OriginalSourceWebsite = expected;
            actual = target.OriginalSourceWebsite;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OriginalVersion
        ///</summary>
        [TestMethod()]
        public void OriginalVersionTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.OriginalVersion = expected;
            actual = target.OriginalVersion;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Packager
        ///</summary>
        [TestMethod()]
        public void PackagerTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Packager = expected;
            actual = target.Packager;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProductName
        ///</summary>
        [TestMethod()]
        public void ProductNameTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ProductName = expected;
            actual = target.ProductName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Publisher
        ///</summary>
        [TestMethod()]
        public void PublisherTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Publisher = expected;
            actual = target.Publisher;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Version
        ///</summary>
        [TestMethod()]
        public void VersionTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            ProductInfo target = new ProductInfo(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Version = expected;
            actual = target.Version;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
