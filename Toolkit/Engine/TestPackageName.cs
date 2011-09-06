using CoApp.Toolkit.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Engine.Client
{
    
    
    /// <summary>
    ///This is a test class for TestPackageName and is intended
    ///to contain all TestPackageName Unit Tests
    ///</summary>
    [TestClass()]
    public class TestPackageName
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
        ///A test for Parse
        ///</summary>
        [DeploymentItem("..\\Engine\\Client\\PackageNames.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Engine\\Client\\PackageNames.csv", "PackageNames#csv", DataAccessMethod.Sequential), TestMethod()]
        public void TestParse()
        {
            string potentialPartialPackageName = (string)testContextInstance.DataRow["STR"]; // TODO: Initialize to an appropriate value
            PackageName expected = null; // TODO: Initialize to an appropriate value
            PackageName actual;
            actual = PackageName.Parse(potentialPartialPackageName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsFullMatch
        ///</summary>
        [TestMethod()]
        public void TestIsFullMatch()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PackageName_Accessor target = new PackageName_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsFullMatch;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsPartialMatch
        ///</summary>
        [TestMethod()]
        public void TestIsPartialMatch()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            PackageName_Accessor target = new PackageName_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsPartialMatch;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
