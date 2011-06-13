using CoApp.Toolkit.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Exceptions
{
    
    
    /// <summary>
    ///This is a test class for EndUserExceptionTest and is intended
    ///to contain all EndUserExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EndUserExceptionTest
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
        ///A test for EndUserException Constructor
        ///</summary>
        [TestMethod()]
        public void EndUserExceptionConstructorTest()
        {
            string errorcode = string.Empty; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            object[] parameters = null; // TODO: Initialize to an appropriate value
            EndUserException target = new EndUserException(errorcode, message, parameters);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for EndUserException Constructor
        ///</summary>
        [TestMethod()]
        public void EndUserExceptionConstructorTest1()
        {
            string SourceFile = string.Empty; // TODO: Initialize to an appropriate value
            int SourceRow = 0; // TODO: Initialize to an appropriate value
            int SourceColumn = 0; // TODO: Initialize to an appropriate value
            string errorcode = string.Empty; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            object[] parameters = null; // TODO: Initialize to an appropriate value
            EndUserException target = new EndUserException(SourceFile, SourceRow, SourceColumn, errorcode, message, parameters);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
