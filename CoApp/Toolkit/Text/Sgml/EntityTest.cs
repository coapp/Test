using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for EntityTest and is intended
    ///to contain all EntityTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EntityTest
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
        ///A test for Entity Constructor
        ///</summary>
        [TestMethod()]
        public void EntityConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Uri baseUri = null; // TODO: Initialize to an appropriate value
            TextReader stm = null; // TODO: Initialize to an appropriate value
            string proxy = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, baseUri, stm, proxy);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Entity Constructor
        ///</summary>
        [TestMethod()]
        public void EntityConstructorTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Entity Constructor
        ///</summary>
        [TestMethod()]
        public void EntityConstructorTest2()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string pubid = string.Empty; // TODO: Initialize to an appropriate value
            string uri = string.Empty; // TODO: Initialize to an appropriate value
            string proxy = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, pubid, uri, proxy);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Close
        ///</summary>
        [TestMethod()]
        public void CloseTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            target.Close();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Context
        ///</summary>
        [TestMethod()]
        public void ContextTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Context();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string msg = string.Empty; // TODO: Initialize to an appropriate value
            target.Error(msg);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string msg = string.Empty; // TODO: Initialize to an appropriate value
            char ch = '\0'; // TODO: Initialize to an appropriate value
            target.Error(msg, ch);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest2()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string msg = string.Empty; // TODO: Initialize to an appropriate value
            int x = 0; // TODO: Initialize to an appropriate value
            target.Error(msg, x);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest3()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string msg = string.Empty; // TODO: Initialize to an appropriate value
            string arg = string.Empty; // TODO: Initialize to an appropriate value
            target.Error(msg, arg);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExpandCharEntity
        ///</summary>
        [TestMethod()]
        public void ExpandCharEntityTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ExpandCharEntity();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsLiteralType
        ///</summary>
        [TestMethod()]
        public void IsLiteralTypeTest()
        {
            string token = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Entity.IsLiteralType(token);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            Entity parent = null; // TODO: Initialize to an appropriate value
            Uri baseUri = null; // TODO: Initialize to an appropriate value
            target.Open(parent, baseUri);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ReadChar
        ///</summary>
        [TestMethod()]
        public void ReadCharTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            char expected = '\0'; // TODO: Initialize to an appropriate value
            char actual;
            actual = target.ReadChar();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScanLiteral
        ///</summary>
        [TestMethod()]
        public void ScanLiteralTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            StringBuilder sb = null; // TODO: Initialize to an appropriate value
            char quote = '\0'; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanLiteral(sb, quote);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScanToEnd
        ///</summary>
        [TestMethod()]
        public void ScanToEndTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            StringBuilder sb = null; // TODO: Initialize to an appropriate value
            string type = string.Empty; // TODO: Initialize to an appropriate value
            string terminators = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanToEnd(sb, type, terminators);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScanToken
        ///</summary>
        [TestMethod()]
        public void ScanTokenTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            StringBuilder sb = null; // TODO: Initialize to an appropriate value
            string term = string.Empty; // TODO: Initialize to an appropriate value
            bool nmtoken = false; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanToken(sb, term, nmtoken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetLiteralType
        ///</summary>
        [TestMethod()]
        public void SetLiteralTypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            target.SetLiteralType(token);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SkipWhitespace
        ///</summary>
        [TestMethod()]
        public void SkipWhitespaceTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            char expected = '\0'; // TODO: Initialize to an appropriate value
            char actual;
            actual = target.SkipWhitespace();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Encoding
        ///</summary>
        [TestMethod()]
        public void EncodingTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            Encoding actual;
            actual = target.Encoding;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsHtml
        ///</summary>
        [TestMethod()]
        public void IsHtmlTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsHtml = expected;
            actual = target.IsHtml;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsInternal
        ///</summary>
        [TestMethod()]
        public void IsInternalTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsInternal;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsWhitespace
        ///</summary>
        [TestMethod()]
        public void IsWhitespaceTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsWhitespace;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Lastchar
        ///</summary>
        [TestMethod()]
        public void LastcharTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            char actual;
            actual = target.Lastchar;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Line
        ///</summary>
        [TestMethod()]
        public void LineTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Line;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LinePosition
        ///</summary>
        [TestMethod()]
        public void LinePositionTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.LinePosition;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Literal
        ///</summary>
        [TestMethod()]
        public void LiteralTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Literal;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LiteralType
        ///</summary>
        [TestMethod()]
        public void LiteralTypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            LiteralType actual;
            actual = target.LiteralType;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Parent
        ///</summary>
        [TestMethod()]
        public void ParentTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            Entity actual;
            actual = target.Parent;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Proxy
        ///</summary>
        [TestMethod()]
        public void ProxyTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Proxy;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PublicId
        ///</summary>
        [TestMethod()]
        public void PublicIdTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.PublicId;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResolvedUri
        ///</summary>
        [TestMethod()]
        public void ResolvedUriTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            Uri actual;
            actual = target.ResolvedUri;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Uri
        ///</summary>
        [TestMethod()]
        public void UriTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string literal = string.Empty; // TODO: Initialize to an appropriate value
            Entity target = new Entity(name, literal); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Uri;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
