using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for XmlExtensionsTest and is intended
    ///to contain all XmlExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class XmlExtensionsTest
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
        ///A test for DocumentNodes
        ///</summary>
        [TestMethod()]
        public void DocumentNodesTest()
        {
            XmlDocument doc = null; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.DocumentNodes(doc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InnerText
        ///</summary>
        [TestMethod()]
        public void InnerTextTest()
        {
            XmlNodeList nodeList = null; // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = XmlExtensions.InnerText(nodeList);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsXmlFile
        ///</summary>
        [TestMethod()]
        public void IsXmlFileTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = XmlExtensions.IsXmlFile(filename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for JsonDeserialize
        ///</summary>
        public void JsonDeserializeTestHelper<TType>()
        {
            string jsonText = string.Empty; // TODO: Initialize to an appropriate value
            TType expected = default(TType); // TODO: Initialize to an appropriate value
            TType actual;
            actual = XmlExtensions.JsonDeserialize<TType>(jsonText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void JsonDeserializeTest()
        {
            JsonDeserializeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for JsonDoc
        ///</summary>
        [TestMethod()]
        public void JsonDocTest()
        {
            string jsonDoc = string.Empty; // TODO: Initialize to an appropriate value
            XmlDocument expected = null; // TODO: Initialize to an appropriate value
            XmlDocument actual;
            actual = XmlExtensions.JsonDoc(jsonDoc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for JsonSerialize
        ///</summary>
        [TestMethod()]
        public void JsonSerializeTest()
        {
            object obj = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = XmlExtensions.JsonSerialize(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PrettySaveXml
        ///</summary>
        [TestMethod()]
        public void PrettySaveXmlTest()
        {
            MemoryStream xmlDocumentStream = null; // TODO: Initialize to an appropriate value
            string outputPath = string.Empty; // TODO: Initialize to an appropriate value
            XmlExtensions.PrettySaveXml(xmlDocumentStream, outputPath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PrettySaveXml
        ///</summary>
        [TestMethod()]
        public void PrettySaveXmlTest1()
        {
            IEnumerable<string> xmlDocumentText = null; // TODO: Initialize to an appropriate value
            string outputPath = string.Empty; // TODO: Initialize to an appropriate value
            XmlExtensions.PrettySaveXml(xmlDocumentText, outputPath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToJsonString
        ///</summary>
        [TestMethod()]
        public void ToJsonStringTest()
        {
            XmlDocument xmlDoc = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = XmlExtensions.ToJsonString(xmlDoc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToXmlDocument
        ///</summary>
        [TestMethod()]
        public void ToXmlDocumentTest()
        {
            XmlNodeList nodeList = null; // TODO: Initialize to an appropriate value
            XmlDocument expected = null; // TODO: Initialize to an appropriate value
            XmlDocument actual;
            actual = XmlExtensions.ToXmlDocument(nodeList);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPath
        ///</summary>
        [TestMethod()]
        public void XPathTest()
        {
            XmlNode doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPath(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPath
        ///</summary>
        [TestMethod()]
        public void XPathTest1()
        {
            XmlNodeList doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPath(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPath
        ///</summary>
        [TestMethod()]
        public void XPathTest2()
        {
            string doc = string.Empty; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPath(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPath
        ///</summary>
        [TestMethod()]
        public void XPathTest3()
        {
            XmlDocument doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPath(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathContains
        ///</summary>
        [TestMethod()]
        public void XPathContainsTest()
        {
            XmlNode doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathContains(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathContains
        ///</summary>
        [TestMethod()]
        public void XPathContainsTest1()
        {
            XmlNodeList doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathContains(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathContains
        ///</summary>
        [TestMethod()]
        public void XPathContainsTest2()
        {
            string doc = string.Empty; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathContains(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathContains
        ///</summary>
        [TestMethod()]
        public void XPathContainsTest3()
        {
            XmlDocument doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathContains(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathExcludes
        ///</summary>
        [TestMethod()]
        public void XPathExcludesTest()
        {
            XmlNodeList doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathExcludes(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathExcludes
        ///</summary>
        [TestMethod()]
        public void XPathExcludesTest1()
        {
            string doc = string.Empty; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathExcludes(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathExcludes
        ///</summary>
        [TestMethod()]
        public void XPathExcludesTest2()
        {
            XmlNode doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathExcludes(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathExcludes
        ///</summary>
        [TestMethod()]
        public void XPathExcludesTest3()
        {
            XmlDocument doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            string containsText = string.Empty; // TODO: Initialize to an appropriate value
            XmlNodeList expected = null; // TODO: Initialize to an appropriate value
            XmlNodeList actual;
            actual = XmlExtensions.XPathExcludes(doc, XPathExpression, containsText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathSingle
        ///</summary>
        [TestMethod()]
        public void XPathSingleTest()
        {
            string doc = string.Empty; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNode expected = null; // TODO: Initialize to an appropriate value
            XmlNode actual;
            actual = XmlExtensions.XPathSingle(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathSingle
        ///</summary>
        [TestMethod()]
        public void XPathSingleTest1()
        {
            XmlNodeList doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNode expected = null; // TODO: Initialize to an appropriate value
            XmlNode actual;
            actual = XmlExtensions.XPathSingle(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathSingle
        ///</summary>
        [TestMethod()]
        public void XPathSingleTest2()
        {
            XmlNode doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNode expected = null; // TODO: Initialize to an appropriate value
            XmlNode actual;
            actual = XmlExtensions.XPathSingle(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XPathSingle
        ///</summary>
        [TestMethod()]
        public void XPathSingleTest3()
        {
            XmlDocument doc = null; // TODO: Initialize to an appropriate value
            string XPathExpression = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            XmlNode expected = null; // TODO: Initialize to an appropriate value
            XmlNode actual;
            actual = XmlExtensions.XPathSingle(doc, XPathExpression, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XmlDoc
        ///</summary>
        [TestMethod()]
        public void XmlDocTest()
        {
            string xmlDoc = string.Empty; // TODO: Initialize to an appropriate value
            XmlDocument expected = null; // TODO: Initialize to an appropriate value
            XmlDocument actual;
            actual = XmlExtensions.XmlDoc(xmlDoc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
