using CoApp.Toolkit.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Test.CoApp.Toolkit.Network
{
    
    
    /// <summary>
    ///This is a test class for TransferManagerTest and is intended
    ///to contain all TransferManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TransferManagerTest
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
        ///A test for GetTransferManager
        ///</summary>
        [TestMethod()]
        public void GetTransferManagerTest()
        {
            string folder = string.Empty; // TODO: Initialize to an appropriate value
            TransferManager expected = null; // TODO: Initialize to an appropriate value
            TransferManager actual;
            actual = TransferManager.GetTransferManager(folder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CancellationToken
        ///</summary>
        [TestMethod()]
        public void CancellationTokenTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TransferManager_Accessor target = new TransferManager_Accessor(param0); // TODO: Initialize to an appropriate value
            CancellationToken expected = new CancellationToken(); // TODO: Initialize to an appropriate value
            CancellationToken actual;
            target.CancellationToken = expected;
            actual = target.CancellationToken;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TransferManager_Accessor target = new TransferManager_Accessor(param0); // TODO: Initialize to an appropriate value
            string uri = string.Empty; // TODO: Initialize to an appropriate value
            RemoteFile actual;
            actual = target[uri];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TransferManager_Accessor target = new TransferManager_Accessor(param0); // TODO: Initialize to an appropriate value
            string uri = string.Empty; // TODO: Initialize to an appropriate value
            RemoteFile actual;
            actual = target[uri];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
