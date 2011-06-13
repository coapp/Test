using CoApp.Toolkit.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test.CoApp.Toolkit.Network
{
    
    
    /// <summary>
    ///This is a test class for RemoteFileTest and is intended
    ///to contain all RemoteFileTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RemoteFileTest
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
        ///A test for RemoteFile Constructor
        ///</summary>
        [TestMethod()]
        public void RemoteFileConstructorTest()
        {
            Uri remoteLocation = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            RemoteFile target = new RemoteFile(remoteLocation, cancellationToken);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RemoteFile Constructor
        ///</summary>
        [TestMethod()]
        public void RemoteFileConstructorTest1()
        {
            Uri remoteLocation = null; // TODO: Initialize to an appropriate value
            string localFolder = string.Empty; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            RemoteFile target = new RemoteFile(remoteLocation, localFolder, cancellationToken);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RemoteFile Constructor
        ///</summary>
        [TestMethod()]
        public void RemoteFileConstructorTest2()
        {
            Uri remoteLocation = null; // TODO: Initialize to an appropriate value
            string localFolder = string.Empty; // TODO: Initialize to an appropriate value
            RemoteFile target = new RemoteFile(remoteLocation, localFolder);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RemoteFile Constructor
        ///</summary>
        [TestMethod()]
        public void RemoteFileConstructorTest3()
        {
            Uri remoteLocation = null; // TODO: Initialize to an appropriate value
            RemoteFile target = new RemoteFile(remoteLocation);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

/* TR01: TODO: All of the enclosed tests need appropriate constructors made before they can run.
        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Delete();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteLocalFile
        ///</summary>
        [TestMethod()]
        public void DeleteLocalFileTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            target.DeleteLocalFile();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            bool resumeExistingDownload = false; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Get(resumeExistingDownload);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Move
        ///</summary>
        [TestMethod()]
        public void MoveTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            Uri newRemoteLocation = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Move(newRemoteLocation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Preview
        ///</summary>
        [TestMethod()]
        public void PreviewTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Preview();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Put
        ///</summary>
        [TestMethod()]
        public void PutTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            string localFilename = string.Empty; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Put(localFilename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Stop
        ///</summary>
        [TestMethod()]
        public void StopTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            bool deletePartialDownload = false; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Stop(deletePartialDownload);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CancellationToken
        ///</summary>
        [TestMethod()]
        public void CancellationTokenTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            CancellationToken expected = new CancellationToken(); // TODO: Initialize to an appropriate value
            CancellationToken actual;
            target.CancellationToken = expected;
            actual = target.CancellationToken;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContentLength
        ///</summary>
        [TestMethod()]
        public void ContentLengthTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.ContentLength;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentLength
        ///</summary>
        [TestMethod()]
        public void CurrentLengthTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.CurrentLength;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Folder
        ///</summary>
        [TestMethod()]
        public void FolderTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Folder = expected;
            actual = target.Folder;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasPreviewed
        ///</summary>
        [TestMethod()]
        public void HasPreviewedTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasPreviewed;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsLocal
        ///</summary>
        [TestMethod()]
        public void IsLocalTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsLocal;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsPartial
        ///</summary>
        [TestMethod()]
        public void IsPartialTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsPartial;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsRedirect
        ///</summary>
        [TestMethod()]
        public void IsRedirectTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsRedirect;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LastModified
        ///</summary>
        [TestMethod()]
        public void LastModifiedTest()
        {
            RemoteFile target = new RemoteFile(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.LastModified;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
 */
    }
}
