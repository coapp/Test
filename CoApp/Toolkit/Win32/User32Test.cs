using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for User32Test and is intended
    ///to contain all User32Test Unit Tests
    ///</summary>
    [TestClass()]
    public class User32Test
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
        ///A test for ChangeClipboardChain
        ///</summary>
        [TestMethod()]
        public void ChangeClipboardChainTest()
        {
            IntPtr hWndRemove = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr hWndNewNext = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.ChangeClipboardChain(hWndRemove, hWndNewNext);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFocus
        ///</summary>
        [TestMethod()]
        public void GetFocusTest()
        {
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = User32.GetFocus();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMenuItemCount
        ///</summary>
        [TestMethod()]
        public void GetMenuItemCountTest()
        {
            IntPtr hMenu = new IntPtr(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = User32.GetMenuItemCount(hMenu);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMenuItemInfo
        ///</summary>
        [TestMethod()]
        public void GetMenuItemInfoTest()
        {
            IntPtr hMenu = new IntPtr(); // TODO: Initialize to an appropriate value
            int item = 0; // TODO: Initialize to an appropriate value
            bool bByPosition = false; // TODO: Initialize to an appropriate value
            MenuItemInfo mii = null; // TODO: Initialize to an appropriate value
            MenuItemInfo miiExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            //actual = User32.GetMenuItemInfo(hMenu, item, bByPosition, out mii);
            actual = User32.GetMenuItemInfo(hMenu, item, bByPosition, mii);
            Assert.AreEqual(miiExpected, mii);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSystemMenu
        ///</summary>
        [TestMethod()]
        public void GetSystemMenuTest()
        {
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            bool bRevert = false; // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = User32.GetSystemMenu(hWnd, bRevert);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWindowInfo
        ///</summary>
        [TestMethod()]
        public void GetWindowInfoTest()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            WindowInfo wi = new WindowInfo(); // TODO: Initialize to an appropriate value
            WindowInfo wiExpected = new WindowInfo(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.GetWindowInfo(hwnd, out wi);
            Assert.AreEqual(wiExpected, wi);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsWindow
        ///</summary>
        [TestMethod()]
        public void IsWindowTest()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.IsWindow(hwnd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveWindow
        ///</summary>
        [TestMethod()]
        public void MoveWindowTest()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int x = 0; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            int h = 0; // TODO: Initialize to an appropriate value
            int w = 0; // TODO: Initialize to an appropriate value
            bool repaint = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.MoveWindow(hwnd, x, y, h, w, repaint);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PostMessage
        ///</summary>
        [TestMethod()]
        public void PostMessageTest()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int msg = 0; // TODO: Initialize to an appropriate value
            int wparam = 0; // TODO: Initialize to an appropriate value
            int lparam = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.PostMessage(hwnd, msg, wparam, lparam);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RegisterHotKey
        ///</summary>
        [TestMethod()]
        public void RegisterHotKeyTest()
        {
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            int fsModifiers = 0; // TODO: Initialize to an appropriate value
            int vlc = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.RegisterHotKey(hWnd, id, fsModifiers, vlc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemoveMenu
        ///</summary>
        [TestMethod()]
        public void RemoveMenuTest()
        {
            IntPtr hMenu = new IntPtr(); // TODO: Initialize to an appropriate value
            int nPosition = 0; // TODO: Initialize to an appropriate value
            int nFlags = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.RemoveMenu(hMenu, nPosition, nFlags);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SendMessage
        ///</summary>
        [TestMethod()]
        public void SendMessageTest()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int wMsg = 0; // TODO: Initialize to an appropriate value
            IntPtr wParam = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lParam = new IntPtr(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = User32.SendMessage(hwnd, wMsg, wParam, lParam);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SendMessage
        ///</summary>
        [TestMethod()]
        public void SendMessageTest1()
        {
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            uint Msg = 0; // TODO: Initialize to an appropriate value
            int wParam = 0; // TODO: Initialize to an appropriate value
            IntPtr lParam = new IntPtr(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = User32.SendMessage(hWnd, Msg, wParam, lParam);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SendMessage
        ///</summary>
        [TestMethod()]
        public void SendMessageTest2()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int msg = 0; // TODO: Initialize to an appropriate value
            int wparam = 0; // TODO: Initialize to an appropriate value
            int lparam = 0; // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = User32.SendMessage(hwnd, msg, wparam, lparam);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetClipboardViewer
        ///</summary>
        [TestMethod()]
        public void SetClipboardViewerTest()
        {
            IntPtr hWndNewViewer = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = User32.SetClipboardViewer(hWndNewViewer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetFocus
        ///</summary>
        [TestMethod()]
        public void SetFocusTest()
        {
            IntPtr hwnd = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = User32.SetFocus(hwnd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetParent
        ///</summary>
        [TestMethod()]
        public void SetParentTest()
        {
            IntPtr child = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr newParent = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = User32.SetParent(child, newParent);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetWindowPos
        ///</summary>
        [TestMethod()]
        public void SetWindowPosTest()
        {
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr hWndInsertAfter = new IntPtr(); // TODO: Initialize to an appropriate value
            int X = 0; // TODO: Initialize to an appropriate value
            int Y = 0; // TODO: Initialize to an appropriate value
            int cx = 0; // TODO: Initialize to an appropriate value
            int cy = 0; // TODO: Initialize to an appropriate value
            int uFlags = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.SetWindowPos(hWnd, hWndInsertAfter, X, Y, cx, cy, uFlags);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShowWindow
        ///</summary>
        [TestMethod()]
        public void ShowWindowTest()
        {
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int nCmdShow = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.ShowWindow(hWnd, nCmdShow);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnregisterHotKey
        ///</summary>
        [TestMethod()]
        public void UnregisterHotKeyTest()
        {
            IntPtr hWnd = new IntPtr(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = User32.UnregisterHotKey(hWnd, id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
