using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for WindowsVersionInfoTest and is intended
    ///to contain all WindowsVersionInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WindowsVersionInfoTest
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
        ///A test for IsCurrentProcess32Bit
        ///</summary>
        [TestMethod()]
        public void IsCurrentProcess32BitTest()
        {
            bool actual;
            actual = WindowsVersionInfo.IsCurrentProcess32Bit;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsCurrentProcess64Bit
        ///</summary>
        [TestMethod()]
        public void IsCurrentProcess64BitTest()
        {
            bool actual;
            actual = WindowsVersionInfo.IsCurrentProcess64Bit;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOS32Bit
        ///</summary>
        [TestMethod()]
        public void IsOS32BitTest()
        {
            bool actual;
            actual = WindowsVersionInfo.IsOS32Bit;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOS64Bit
        ///</summary>
        [TestMethod()]
        public void IsOS64BitTest()
        {
            bool actual;
            actual = WindowsVersionInfo.IsOS64Bit;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsVistaOrBeyond
        ///</summary>
        [TestMethod()]
        public void IsVistaOrBeyondTest()
        {
            bool actual;
            actual = WindowsVersionInfo.IsVistaOrBeyond;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
