using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for FileSystemTest and is intended
    ///to contain all FileSystemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FileSystemTest
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
        ///A test for AlternateDataStreamExists
        ///</summary>
        [TestMethod()]
        public void AlternateDataStreamExistsTest()
        {
            FileSystemInfo file = null; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FileSystem.AlternateDataStreamExists(file, streamName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AlternateDataStreamExists
        ///</summary>
        [TestMethod()]
        public void AlternateDataStreamExistsTest1()
        {
            string filePath = string.Empty; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FileSystem.AlternateDataStreamExists(filePath, streamName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteAlternateDataStream
        ///</summary>
        [TestMethod()]
        public void DeleteAlternateDataStreamTest()
        {
            string filePath = string.Empty; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FileSystem.DeleteAlternateDataStream(filePath, streamName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteAlternateDataStream
        ///</summary>
        [TestMethod()]
        public void DeleteAlternateDataStreamTest1()
        {
            FileSystemInfo file = null; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FileSystem.DeleteAlternateDataStream(file, streamName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAlternateDataStream
        ///</summary>
        [TestMethod()]
        public void GetAlternateDataStreamTest()
        {
            FileSystemInfo file = null; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo expected = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo actual;
            actual = FileSystem.GetAlternateDataStream(file, streamName, mode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAlternateDataStream
        ///</summary>
        [TestMethod()]
        public void GetAlternateDataStreamTest1()
        {
            string filePath = string.Empty; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo expected = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo actual;
            actual = FileSystem.GetAlternateDataStream(filePath, streamName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAlternateDataStream
        ///</summary>
        [TestMethod()]
        public void GetAlternateDataStreamTest2()
        {
            string filePath = string.Empty; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo expected = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo actual;
            actual = FileSystem.GetAlternateDataStream(filePath, streamName, mode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAlternateDataStream
        ///</summary>
        [TestMethod()]
        public void GetAlternateDataStreamTest3()
        {
            FileSystemInfo file = null; // TODO: Initialize to an appropriate value
            string streamName = string.Empty; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo expected = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo actual;
            actual = FileSystem.GetAlternateDataStream(file, streamName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListAlternateDataStreams
        ///</summary>
        [TestMethod()]
        public void ListAlternateDataStreamsTest()
        {
            string filePath = string.Empty; // TODO: Initialize to an appropriate value
            IList<AlternateDataStreamInfo> expected = null; // TODO: Initialize to an appropriate value
            IList<AlternateDataStreamInfo> actual;
            actual = FileSystem.ListAlternateDataStreams(filePath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListAlternateDataStreams
        ///</summary>
        [TestMethod()]
        public void ListAlternateDataStreamsTest1()
        {
            FileSystemInfo file = null; // TODO: Initialize to an appropriate value
            IList<AlternateDataStreamInfo> expected = null; // TODO: Initialize to an appropriate value
            IList<AlternateDataStreamInfo> actual;
            actual = FileSystem.ListAlternateDataStreams(file);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
