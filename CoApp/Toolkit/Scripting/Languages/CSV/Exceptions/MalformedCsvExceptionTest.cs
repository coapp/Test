using CoApp.Toolkit.Scripting.Languages.CSV.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSV.Exceptions
{
    
    
    /// <summary>
    ///This is a test class for MalformedCsvExceptionTest and is intended
    ///to contain all MalformedCsvExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MalformedCsvExceptionTest
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
        ///A test for MalformedCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MalformedCsvExceptionConstructorTest()
        {
            string rawData = string.Empty; // TODO: Initialize to an appropriate value
            int currentPosition = 0; // TODO: Initialize to an appropriate value
            long currentRecordIndex = 0; // TODO: Initialize to an appropriate value
            int currentFieldIndex = 0; // TODO: Initialize to an appropriate value
            MalformedCsvException target = new MalformedCsvException(rawData, currentPosition, currentRecordIndex, currentFieldIndex);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MalformedCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MalformedCsvExceptionConstructorTest1()
        {
            string rawData = string.Empty; // TODO: Initialize to an appropriate value
            int currentPosition = 0; // TODO: Initialize to an appropriate value
            long currentRecordIndex = 0; // TODO: Initialize to an appropriate value
            int currentFieldIndex = 0; // TODO: Initialize to an appropriate value
            Exception innerException = null; // TODO: Initialize to an appropriate value
            MalformedCsvException target = new MalformedCsvException(rawData, currentPosition, currentRecordIndex, currentFieldIndex, innerException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MalformedCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MalformedCsvExceptionConstructorTest2()
        {
            MalformedCsvException target = new MalformedCsvException();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MalformedCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MalformedCsvExceptionConstructorTest3()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            MalformedCsvException target = new MalformedCsvException(message);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MalformedCsvException Constructor
        ///</summary>
        [TestMethod()]
        public void MalformedCsvExceptionConstructorTest4()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            Exception innerException = null; // TODO: Initialize to an appropriate value
            MalformedCsvException target = new MalformedCsvException(message, innerException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetObjectData
        ///</summary>
        [TestMethod()]
        public void GetObjectDataTest()
        {
            MalformedCsvException target = new MalformedCsvException(); // TODO: Initialize to an appropriate value
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            target.GetObjectData(info, context);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CurrentFieldIndex
        ///</summary>
        [TestMethod()]
        public void CurrentFieldIndexTest()
        {
            MalformedCsvException target = new MalformedCsvException(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CurrentFieldIndex;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentPosition
        ///</summary>
        [TestMethod()]
        public void CurrentPositionTest()
        {
            MalformedCsvException target = new MalformedCsvException(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CurrentPosition;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentRecordIndex
        ///</summary>
        [TestMethod()]
        public void CurrentRecordIndexTest()
        {
            MalformedCsvException target = new MalformedCsvException(); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.CurrentRecordIndex;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Message
        ///</summary>
        [TestMethod()]
        public void MessageTest()
        {
            MalformedCsvException target = new MalformedCsvException(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Message;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RawData
        ///</summary>
        [TestMethod()]
        public void RawDataTest()
        {
            MalformedCsvException target = new MalformedCsvException(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.RawData;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
