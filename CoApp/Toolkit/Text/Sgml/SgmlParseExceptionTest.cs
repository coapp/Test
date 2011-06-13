using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for SgmlParseExceptionTest and is intended
    ///to contain all SgmlParseExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SgmlParseExceptionTest
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
        ///A test for SgmlParseException Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlParseExceptionConstructorTest()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            Exception innerException = null; // TODO: Initialize to an appropriate value
            SgmlParseException target = new SgmlParseException(message, innerException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SgmlParseException Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlParseExceptionConstructorTest1()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            Entity e = null; // TODO: Initialize to an appropriate value
            SgmlParseException target = new SgmlParseException(message, e);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SgmlParseException Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlParseExceptionConstructorTest2()
        {
            SgmlParseException target = new SgmlParseException();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SgmlParseException Constructor
        ///</summary>
        [TestMethod()]
        public void SgmlParseExceptionConstructorTest3()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            SgmlParseException target = new SgmlParseException(message);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetObjectData
        ///</summary>
        [TestMethod()]
        public void GetObjectDataTest()
        {
            SgmlParseException target = new SgmlParseException(); // TODO: Initialize to an appropriate value
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            target.GetObjectData(info, context);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for EntityContext
        ///</summary>
        [TestMethod()]
        public void EntityContextTest()
        {
            SgmlParseException target = new SgmlParseException(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.EntityContext;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
