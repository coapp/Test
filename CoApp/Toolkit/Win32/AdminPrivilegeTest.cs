using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for AdminPrivilegeTest and is intended
    ///to contain all AdminPrivilegeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AdminPrivilegeTest
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
        ///A test for AdminPrivilege Constructor
        ///</summary>
        [TestMethod()]
        public void AdminPrivilegeConstructorTest()
        {
            AdminPrivilege target = new AdminPrivilege();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetProcessIntegrityLevel
        ///</summary>
        [TestMethod()]
        public void GetProcessIntegrityLevelTest()
        {
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = AdminPrivilege.GetProcessIntegrityLevel();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsProcessElevated
        ///</summary>
        [TestMethod()]
        public void IsProcessElevatedTest()
        {
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = AdminPrivilege.IsProcessElevated();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsUserInAdminGroup
        ///</summary>
        [TestMethod()]
        public void IsUserInAdminGroupTest()
        {
            /*
            for (int i = 0; i < 2; i++)
            {
                bool actual;
                if (i == 0)
                {
                    actual = AdminPrivilege.IsUserInAdminGroup();
                    Assert.IsTrue(actual,
                                  "Running user was determined to NOT be in the Administrators group.  Ignore if this is correct.");
                }
                else
                {
                    IPrincipal old = System.Threading.Thread.CurrentPrincipal;
                    WindowsPrincipal P = new WindowsPrincipal(WindowsIdentity.GetAnonymous());
                    System.Threading.Thread.CurrentPrincipal = P;
                    actual = AdminPrivilege.IsUserInAdminGroup();
                    System.Threading.Thread.CurrentPrincipal = old;
                    Assert.IsFalse(actual, "Anonymous user was determined to be in the Administrators group.");
                }
            }
            */
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = AdminPrivilege.IsUserInAdminGroup();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsRunAsAdmin
        ///</summary>
        [TestMethod()]
        public void IsRunAsAdminTest()
        {
            bool actual;
            actual = AdminPrivilege.IsRunAsAdmin;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
