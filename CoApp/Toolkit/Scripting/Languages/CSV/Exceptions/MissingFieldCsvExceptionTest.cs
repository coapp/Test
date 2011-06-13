using CoApp.Toolkit.Scripting.Languages.CSV.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSV.Exceptions
{
    
    
    /// <summary>
    ///This is a test class for MissingFieldCsvExceptionTest and is intended
    ///to contain all MissingFieldCsvExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MissingFieldCsvExceptionTest
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
        ///A test for MissingFieldCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MissingFieldCsvExceptionConstructorTest()
        {
            string rawData = string.Empty; // TODO: Initialize to an appropriate value
            int currentPosition = 0; // TODO: Initialize to an appropriate value
            long currentRecordIndex = 0; // TODO: Initialize to an appropriate value
            int currentFieldIndex = 0; // TODO: Initialize to an appropriate value
            MissingFieldCsvException target = new MissingFieldCsvException(rawData, currentPosition, currentRecordIndex, currentFieldIndex);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MissingFieldCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MissingFieldCsvExceptionConstructorTest1()
        {
            string rawData = string.Empty; // TODO: Initialize to an appropriate value
            int currentPosition = 0; // TODO: Initialize to an appropriate value
            long currentRecordIndex = 0; // TODO: Initialize to an appropriate value
            int currentFieldIndex = 0; // TODO: Initialize to an appropriate value
            Exception innerException = null; // TODO: Initialize to an appropriate value
            MissingFieldCsvException target = new MissingFieldCsvException(rawData, currentPosition, currentRecordIndex, currentFieldIndex, innerException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MissingFieldCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MissingFieldCsvExceptionConstructorTest2()
        {
            MissingFieldCsvException target = new MissingFieldCsvException();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MissingFieldCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MissingFieldCsvExceptionConstructorTest3()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            MissingFieldCsvException target = new MissingFieldCsvException(message);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MissingFieldCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MissingFieldCsvExceptionConstructorTest4()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            Exception innerException = null; // TODO: Initialize to an appropriate value
            MissingFieldCsvException target = new MissingFieldCsvException(message, innerException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
