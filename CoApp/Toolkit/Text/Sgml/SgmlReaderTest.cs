using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Text;
using System.IO;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for SgmlReaderTest and is intended
    ///to contain all SgmlReaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SgmlReaderTest
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
        ///A test for SgmlReader Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlReaderConstructorTest()
        {
            XmlNameTable nt = null; // TODO: Initialize to an appropriate value
            SgmlReader target = new SgmlReader(nt);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SgmlReader Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlReaderConstructorTest1()
        {
            SgmlReader target = new SgmlReader();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Close
        ///</summary>
        [TestMethod()]
        public void CloseTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            target.Close();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetAttribute
        ///</summary>
        [TestMethod()]
        public void GetAttributeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string namespaceURI = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetAttribute(name, namespaceURI);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAttribute
        ///</summary>
        [TestMethod()]
        public void GetAttributeTest1()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetAttribute(i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAttribute
        ///</summary>
        [TestMethod()]
        public void GetAttributeTest2()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetAttribute(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetEncoding
        ///</summary>
        [TestMethod()]
        public void GetEncodingTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            Encoding expected = null; // TODO: Initialize to an appropriate value
            Encoding actual;
            actual = target.GetEncoding();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LookupNamespace
        ///</summary>
        [TestMethod()]
        public void LookupNamespaceTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string prefix = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LookupNamespace(prefix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveToAttribute
        ///</summary>
        [TestMethod()]
        public void MoveToAttributeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            target.MoveToAttribute(i);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveToAttribute
        ///</summary>
        [TestMethod()]
        public void MoveToAttributeTest1()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string ns = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveToAttribute(name, ns);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveToAttribute
        ///</summary>
        [TestMethod()]
        public void MoveToAttributeTest2()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveToAttribute(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveToElement
        ///</summary>
        [TestMethod()]
        public void MoveToElementTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveToElement();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveToFirstAttribute
        ///</summary>
        [TestMethod()]
        public void MoveToFirstAttributeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveToFirstAttribute();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveToNextAttribute
        ///</summary>
        [TestMethod()]
        public void MoveToNextAttributeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveToNextAttribute();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Read
        ///</summary>
        [TestMethod()]
        public void ReadTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Read();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadAttributeValue
        ///</summary>
        [TestMethod()]
        public void ReadAttributeValueTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ReadAttributeValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadInnerXml
        ///</summary>
        [TestMethod()]
        public void ReadInnerXmlTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReadInnerXml();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadOuterXml
        ///</summary>
        [TestMethod()]
        public void ReadOuterXmlTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReadOuterXml();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadString
        ///</summary>
        [TestMethod()]
        public void ReadStringTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReadString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResolveEntity
        ///</summary>
        [TestMethod()]
        public void ResolveEntityTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            target.ResolveEntity();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetBaseUri
        ///</summary>
        [TestMethod()]
        public void SetBaseUriTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string uri = string.Empty; // TODO: Initialize to an appropriate value
            target.SetBaseUri(uri);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AttributeCount
        ///</summary>
        [TestMethod()]
        public void AttributeCountTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AttributeCount;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BaseURI
        ///</summary>
        [TestMethod()]
        public void BaseURITest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BaseURI;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CaseFolding
        ///</summary>
        [TestMethod()]
        public void CaseFoldingTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            CaseFolding expected = new CaseFolding(); // TODO: Initialize to an appropriate value
            CaseFolding actual;
            target.CaseFolding = expected;
            actual = target.CaseFolding;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Depth
        ///</summary>
        [TestMethod()]
        public void DepthTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Depth;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DocType
        ///</summary>
        [TestMethod()]
        public void DocTypeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.DocType = expected;
            actual = target.DocType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dtd
        ///</summary>
        [TestMethod()]
        public void DtdTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            SgmlDtd expected = null; // TODO: Initialize to an appropriate value
            SgmlDtd actual;
            target.Dtd = expected;
            actual = target.Dtd;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EOF
        ///</summary>
        [TestMethod()]
        public void EOFTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.EOF;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ErrorLog
        ///</summary>
        [TestMethod()]
        public void ErrorLogTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            TextWriter expected = null; // TODO: Initialize to an appropriate value
            TextWriter actual;
            target.ErrorLog = expected;
            actual = target.ErrorLog;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ErrorLogFile
        ///</summary>
        [TestMethod()]
        public void ErrorLogFileTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ErrorLogFile = expected;
            actual = target.ErrorLogFile;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasValue
        ///</summary>
        [TestMethod()]
        public void HasValueTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasValue;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Href
        ///</summary>
        [TestMethod()]
        public void HrefTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Href = expected;
            actual = target.Href;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IgnoreDtd
        ///</summary>
        [TestMethod()]
        public void IgnoreDtdTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IgnoreDtd = expected;
            actual = target.IgnoreDtd;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InputStream
        ///</summary>
        [TestMethod()]
        public void InputStreamTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            TextReader expected = null; // TODO: Initialize to an appropriate value
            TextReader actual;
            target.InputStream = expected;
            actual = target.InputStream;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InternalSubset
        ///</summary>
        [TestMethod()]
        public void InternalSubsetTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.InternalSubset = expected;
            actual = target.InternalSubset;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsDefault
        ///</summary>
        [TestMethod()]
        public void IsDefaultTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsDefault;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsEmptyElement
        ///</summary>
        [TestMethod()]
        public void IsEmptyElementTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmptyElement;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsHtml
        ///</summary>
        [TestMethod()]
        public void IsHtmlTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsHtml;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[name];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest1()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[i];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest2()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string namespaceURI = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target[name, namespaceURI];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LocalName
        ///</summary>
        [TestMethod()]
        public void LocalNameTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LocalName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
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
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            XmlNameTable actual;
            actual = target.NameTable;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NamespaceURI
        ///</summary>
        [TestMethod()]
        public void NamespaceURITest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.NamespaceURI;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NodeType
        ///</summary>
        [TestMethod()]
        public void NodeTypeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            XmlNodeType actual;
            actual = target.NodeType;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Prefix
        ///</summary>
        [TestMethod()]
        public void PrefixTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Prefix;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PublicIdentifier
        ///</summary>
        [TestMethod()]
        public void PublicIdentifierTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.PublicIdentifier = expected;
            actual = target.PublicIdentifier;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QuoteChar
        ///</summary>
        [TestMethod()]
        public void QuoteCharTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            char actual;
            actual = target.QuoteChar;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadState
        ///</summary>
        [TestMethod()]
        public void ReadStateTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            ReadState actual;
            actual = target.ReadState;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RootElementName
        ///</summary>
        [TestMethod()]
        public void RootElementNameTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.RootElementName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StripDocType
        ///</summary>
        [TestMethod()]
        public void StripDocTypeTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.StripDocType = expected;
            actual = target.StripDocType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SystemLiteral
        ///</summary>
        [TestMethod()]
        public void SystemLiteralTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SystemLiteral = expected;
            actual = target.SystemLiteral;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Value;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WebProxy
        ///</summary>
        [TestMethod()]
        public void WebProxyTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.WebProxy = expected;
            actual = target.WebProxy;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WhitespaceHandling
        ///</summary>
        [TestMethod()]
        public void WhitespaceHandlingTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            WhitespaceHandling expected = new WhitespaceHandling(); // TODO: Initialize to an appropriate value
            WhitespaceHandling actual;
            target.WhitespaceHandling = expected;
            actual = target.WhitespaceHandling;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XmlLang
        ///</summary>
        [TestMethod()]
        public void XmlLangTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.XmlLang;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XmlSpace
        ///</summary>
        [TestMethod()]
        public void XmlSpaceTest()
        {
            SgmlReader target = new SgmlReader(); // TODO: Initialize to an appropriate value
            XmlSpace actual;
            actual = target.XmlSpace;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
