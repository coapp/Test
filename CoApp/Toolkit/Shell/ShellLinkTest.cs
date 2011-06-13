using CoApp.Toolkit.Shell;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Shell
{
    
    
    /// <summary>
    ///This is a test class for ShellLinkTest and is intended
    ///to contain all ShellLinkTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ShellLinkTest
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
        ///A test for ShellLink Constructor
        ///</summary>
        [TestMethod()]
        public void ShellLinkConstructorTest()
        {
            string linkFilePath = string.Empty; // TODO: Initialize to an appropriate value
            ShellLink target = new ShellLink(linkFilePath);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ShellLink Constructor
        ///</summary>
        [TestMethod()]
        public void ShellLinkConstructorTest1()
        {
            ShellLink target = new ShellLink();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateShortcut
        ///</summary>
        [TestMethod()]
        public void CreateShortcutTest()
        {
            string shortcutPath = string.Empty; // TODO: Initialize to an appropriate value
            string actualFilePath = string.Empty; // TODO: Initialize to an appropriate value
            string description = string.Empty; // TODO: Initialize to an appropriate value
            string workingDirectory = string.Empty; // TODO: Initialize to an appropriate value
            string arguments = string.Empty; // TODO: Initialize to an appropriate value
            ShellLink expected = null; // TODO: Initialize to an appropriate value
            ShellLink actual;
            actual = ShellLink.CreateShortcut(shortcutPath, actualFilePath, description, workingDirectory, arguments);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsShellLink
        ///</summary>
        [TestMethod()]
        public void IsShellLinkTest()
        {
            string shortcutPath = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = ShellLink.IsShellLink(shortcutPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            string linkPath = string.Empty; // TODO: Initialize to an appropriate value
            ShellLink expected = null; // TODO: Initialize to an appropriate value
            ShellLink actual;
            actual = ShellLink.Load(linkPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PointsTo
        ///</summary>
        [TestMethod()]
        public void PointsToTest()
        {
            string shortcutPath = string.Empty; // TODO: Initialize to an appropriate value
            string targetPath = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = ShellLink.PointsTo(shortcutPath, targetPath);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Resolve
        ///</summary>
        [TestMethod()]
        public void ResolveTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            ResolveFlags flags = new ResolveFlags(); // TODO: Initialize to an appropriate value
            target.Resolve(hwnd, flags);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Resolve
        ///</summary>
        [TestMethod()]
        public void ResolveTest1()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            ResolveFlags flags = new ResolveFlags(); // TODO: Initialize to an appropriate value
            int noUxTimeoutMs = 0; // TODO: Initialize to an appropriate value
            target.Resolve(flags, noUxTimeoutMs);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Resolve
        ///</summary>
        [TestMethod()]
        public void ResolveTest2()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            ResolveFlags flags = new ResolveFlags(); // TODO: Initialize to an appropriate value
            target.Resolve(flags);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string lnkPath = string.Empty; // TODO: Initialize to an appropriate value
            target.Save(lnkPath);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Arguments
        ///</summary>
        [TestMethod()]
        public void ArgumentsTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Arguments = expected;
            actual = target.Arguments;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CodePage
        ///</summary>
        [TestMethod()]
        public void CodePageTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.CodePage = expected;
            actual = target.CodePage;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConsoleProperties
        ///</summary>
        [TestMethod()]
        public void ConsolePropertiesTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            ConsoleProperties actual;
            actual = target.ConsoleProperties;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DarwinLink
        ///</summary>
        [TestMethod()]
        public void DarwinLinkTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.DarwinLink = expected;
            actual = target.DarwinLink;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Description
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Description = expected;
            actual = target.Description;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpSzIcon
        ///</summary>
        [TestMethod()]
        public void ExpSzIconTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ExpSzIcon = expected;
            actual = target.ExpSzIcon;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpSzLink
        ///</summary>
        [TestMethod()]
        public void ExpSzLinkTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ExpSzLink = expected;
            actual = target.ExpSzLink;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Flags
        ///</summary>
        [TestMethod()]
        public void FlagsTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            ShellLinkFlags expected = new ShellLinkFlags(); // TODO: Initialize to an appropriate value
            ShellLinkFlags actual;
            target.Flags = expected;
            actual = target.Flags;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasCodePage
        ///</summary>
        [TestMethod()]
        public void HasCodePageTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasCodePage;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasConsoleProperties
        ///</summary>
        [TestMethod()]
        public void HasConsolePropertiesTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasConsoleProperties;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasDarwinLink
        ///</summary>
        [TestMethod()]
        public void HasDarwinLinkTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasDarwinLink;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasExpSzIcon
        ///</summary>
        [TestMethod()]
        public void HasExpSzIconTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasExpSzIcon;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasExpSzLink
        ///</summary>
        [TestMethod()]
        public void HasExpSzLinkTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasExpSzLink;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IconLocation
        ///</summary>
        [TestMethod()]
        public void IconLocationTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            IconLocation expected = null; // TODO: Initialize to an appropriate value
            IconLocation actual;
            target.IconLocation = expected;
            actual = target.IconLocation;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Path
        ///</summary>
        [TestMethod()]
        public void PathTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Path = expected;
            actual = target.Path;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShortPath
        ///</summary>
        [TestMethod()]
        public void ShortPathTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ShortPath;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShowCommand
        ///</summary>
        [TestMethod()]
        public void ShowCommandTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            ShowWindowCommand expected = new ShowWindowCommand(); // TODO: Initialize to an appropriate value
            ShowWindowCommand actual;
            target.ShowCommand = expected;
            actual = target.ShowCommand;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UncPriorityPath
        ///</summary>
        [TestMethod()]
        public void UncPriorityPathTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.UncPriorityPath;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WorkingDirectory
        ///</summary>
        [TestMethod()]
        public void WorkingDirectoryTest()
        {
            ShellLink target = new ShellLink(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.WorkingDirectory = expected;
            actual = target.WorkingDirectory;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
