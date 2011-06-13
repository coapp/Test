using CoApp.Toolkit.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using System.Collections.Specialized;

namespace Test.CoApp.Toolkit.Text
{
    
    
    /// <summary>
    ///This is a test class for HttpUtilityTest and is intended
    ///to contain all HttpUtilityTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HttpUtilityTest
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
        ///A test for HttpUtility Constructor
        ///</summary>
        [TestMethod()]
        public void HttpUtilityConstructorTest()
        {
            HttpUtility target = new HttpUtility();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for HtmlAttributeEncode
        ///</summary>
        [TestMethod()]
        public void HtmlAttributeEncodeTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.HtmlAttributeEncode(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HtmlAttributeEncode
        ///</summary>
        [TestMethod()]
        public void HtmlAttributeEncodeTest1()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            TextWriter output = null; // TODO: Initialize to an appropriate value
            HttpUtility.HtmlAttributeEncode(s, output);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for HtmlDecode
        ///</summary>
        [TestMethod()]
        public void HtmlDecodeTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            TextWriter output = null; // TODO: Initialize to an appropriate value
            HttpUtility.HtmlDecode(s, output);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for HtmlDecode
        ///</summary>
        [TestMethod()]
        public void HtmlDecodeTest1()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.HtmlDecode(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HtmlEncode
        ///</summary>
        [TestMethod()]
        public void HtmlEncodeTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            TextWriter output = null; // TODO: Initialize to an appropriate value
            HttpUtility.HtmlEncode(s, output);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for HtmlEncode
        ///</summary>
        [TestMethod()]
        public void HtmlEncodeTest1()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.HtmlEncode(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParseQueryString
        ///</summary>
        [TestMethod()]
        public void ParseQueryStringTest()
        {
            string query = string.Empty; // TODO: Initialize to an appropriate value
            Encoding encoding = null; // TODO: Initialize to an appropriate value
            NameValueCollection expected = null; // TODO: Initialize to an appropriate value
            NameValueCollection actual;
            actual = HttpUtility.ParseQueryString(query, encoding);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParseQueryString
        ///</summary>
        [TestMethod()]
        public void ParseQueryStringTest1()
        {
            string query = string.Empty; // TODO: Initialize to an appropriate value
            NameValueCollection expected = null; // TODO: Initialize to an appropriate value
            NameValueCollection actual;
            actual = HttpUtility.ParseQueryString(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecode
        ///</summary>
        [TestMethod()]
        public void UrlDecodeTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlDecode(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecode
        ///</summary>
        [TestMethod()]
        public void UrlDecodeTest1()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            Encoding e = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlDecode(s, e);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecode
        ///</summary>
        [TestMethod()]
        public void UrlDecodeTest2()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            int offset = 0; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            Encoding e = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlDecode(bytes, offset, count, e);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecode
        ///</summary>
        [TestMethod()]
        public void UrlDecodeTest3()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            Encoding e = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlDecode(bytes, e);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlDecodeToBytesTest()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlDecodeToBytes(bytes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlDecodeToBytesTest1()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            int offset = 0; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlDecodeToBytes(bytes, offset, count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlDecodeToBytesTest2()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            Encoding e = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlDecodeToBytes(str, e);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlDecodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlDecodeToBytesTest3()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlDecodeToBytes(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncode
        ///</summary>
        [TestMethod()]
        public void UrlEncodeTest()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlEncode(bytes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncode
        ///</summary>
        [TestMethod()]
        public void UrlEncodeTest1()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            Encoding Enc = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlEncode(s, Enc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncode
        ///</summary>
        [TestMethod()]
        public void UrlEncodeTest2()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            int offset = 0; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlEncode(bytes, offset, count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncode
        ///</summary>
        [TestMethod()]
        public void UrlEncodeTest3()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlEncode(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlEncodeToBytesTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlEncodeToBytes(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlEncodeToBytesTest1()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            int offset = 0; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlEncodeToBytes(bytes, offset, count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlEncodeToBytesTest2()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlEncodeToBytes(bytes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlEncodeToBytesTest3()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            Encoding e = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlEncodeToBytes(str, e);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncodeUnicode
        ///</summary>
        [TestMethod()]
        public void UrlEncodeUnicodeTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlEncodeUnicode(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncodeUnicodeToBytes
        ///</summary>
        [TestMethod()]
        public void UrlEncodeUnicodeToBytesTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HttpUtility.UrlEncodeUnicodeToBytes(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlPathEncode
        ///</summary>
        [TestMethod()]
        public void UrlPathEncodeTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HttpUtility.UrlPathEncode(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
