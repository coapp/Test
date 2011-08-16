using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for X509Certificate2ExtensionsTest and is intended
    ///to contain all X509Certificate2ExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class X509Certificate2ExtensionsTest
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
        ///A test for GetSubjectNameParts
        ///</summary>
        [TestMethod()]
        public void GetSubjectNamePartsTest()
        {
            X509Certificate2 cert = null; // TODO: Initialize to an appropriate value
            Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, string> actual;
            actual = X509Certificate2Extensions.GetSubjectNameParts(cert);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
