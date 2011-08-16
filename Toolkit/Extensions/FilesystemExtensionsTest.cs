using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for FilesystemExtensionsTest and is intended
    ///to contain all FilesystemExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FilesystemExtensionsTest
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
        ///A test for CanonicalizePath
        ///</summary>
        [TestMethod()]
        public void CanonicalizePathTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            string filenameHint = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.CanonicalizePath(filename, filenameHint);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ChangeFileExtensionTo
        ///</summary>
        [TestMethod()]
        public void ChangeFileExtensionToTest()
        {
            string currentFilename = string.Empty; // TODO: Initialize to an appropriate value
            string newExtension = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.ChangeFileExtensionTo(currentFilename, newExtension);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DirectoryEnumerateFilesSmarter
        ///</summary>
        [TestMethod()]
        public void DirectoryEnumerateFilesSmarterTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            string searchPattern = string.Empty; // TODO: Initialize to an appropriate value
            SearchOption searchOption = new SearchOption(); // TODO: Initialize to an appropriate value
            IEnumerable<string> skipPathPatterns = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = FilesystemExtensions.DirectoryEnumerateFilesSmarter(path, searchPattern, searchOption, skipPathPatterns);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DirectoryExistsAndIsAccessible
        ///</summary>
        [TestMethod()]
        public void DirectoryExistsAndIsAccessibleTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FilesystemExtensions.DirectoryExistsAndIsAccessible(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindFilesSmarter
        ///</summary>
        [TestMethod()]
        public void FindFilesSmarterTest()
        {
            string pathMask = string.Empty; // TODO: Initialize to an appropriate value
            SearchOption searchOption = new SearchOption(); // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = FilesystemExtensions.FindFilesSmarter(pathMask, searchOption);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindFilesSmarter
        ///</summary>
        [TestMethod()]
        public void FindFilesSmarterTest1()
        {
            IEnumerable<string> pathMasks = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = FilesystemExtensions.FindFilesSmarter(pathMasks);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindFilesSmarterComplex
        ///</summary>
        [TestMethod()]
        public void FindFilesSmarterComplexTest()
        {
            string pathMask = string.Empty; // TODO: Initialize to an appropriate value
            string pathPrefix = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = FilesystemExtensions.FindFilesSmarterComplex(pathMask, pathPrefix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindFilesSmarterComplex
        ///</summary>
        [TestMethod()]
        public void FindFilesSmarterComplexTest1()
        {
            IEnumerable<string> pathMasks = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = FilesystemExtensions.FindFilesSmarterComplex(pathMasks);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FormatFilename
        ///</summary>
        [TestMethod()]
        public void FormatFilenameTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            string[] parameters = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.FormatFilename(filename, parameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFullPath
        ///</summary>
        [TestMethod()]
        public void GetFullPathTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.GetFullPath(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSubPath
        ///</summary>
        [TestMethod()]
        public void GetSubPathTest()
        {
            string parentPath = string.Empty; // TODO: Initialize to an appropriate value
            string childPath = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.GetSubPath(parentPath, childPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSubPath
        ///</summary>
        [TestMethod()]
        public void IsSubPathTest()
        {
            string rootPath = string.Empty; // TODO: Initialize to an appropriate value
            string childPath = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = FilesystemExtensions.IsSubPath(rootPath, childPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSimpleSubPath
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\IsSimpleSubPathStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\IsSimpleSubPathStrings.csv", "IsSimpleSubPathStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsSimpleSubPathTest()
        {
            string path = (string)testContextInstance.DataRow["STR"];
            bool expected;
            if ((int)testContextInstance.DataRow["isSubPath"] > 0)
                expected = true;
            else
                expected = false;
            bool actual;
            actual = FilesystemExtensions.IsSimpleSubPath(path);
            Assert.AreEqual(expected, actual, "String \"" + path + "\"  Expected: " + expected + "  Actual: " + actual);
            
        }

        /// <summary>
        ///A test for NameWithoutExt
        ///</summary>
        [TestMethod()]
        public void NameWithoutExtTest()
        {
            FileInfo fi = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.NameWithoutExt(fi);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NormalizePath
        ///</summary>
        [TestMethod()]
        public void NormalizePathTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.NormalizePath(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadAllBytesFromFile
        ///</summary>
        [TestMethod()]
        public void ReadAllBytesFromFileTest()
        {
            MemoryStream ms = null; // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            FilesystemExtensions.ReadAllBytesFromFile(ms, path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RelativePathTo
        ///</summary>
        [TestMethod()]
        public void RelativePathToTest()
        {
            string currentDirectory = string.Empty; // TODO: Initialize to an appropriate value
            string pathToMakeRelative = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FilesystemExtensions.RelativePathTo(currentDirectory, pathToMakeRelative);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TryHardToDeleteDirectory
        ///</summary>
        [TestMethod()]
        public void TryHardToDeleteDirectoryTest()
        {
            string directoryName = string.Empty; // TODO: Initialize to an appropriate value
            FilesystemExtensions.TryHardToDeleteDirectory(directoryName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TryHardToDeleteFile
        ///</summary>
        [TestMethod()]
        public void TryHardToDeleteFileTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            FilesystemExtensions.TryHardToDeleteFile(filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            FileStream fileStream = null; // TODO: Initialize to an appropriate value
            byte[] data = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = FilesystemExtensions.Write(fileStream, data);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteAllBytesToFile
        ///</summary>
        [TestMethod()]
        public void WriteAllBytesToFileTest()
        {
            MemoryStream ms = null; // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            FilesystemExtensions.WriteAllBytesToFile(ms, path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
