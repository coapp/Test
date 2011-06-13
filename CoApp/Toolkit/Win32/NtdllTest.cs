using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for NtdllTest and is intended
    ///to contain all NtdllTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NtdllTest
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
        ///A test for RtlAcquirePrivilege
        ///</summary>
        [TestMethod()]
        public void RtlAcquirePrivilegeTest()
        {
            uint Privilege = 0; // TODO: Initialize to an appropriate value
            uint PrivilegeExpected = 0; // TODO: Initialize to an appropriate value
            uint NumPriv = 0; // TODO: Initialize to an appropriate value
            uint Flags = 0; // TODO: Initialize to an appropriate value
            IntPtr ReturnedState = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr ReturnedStateExpected = new IntPtr(); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            actual = Ntdll.RtlAcquirePrivilege(ref Privilege, NumPriv, Flags, ref ReturnedState);
            Assert.AreEqual(PrivilegeExpected, Privilege);
            Assert.AreEqual(ReturnedStateExpected, ReturnedState);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RtlReleasePrivilege
        ///</summary>
        [TestMethod()]
        public void RtlReleasePrivilegeTest()
        {
            IntPtr ReturnedState = new IntPtr(); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            actual = Ntdll.RtlReleasePrivilege(ReturnedState);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
