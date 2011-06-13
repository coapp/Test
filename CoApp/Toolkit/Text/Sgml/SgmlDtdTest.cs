using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for SgmlDtdTest and is intended
    ///to contain all SgmlDtdTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SgmlDtdTest
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
        ///A test for SgmlDtd Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlDtdConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd target = new SgmlDtd(name, nt);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for FindElement
        ///</summary>
        [TestMethod()]
        public void FindElementTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd target = new SgmlDtd(name, nt); // TODO: Initialize to an appropriate value
            string name1 = string.Empty; // TODO: Initialize to an appropriate value
            ElementDecl expected = null; // TODO: Initialize to an appropriate value
            ElementDecl actual;
            actual = target.FindElement(name1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindEntity
        ///</summary>
        [TestMethod()]
        public void FindEntityTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd target = new SgmlDtd(name, nt); // TODO: Initialize to an appropriate value
            string name1 = string.Empty; // TODO: Initialize to an appropriate value
            Entity expected = null; // TODO: Initialize to an appropriate value
            Entity actual;
            actual = target.FindEntity(name1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetEntitiesLiteralNameLookup
        ///</summary>
        [TestMethod()]
        public void GetEntitiesLiteralNameLookupTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd target = new SgmlDtd(name, nt); // TODO: Initialize to an appropriate value
            Dictionary<string, Entity> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, Entity> actual;
            actual = target.GetEntitiesLiteralNameLookup();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Parse
        ///</summary>
        [TestMethod()]
        public void ParseTest()
        {
            Uri baseUri = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            TextReader input = null; // TODO: Initialize to an appropriate value
            string subset = string.Empty; // TODO: Initialize to an appropriate value
            string proxy = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd expected = null; // TODO: Initialize to an appropriate value
            SgmlDtd actual;
            actual = SgmlDtd.Parse(baseUri, name, input, subset, proxy, nt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Parse
        ///</summary>
        [TestMethod()]
        public void ParseTest1()
        {
            Uri baseUri = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string pubid = string.Empty; // TODO: Initialize to an appropriate value
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string subset = string.Empty; // TODO: Initialize to an appropriate value
            string proxy = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd expected = null; // TODO: Initialize to an appropriate value
            SgmlDtd actual;
            actual = SgmlDtd.Parse(baseUri, name, pubid, url, subset, proxy, nt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd target = new SgmlDtd(name, nt); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NameTable
        ///</summary>
        [TestMethod()]
        public void NameTableTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlDtd target = new SgmlDtd(name, nt); // TODO: Initialize to an appropriate value
            XmlNameTable actual;
            actual = target.NameTable;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
