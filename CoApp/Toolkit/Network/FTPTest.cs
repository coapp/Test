using CoApp.Toolkit.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace Test.CoApp.Toolkit.Network
{
    
    
    /// <summary>
    ///This is a test class for FTPTest and is intended
    ///to contain all FTPTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FTPTest
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
        ///A test for FTP Constructor
        ///</summary>
        [TestMethod()]
        public void FTPConstructorTest()
        {
            FTP target = new FTP();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ChangeDir
        ///</summary>
        [TestMethod()]
        public void ChangeDirTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.ChangeDir(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ChangeDirMakeIfNeccesary
        ///</summary>
        [TestMethod()]
        public void ChangeDirMakeIfNeccesaryTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.ChangeDirMakeIfNeccesary(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Connect
        ///</summary>
        [TestMethod()]
        public void ConnectTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            target.Connect();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Disconnect
        ///</summary>
        [TestMethod()]
        public void DisconnectTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            target.Disconnect();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DoDownload
        ///</summary>
        [TestMethod()]
        public void DoDownloadTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = target.DoDownload();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DoUpload
        ///</summary>
        [TestMethod()]
        public void DoUploadTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = target.DoUpload();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DoUploadUntilComplete
        ///</summary>
        [TestMethod()]
        public void DoUploadUntilCompleteTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = target.DoUploadUntilComplete();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileDate
        ///</summary>
        [TestMethod()]
        public void GetFileDateTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string fileName = string.Empty; // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.GetFileDate(fileName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileDateRaw
        ///</summary>
        [TestMethod()]
        public void GetFileDateRawTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string fileName = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetFileDateRaw(fileName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileSize
        ///</summary>
        [TestMethod()]
        public void GetFileSizeTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = target.GetFileSize(filename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWorkingDirectory
        ///</summary>
        [TestMethod()]
        public void GetWorkingDirectoryTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetWorkingDirectory();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for List
        ///</summary>
        [TestMethod()]
        public void ListTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.List();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListDirectories
        ///</summary>
        [TestMethod()]
        public void ListDirectoriesTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.ListDirectories();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListFiles
        ///</summary>
        [TestMethod()]
        public void ListFilesTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.ListFiles();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeDir
        ///</summary>
        [TestMethod()]
        public void MakeDirTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string dir = string.Empty; // TODO: Initialize to an appropriate value
            target.MakeDir(dir);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenDownload
        ///</summary>
        [TestMethod()]
        public void OpenDownloadTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            string localfilename = string.Empty; // TODO: Initialize to an appropriate value
            target.OpenDownload(filename, localfilename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenDownload
        ///</summary>
        [TestMethod()]
        public void OpenDownloadTest1()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            bool resume = false; // TODO: Initialize to an appropriate value
            target.OpenDownload(filename, resume);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenDownload
        ///</summary>
        [TestMethod()]
        public void OpenDownloadTest2()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string remote_filename = string.Empty; // TODO: Initialize to an appropriate value
            string local_filename = string.Empty; // TODO: Initialize to an appropriate value
            bool resume = false; // TODO: Initialize to an appropriate value
            target.OpenDownload(remote_filename, local_filename, resume);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenDownload
        ///</summary>
        [TestMethod()]
        public void OpenDownloadTest3()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            target.OpenDownload(filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenUpload
        ///</summary>
        [TestMethod()]
        public void OpenUploadTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            string remote_filename = string.Empty; // TODO: Initialize to an appropriate value
            bool resume = false; // TODO: Initialize to an appropriate value
            target.OpenUpload(filename, remote_filename, resume);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenUpload
        ///</summary>
        [TestMethod()]
        public void OpenUploadTest1()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            Stream fileToUpload = null; // TODO: Initialize to an appropriate value
            long length = 0; // TODO: Initialize to an appropriate value
            string remote_filename = string.Empty; // TODO: Initialize to an appropriate value
            bool resume = false; // TODO: Initialize to an appropriate value
            target.OpenUpload(fileToUpload, length, remote_filename, resume);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenUpload
        ///</summary>
        [TestMethod()]
        public void OpenUploadTest2()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            target.OpenUpload(filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenUpload
        ///</summary>
        [TestMethod()]
        public void OpenUploadTest3()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            string remotefilename = string.Empty; // TODO: Initialize to an appropriate value
            target.OpenUpload(filename, remotefilename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OpenUpload
        ///</summary>
        [TestMethod()]
        public void OpenUploadTest4()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            bool resume = false; // TODO: Initialize to an appropriate value
            target.OpenUpload(filename, resume);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RemoveDir
        ///</summary>
        [TestMethod()]
        public void RemoveDirTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string dir = string.Empty; // TODO: Initialize to an appropriate value
            target.RemoveDir(dir);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RemoveFile
        ///</summary>
        [TestMethod()]
        public void RemoveFileTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            target.RemoveFile(filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RenameFile
        ///</summary>
        [TestMethod()]
        public void RenameFileTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string oldfilename = string.Empty; // TODO: Initialize to an appropriate value
            string newfilename = string.Empty; // TODO: Initialize to an appropriate value
            target.RenameFile(oldfilename, newfilename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UploadAndComplete
        ///</summary>
        [TestMethod()]
        public void UploadAndCompleteTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            Stream fileToUpload = null; // TODO: Initialize to an appropriate value
            long length = 0; // TODO: Initialize to an appropriate value
            string remote_filename = string.Empty; // TODO: Initialize to an appropriate value
            bool resume = false; // TODO: Initialize to an appropriate value
            target.UploadAndComplete(fileToUpload, length, remote_filename, resume);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BytesTotal
        ///</summary>
        [TestMethod()]
        public void BytesTotalTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.BytesTotal;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FileSize
        ///</summary>
        [TestMethod()]
        public void FileSizeTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.FileSize;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsConnected
        ///</summary>
        [TestMethod()]
        public void IsConnectedTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsConnected;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Messages
        ///</summary>
        [TestMethod()]
        public void MessagesTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Messages;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MessagesAvailable
        ///</summary>
        [TestMethod()]
        public void MessagesAvailableTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MessagesAvailable;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PassiveMode
        ///</summary>
        [TestMethod()]
        public void PassiveModeTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.PassiveMode = expected;
            actual = target.PassiveMode;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResponseString
        ///</summary>
        [TestMethod()]
        public void ResponseStringTest()
        {
            FTP target = new FTP(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ResponseString;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
