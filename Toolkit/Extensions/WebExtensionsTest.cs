using global::CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for WebExtensionsTest and is intended
    ///to contain all WebExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WebExtensionsTest
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
        ///A test for AddBasicAuthCredentials
        ///</summary>
        [TestMethod()]
        public void AddBasicAuthCredentialsTest()
        {
            WebRequest obj = null; // TODO: Initialize to an appropriate value
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            WebExtensions.AddBasicAuthCredentials(obj, url, username, password);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AppendFormData
        ///</summary>
        [TestMethod()]
        public void AppendFormDataTest()
        {
            StringBuilder stringBuilder = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            WebExtensions.AppendFormData(stringBuilder, name, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CanonicalizeUri
        ///</summary>
        [TestMethod()]
        public void CanonicalizeUriTest()
        {
            string uri = string.Empty; // TODO: Initialize to an appropriate value
            Uri expected = null; // TODO: Initialize to an appropriate value
            Uri actual;
            actual = WebExtensions.CanonicalizeUri(uri);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContentDispositionFilename
        ///</summary>
        [TestMethod()]
        public void ContentDispositionFilenameTest()
        {
            HttpWebResponse httpWebResponse = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = WebExtensions.ContentDispositionFilename(httpWebResponse);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = WebExtensions.Get(url, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest1()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = WebExtensions.Get(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBinary
        ///</summary>
        [TestMethod()]
        public void GetBinaryTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = WebExtensions.GetBinary(url, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBinaryFile
        ///</summary>
        [TestMethod()]
        public void GetBinaryFileTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string outputFilename = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = WebExtensions.GetBinaryFile(url, outputFilename, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFormData
        ///</summary>
        [TestMethod()]
        public void GetFormDataTest()
        {
            Dictionary<string, string> data = null; // TODO: Initialize to an appropriate value
            StringBuilder expected = null; // TODO: Initialize to an appropriate value
            StringBuilder actual;
            actual = WebExtensions.GetFormData(data);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsHttpScheme
        ///</summary>
        [TestMethod()]
        public void IsHttpSchemeTest()
        {
            Uri uri = null; // TODO: Initialize to an appropriate value
            bool acceptHttps = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = WebExtensions.IsHttpScheme(uri, acceptHttps);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeAbsolute
        ///</summary>
        [TestMethod()]
        public void MakeAbsoluteTest()
        {
            Uri baseUri = null; // TODO: Initialize to an appropriate value
            string relativeUrl = string.Empty; // TODO: Initialize to an appropriate value
            Uri expected = null; // TODO: Initialize to an appropriate value
            Uri actual;
            actual = WebExtensions.MakeAbsolute(baseUri, relativeUrl);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Post
        ///</summary>
        [TestMethod()]
        public void PostTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            Dictionary<string, string> args = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = WebExtensions.Post(url, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PostBinary
        ///</summary>
        [TestMethod()]
        public void PostBinaryTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            Dictionary<string, string> args = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = WebExtensions.PostBinary(url, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PostBinaryFile
        ///</summary>
        [TestMethod()]
        public void PostBinaryFileTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string outputFilename = string.Empty; // TODO: Initialize to an appropriate value
            Dictionary<string, string> args = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = WebExtensions.PostBinaryFile(url, outputFilename, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Service
        ///</summary>
        [TestMethod()]
        public void ServiceTest()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            RequestType requestType = new RequestType(); // TODO: Initialize to an appropriate value
            ResponseType responseType = new ResponseType(); // TODO: Initialize to an appropriate value
            int resultCode = 0; // TODO: Initialize to an appropriate value
            int resultCodeExpected = 0; // TODO: Initialize to an appropriate value
            string outputFilename = string.Empty; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = WebExtensions.Service(url, requestType, responseType, out resultCode, outputFilename);
            Assert.AreEqual(resultCodeExpected, resultCode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Service
        ///</summary>
        [TestMethod()]
        public void ServiceTest1()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            RequestType requestType = new RequestType(); // TODO: Initialize to an appropriate value
            ResponseType responseType = new ResponseType(); // TODO: Initialize to an appropriate value
            int resultCode = 0; // TODO: Initialize to an appropriate value
            int resultCodeExpected = 0; // TODO: Initialize to an appropriate value
            string outputFilename = string.Empty; // TODO: Initialize to an appropriate value
            Dictionary<string, string> formData = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = WebExtensions.Service(url, requestType, responseType, out resultCode, outputFilename, formData);
            Assert.AreEqual(resultCodeExpected, resultCode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Service
        ///</summary>
        [TestMethod()]
        public void ServiceTest2()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            RequestType requestType = new RequestType(); // TODO: Initialize to an appropriate value
            ResponseType responseType = new ResponseType(); // TODO: Initialize to an appropriate value
            int resultCode = 0; // TODO: Initialize to an appropriate value
            int resultCodeExpected = 0; // TODO: Initialize to an appropriate value
            Dictionary<string, string> formData = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = WebExtensions.Service(url, requestType, responseType, out resultCode, formData);
            Assert.AreEqual(resultCodeExpected, resultCode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Service
        ///</summary>
        [TestMethod()]
        public void ServiceTest3()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            RequestType requestType = new RequestType(); // TODO: Initialize to an appropriate value
            ResponseType responseType = new ResponseType(); // TODO: Initialize to an appropriate value
            int resultCode = 0; // TODO: Initialize to an appropriate value
            int resultCodeExpected = 0; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = WebExtensions.Service(url, requestType, responseType, out resultCode);
            Assert.AreEqual(resultCodeExpected, resultCode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
