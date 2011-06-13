using CoApp.Toolkit.Shell;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Shell
{
    
    
    /// <summary>
    ///This is a test class for IconLocationTest and is intended
    ///to contain all IconLocationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IconLocationTest
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
        ///A test for IconLocation Constructor
        ///</summary>
        [TestMethod()]
        public void IconLocationConstructorTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            IconLocation target = new IconLocation(path, index);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for IconLocation Constructor
        ///</summary>
        [TestMethod()]
        public void IconLocationConstructorTest1()
        {
            IconLocation target = new IconLocation();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        [TestMethod()]
        public void IndexTest()
        {
            IconLocation target = new IconLocation(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Index;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        [TestMethod()]
        public void IsEmptyTest()
        {
            IconLocation target = new IconLocation(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Path
        ///</summary>
        [TestMethod()]
        public void PathTest()
        {
            IconLocation target = new IconLocation(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Path;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
