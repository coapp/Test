using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for CookieExtensionsTest and is intended
    ///to contain all CookieExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CookieExtensionsTest
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
        ///A test for AddCookie
        ///</summary>
        [TestMethod()]
        public void AddCookieTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            Cookie cookie = null; // TODO: Initialize to an appropriate value
            CookieExtensions.AddCookie(cookieList, cookie);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddCookie
        ///</summary>
        [TestMethod()]
        public void AddCookieTest1()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            string setCookieFormat = string.Empty; // TODO: Initialize to an appropriate value
            CookieExtensions.AddCookie(cookieList, setCookieFormat);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddCookies
        ///</summary>
        [TestMethod()]
        public void AddCookiesTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            CookieCollection cookies = null; // TODO: Initialize to an appropriate value
            CookieExtensions.AddCookies(cookieList, cookies);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AppendEncodedCookie
        ///</summary>
        [TestMethod()]
        public void AppendEncodedCookieTest()
        {
            StringBuilder stringBuilder = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            CookieExtensions.AppendEncodedCookie(stringBuilder, name, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            Cookie cookie = null; // TODO: Initialize to an appropriate value
            Cookie expected = null; // TODO: Initialize to an appropriate value
            Cookie actual;
            actual = CookieExtensions.Clone(cookie);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest1()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            List<Cookie> expected = null; // TODO: Initialize to an appropriate value
            List<Cookie> actual;
            actual = CookieExtensions.Clone(cookieList);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpireCookies
        ///</summary>
        [TestMethod()]
        public void ExpireCookiesTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            CookieExtensions.ExpireCookies(cookieList);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetCookieContainer
        ///</summary>
        [TestMethod()]
        public void GetCookieContainerTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            CookieContainer expected = null; // TODO: Initialize to an appropriate value
            CookieContainer actual;
            actual = CookieExtensions.GetCookieContainer(cookieList);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetEncodedCookies
        ///</summary>
        [TestMethod()]
        public void GetEncodedCookiesTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CookieExtensions.GetEncodedCookies(cookieList);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LoadCookiesFromIEFile
        ///</summary>
        [TestMethod()]
        public void LoadCookiesFromIEFileTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            CookieExtensions.LoadCookiesFromIEFile(cookieList, filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadCookiesFromNSFile
        ///</summary>
        [TestMethod()]
        public void LoadCookiesFromNSFileTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            CookieExtensions.LoadCookiesFromNSFile(cookieList, filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveCookiesToIEFilestring
        ///</summary>
        [TestMethod()]
        public void SaveCookiesToIEFilestringTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            CookieExtensions.SaveCookiesToIEFilestring(cookieList, filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveCookiesToNSFile
        ///</summary>
        [TestMethod()]
        public void SaveCookiesToNSFileTest()
        {
            List<Cookie> cookieList = null; // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            CookieExtensions.SaveCookiesToNSFile(cookieList, filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
