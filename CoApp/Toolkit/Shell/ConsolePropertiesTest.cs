using CoApp.Toolkit.Shell;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Shell
{
    
    
    /// <summary>
    ///This is a test class for ConsolePropertiesTest and is intended
    ///to contain all ConsolePropertiesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConsolePropertiesTest
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
        ///A test for ConsoleProperties Constructor
        ///</summary>
        [TestMethod()]
        public void ConsolePropertiesConstructorTest()
        {
            ConsoleProperties another = null; // TODO: Initialize to an appropriate value
            ConsoleProperties target = new ConsoleProperties(another);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ConsoleProperties Constructor
        ///</summary>
        [TestMethod()]
        public void ConsolePropertiesConstructorTest1()
        {
            ConsoleProperties target = new ConsoleProperties();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Commit
        ///</summary>
        [TestMethod()]
        public void CommitTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            target.Commit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AutoPosition
        ///</summary>
        [TestMethod()]
        public void AutoPositionTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.AutoPosition = expected;
            actual = target.AutoPosition;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ColorTable
        ///</summary>
        [TestMethod()]
        public void ColorTableTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            ColorTable actual;
            actual = target.ColorTable;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CursorSize
        ///</summary>
        [TestMethod()]
        public void CursorSizeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.CursorSize = expected;
            actual = target.CursorSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FaceName
        ///</summary>
        [TestMethod()]
        public void FaceNameTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FaceName = expected;
            actual = target.FaceName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FillAttribute
        ///</summary>
        [TestMethod()]
        public void FillAttributeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.FillAttribute = expected;
            actual = target.FillAttribute;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Font
        ///</summary>
        [TestMethod()]
        public void FontTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.Font = expected;
            actual = target.Font;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FontFamily
        ///</summary>
        [TestMethod()]
        public void FontFamilyTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.FontFamily = expected;
            actual = target.FontFamily;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FontSize
        ///</summary>
        [TestMethod()]
        public void FontSizeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            Coordinate expected = new Coordinate(); // TODO: Initialize to an appropriate value
            Coordinate actual;
            target.FontSize = expected;
            actual = target.FontSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FontWeight
        ///</summary>
        [TestMethod()]
        public void FontWeightTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.FontWeight = expected;
            actual = target.FontWeight;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FullScreen
        ///</summary>
        [TestMethod()]
        public void FullScreenTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.FullScreen = expected;
            actual = target.FullScreen;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HistoryBufferSize
        ///</summary>
        [TestMethod()]
        public void HistoryBufferSizeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.HistoryBufferSize = expected;
            actual = target.HistoryBufferSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HistoryNoDup
        ///</summary>
        [TestMethod()]
        public void HistoryNoDupTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.HistoryNoDup = expected;
            actual = target.HistoryNoDup;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InputBufferSize
        ///</summary>
        [TestMethod()]
        public void InputBufferSizeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.InputBufferSize = expected;
            actual = target.InputBufferSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertMode
        ///</summary>
        [TestMethod()]
        public void InsertModeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.InsertMode = expected;
            actual = target.InsertMode;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumberOfHistoryBuffers
        ///</summary>
        [TestMethod()]
        public void NumberOfHistoryBuffersTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.NumberOfHistoryBuffers = expected;
            actual = target.NumberOfHistoryBuffers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PopupFillAttribute
        ///</summary>
        [TestMethod()]
        public void PopupFillAttributeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.PopupFillAttribute = expected;
            actual = target.PopupFillAttribute;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QuickEdit
        ///</summary>
        [TestMethod()]
        public void QuickEditTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.QuickEdit = expected;
            actual = target.QuickEdit;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScreenBufferSize
        ///</summary>
        [TestMethod()]
        public void ScreenBufferSizeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            Coordinate expected = new Coordinate(); // TODO: Initialize to an appropriate value
            Coordinate actual;
            target.ScreenBufferSize = expected;
            actual = target.ScreenBufferSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WindowOrigin
        ///</summary>
        [TestMethod()]
        public void WindowOriginTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            Coordinate expected = new Coordinate(); // TODO: Initialize to an appropriate value
            Coordinate actual;
            target.WindowOrigin = expected;
            actual = target.WindowOrigin;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WindowSize
        ///</summary>
        [TestMethod()]
        public void WindowSizeTest()
        {
            ConsoleProperties target = new ConsoleProperties(); // TODO: Initialize to an appropriate value
            Coordinate expected = new Coordinate(); // TODO: Initialize to an appropriate value
            Coordinate actual;
            target.WindowSize = expected;
            actual = target.WindowSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
