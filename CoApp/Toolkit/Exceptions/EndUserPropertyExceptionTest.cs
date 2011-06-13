using CoApp.Toolkit.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;

namespace Test.CoApp.Toolkit.Exceptions
{
    
    
    /// <summary>
    ///This is a test class for EndUserPropertyExceptionTest and is intended
    ///to contain all EndUserPropertyExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EndUserPropertyExceptionTest
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
        ///A test for EndUserPropertyException Constructor
        ///</summary>
        [TestMethod()]
        public void EndUserPropertyExceptionConstructorTest()
        {
            RuleProperty property = null; // TODO: Initialize to an appropriate value
            string errorcode = string.Empty; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            object[] parameters = null; // TODO: Initialize to an appropriate value
            EndUserPropertyException target = new EndUserPropertyException(property, errorcode, message, parameters);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
