using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for AssemblyExtensionsTest and is intended
    ///to contain all AssemblyExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AssemblyExtensionsTest
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
        ///A test for Assembly
        ///</summary>
        [TestMethod()]
        public void AssemblyTest()
        {
            object obj = null; // TODO: Initialize to an appropriate value
            Assembly expected = null; // TODO: Initialize to an appropriate value
            Assembly actual;
            actual = AssemblyExtensions.Assembly(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Comments
        ///</summary>
        [TestMethod()]
        public void CommentsTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Comments(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Company
        ///</summary>
        [TestMethod()]
        public void CompanyTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Company(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Copyright
        ///</summary>
        [TestMethod()]
        public void CopyrightTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Copyright(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Description
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Description(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExtractFileResourceToPath
        ///</summary>
        [TestMethod()]
        public void ExtractFileResourceToPathTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string filePath = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.ExtractFileResourceToPath(assembly, name, filePath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExtractFileResourceToTemp
        ///</summary>
        [TestMethod()]
        public void ExtractFileResourceToTempTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.ExtractFileResourceToTemp(assembly, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Logo
        ///</summary>
        [TestMethod()]
        public void LogoTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Logo(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetLogo
        ///</summary>
        [TestMethod()]
        public void SetLogoTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string logoText = string.Empty; // TODO: Initialize to an appropriate value
            AssemblyExtensions.SetLogo(assembly, logoText);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Title
        ///</summary>
        [TestMethod()]
        public void TitleTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Title(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Version
        ///</summary>
        [TestMethod()]
        public void VersionTest()
        {
            Assembly assembly = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = AssemblyExtensions.Version(assembly);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
