using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for Advapi32Test and is intended
    ///to contain all Advapi32Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Advapi32Test
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
        ///A test for DuplicateToken
        ///</summary>
        [TestMethod()]
        public void DuplicateTokenTest()
        {
            SafeTokenHandle ExistingTokenHandle = null; // TODO: Initialize to an appropriate value
            SecurityImpersonationLevel ImpersonationLevel = new SecurityImpersonationLevel(); // TODO: Initialize to an appropriate value
            SafeTokenHandle DuplicateTokenHandle = null; // TODO: Initialize to an appropriate value
            SafeTokenHandle DuplicateTokenHandleExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Advapi32.DuplicateToken(ExistingTokenHandle, ImpersonationLevel, out DuplicateTokenHandle);
            Assert.AreEqual(DuplicateTokenHandleExpected, DuplicateTokenHandle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSidSubAuthority
        ///</summary>
        [TestMethod()]
        public void GetSidSubAuthorityTest()
        {
            IntPtr pSid = new IntPtr(); // TODO: Initialize to an appropriate value
            uint nSubAuthority = 0; // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = Advapi32.GetSidSubAuthority(pSid, nSubAuthority);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTokenInformation
        ///</summary>
        [TestMethod()]
        public void GetTokenInformationTest()
        {
            SafeTokenHandle hToken = null; // TODO: Initialize to an appropriate value
            TokenInformationClass tokenInfoClass = new TokenInformationClass(); // TODO: Initialize to an appropriate value
            IntPtr pTokenInfo = new IntPtr(); // TODO: Initialize to an appropriate value
            int tokenInfoLength = 0; // TODO: Initialize to an appropriate value
            int returnLength = 0; // TODO: Initialize to an appropriate value
            int returnLengthExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Advapi32.GetTokenInformation(hToken, tokenInfoClass, pTokenInfo, tokenInfoLength, out returnLength);
            Assert.AreEqual(returnLengthExpected, returnLength);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OpenProcessToken
        ///</summary>
        [TestMethod()]
        public void OpenProcessTokenTest()
        {
            IntPtr hProcess = new IntPtr(); // TODO: Initialize to an appropriate value
            uint desiredAccess = 0; // TODO: Initialize to an appropriate value
            SafeTokenHandle hToken = null; // TODO: Initialize to an appropriate value
            SafeTokenHandle hTokenExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Advapi32.OpenProcessToken(hProcess, desiredAccess, out hToken);
            Assert.AreEqual(hTokenExpected, hToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
