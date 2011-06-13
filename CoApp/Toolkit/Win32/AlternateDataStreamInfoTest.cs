using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for AlternateDataStreamInfoTest and is intended
    ///to contain all AlternateDataStreamInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AlternateDataStreamInfoTest
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
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Delete();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo other = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            FileAccess access = new FileAccess(); // TODO: Initialize to an appropriate value
            FileShare share = new FileShare(); // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.Open(mode, access, share, bufferSize);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            FileAccess access = new FileAccess(); // TODO: Initialize to an appropriate value
            FileShare share = new FileShare(); // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.Open(mode, access, share);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest2()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.Open(mode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest3()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            FileAccess access = new FileAccess(); // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.Open(mode, access);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest4()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            FileAccess access = new FileAccess(); // TODO: Initialize to an appropriate value
            FileShare share = new FileShare(); // TODO: Initialize to an appropriate value
            int bufferSize = 0; // TODO: Initialize to an appropriate value
            bool useAsync = false; // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.Open(mode, access, share, bufferSize, useAsync);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OpenRead
        ///</summary>
        [TestMethod()]
        public void OpenReadTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.OpenRead();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OpenText
        ///</summary>
        [TestMethod()]
        public void OpenTextTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            StreamReader expected = null; // TODO: Initialize to an appropriate value
            StreamReader actual;
            actual = target.OpenText();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OpenWrite
        ///</summary>
        [TestMethod()]
        public void OpenWriteTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileStream expected = null; // TODO: Initialize to an appropriate value
            FileStream actual;
            actual = target.OpenWrite();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Equality
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest()
        {
            AlternateDataStreamInfo first = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo second = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = (first == second);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Inequality
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest()
        {
            AlternateDataStreamInfo first = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo second = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = (first != second);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Attributes
        ///</summary>
        [TestMethod()]
        public void AttributesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileStreamAttributes actual;
            actual = target.Attributes;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Exists
        ///</summary>
        [TestMethod()]
        public void ExistsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Exists;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FilePath
        ///</summary>
        [TestMethod()]
        public void FilePathTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FilePath;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FullPath
        ///</summary>
        [TestMethod()]
        public void FullPathTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FullPath;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Size
        ///</summary>
        [TestMethod()]
        public void SizeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            long actual;
            actual = target.Size;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StreamType
        ///</summary>
        [TestMethod()]
        public void StreamTypeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            AlternateDataStreamInfo_Accessor target = new AlternateDataStreamInfo_Accessor(param0); // TODO: Initialize to an appropriate value
            FileStreamType actual;
            actual = target.StreamType;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
