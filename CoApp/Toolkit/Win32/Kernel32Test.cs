using CoApp.Toolkit.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Text;

namespace Test.CoApp.Toolkit.Win32
{
    
    
    /// <summary>
    ///This is a test class for Kernel32Test and is intended
    ///to contain all Kernel32Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Kernel32Test
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
        ///A test for AllocConsole
        ///</summary>
        [TestMethod()]
        public void AllocConsoleTest()
        {
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.AllocConsole();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AttachConsole
        ///</summary>
        [TestMethod()]
        public void AttachConsoleTest()
        {
            int processId = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.AttachConsole(processId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BackupRead
        ///</summary>
        [TestMethod()]
        public void BackupReadTest()
        {
            SafeFileHandle hFile = null; // TODO: Initialize to an appropriate value
            Win32StreamId pBuffer = new Win32StreamId(); // TODO: Initialize to an appropriate value
            Win32StreamId pBufferExpected = new Win32StreamId(); // TODO: Initialize to an appropriate value
            int numberOfBytesToRead = 0; // TODO: Initialize to an appropriate value
            int numberOfBytesRead = 0; // TODO: Initialize to an appropriate value
            int numberOfBytesReadExpected = 0; // TODO: Initialize to an appropriate value
            bool abort = false; // TODO: Initialize to an appropriate value
            bool processSecurity = false; // TODO: Initialize to an appropriate value
            IntPtr context = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr contextExpected = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.BackupRead(hFile, ref pBuffer, numberOfBytesToRead, out numberOfBytesRead, abort, processSecurity, ref context);
            Assert.AreEqual(pBufferExpected, pBuffer);
            Assert.AreEqual(numberOfBytesReadExpected, numberOfBytesRead);
            Assert.AreEqual(contextExpected, context);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BackupSeek
        ///</summary>
        [TestMethod()]
        public void BackupSeekTest()
        {
            SafeFileHandle hFile = null; // TODO: Initialize to an appropriate value
            int bytesToSeekLow = 0; // TODO: Initialize to an appropriate value
            int bytesToSeekHigh = 0; // TODO: Initialize to an appropriate value
            int bytesSeekedLow = 0; // TODO: Initialize to an appropriate value
            int bytesSeekedLowExpected = 0; // TODO: Initialize to an appropriate value
            int bytesSeekedHigh = 0; // TODO: Initialize to an appropriate value
            int bytesSeekedHighExpected = 0; // TODO: Initialize to an appropriate value
            IntPtr context = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr contextExpected = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.BackupSeek(hFile, bytesToSeekLow, bytesToSeekHigh, out bytesSeekedLow, out bytesSeekedHigh, ref context);
            Assert.AreEqual(bytesSeekedLowExpected, bytesSeekedLow);
            Assert.AreEqual(bytesSeekedHighExpected, bytesSeekedHigh);
            Assert.AreEqual(contextExpected, context);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CloseHandle
        ///</summary>
        [TestMethod()]
        public void CloseHandleTest()
        {
            IntPtr h = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.CloseHandle(h);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateConsoleScreenBuffer
        ///</summary>
        [TestMethod()]
        public void CreateConsoleScreenBufferTest()
        {
            NativeFileAccess dwDesiredAccess = new NativeFileAccess(); // TODO: Initialize to an appropriate value
            FileShare dwShareMode = new FileShare(); // TODO: Initialize to an appropriate value
            SecurityAttributes lpSecurityAttributes = null; // TODO: Initialize to an appropriate value
            int dwFlags = 0; // TODO: Initialize to an appropriate value
            IntPtr lpScreenBufferData = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = Kernel32.CreateConsoleScreenBuffer(dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwFlags, lpScreenBufferData);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateFile
        ///</summary>
        [TestMethod()]
        public void CreateFileTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            NativeFileAccess access = new NativeFileAccess(); // TODO: Initialize to an appropriate value
            FileShare share = new FileShare(); // TODO: Initialize to an appropriate value
            IntPtr security = new IntPtr(); // TODO: Initialize to an appropriate value
            FileMode mode = new FileMode(); // TODO: Initialize to an appropriate value
            NativeFileAttributesAndFlags flags = new NativeFileAttributesAndFlags(); // TODO: Initialize to an appropriate value
            IntPtr template = new IntPtr(); // TODO: Initialize to an appropriate value
            SafeFileHandle expected = null; // TODO: Initialize to an appropriate value
            SafeFileHandle actual;
            actual = Kernel32.CreateFile(name, access, share, security, mode, flags, template);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateHardLink
        ///</summary>
        [TestMethod()]
        public void CreateHardLinkTest()
        {
            string lpFileName = string.Empty; // TODO: Initialize to an appropriate value
            string lpExistingFileName = string.Empty; // TODO: Initialize to an appropriate value
            IntPtr lpSecurityAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.CreateHardLink(lpFileName, lpExistingFileName, lpSecurityAttributes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateProcessA
        ///</summary>
        [TestMethod()]
        public void CreateProcessATest()
        {
            string applicationName = string.Empty; // TODO: Initialize to an appropriate value
            string commandLine = string.Empty; // TODO: Initialize to an appropriate value
            IntPtr lpProcessAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpThreadAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            bool bInheritHandles = false; // TODO: Initialize to an appropriate value
            int dwCreationFlags = 0; // TODO: Initialize to an appropriate value
            IntPtr lpEnvironment = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpCurrentDirectory = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpStartupInfo = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpProcessInformation = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.CreateProcessA(applicationName, commandLine, lpProcessAttributes, lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateProcessW
        ///</summary>
        [TestMethod()]
        public void CreateProcessWTest()
        {
            string applicationName = string.Empty; // TODO: Initialize to an appropriate value
            string commandLine = string.Empty; // TODO: Initialize to an appropriate value
            IntPtr lpProcessAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpThreadAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            bool bInheritHandles = false; // TODO: Initialize to an appropriate value
            int dwCreationFlags = 0; // TODO: Initialize to an appropriate value
            IntPtr lpEnvironment = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpCurrentDirectory = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpStartupInfo = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpProcessInformation = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.CreateProcessW(applicationName, commandLine, lpProcessAttributes, lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateProcessW
        ///</summary>
        [TestMethod()]
        public void CreateProcessWTest1()
        {
            IntPtr lpApplicationName = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpCommandLine = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpProcessAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpThreadAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            int bInheritHandles = 0; // TODO: Initialize to an appropriate value
            int dwCreationFlags = 0; // TODO: Initialize to an appropriate value
            IntPtr lpEnvironment = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpCurrentDirectory = new IntPtr(); // TODO: Initialize to an appropriate value
            Startupinfo lpStartupInfo = null; // TODO: Initialize to an appropriate value
            IntPtr lpProcessInformation = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.CreateProcessW(lpApplicationName, lpCommandLine, lpProcessAttributes, lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateProcessW
        ///</summary>
        [TestMethod()]
        public void CreateProcessWTest2()
        {
            string applicationName = string.Empty; // TODO: Initialize to an appropriate value
            string commandLine = string.Empty; // TODO: Initialize to an appropriate value
            IntPtr lpProcessAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpThreadAttributes = new IntPtr(); // TODO: Initialize to an appropriate value
            bool bInheritHandles = false; // TODO: Initialize to an appropriate value
            int dwCreationFlags = 0; // TODO: Initialize to an appropriate value
            IntPtr lpEnvironment = new IntPtr(); // TODO: Initialize to an appropriate value
            string lpCurrentDirectory = string.Empty; // TODO: Initialize to an appropriate value
            Startupinfo lpStartupInfo = null; // TODO: Initialize to an appropriate value
            ProcessInformation lpProcessInformation = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.CreateProcessW(applicationName, commandLine, lpProcessAttributes, lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateSymbolicLink
        ///</summary>
        [TestMethod()]
        public void CreateSymbolicLinkTest()
        {
            string lpSymlinkFileName = string.Empty; // TODO: Initialize to an appropriate value
            string lpTargetFileName = string.Empty; // TODO: Initialize to an appropriate value
            int dwFlags = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Kernel32.CreateSymbolicLink(lpSymlinkFileName, lpTargetFileName, dwFlags);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteFile
        ///</summary>
        [TestMethod()]
        public void DeleteFileTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.DeleteFile(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeviceIoControl
        ///</summary>
        [TestMethod()]
        public void DeviceIoControlTest()
        {
            IntPtr hDevice = new IntPtr(); // TODO: Initialize to an appropriate value
            ControlCodes dwIoControlCode = new ControlCodes(); // TODO: Initialize to an appropriate value
            IntPtr InBuffer = new IntPtr(); // TODO: Initialize to an appropriate value
            int nInBufferSize = 0; // TODO: Initialize to an appropriate value
            IntPtr OutBuffer = new IntPtr(); // TODO: Initialize to an appropriate value
            int nOutBufferSize = 0; // TODO: Initialize to an appropriate value
            int pBytesReturned = 0; // TODO: Initialize to an appropriate value
            int pBytesReturnedExpected = 0; // TODO: Initialize to an appropriate value
            IntPtr lpOverlapped = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.DeviceIoControl(hDevice, dwIoControlCode, InBuffer, nInBufferSize, OutBuffer, nOutBufferSize, out pBytesReturned, lpOverlapped);
            Assert.AreEqual(pBytesReturnedExpected, pBytesReturned);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FormatMessage
        ///</summary>
        [TestMethod()]
        public void FormatMessageTest()
        {
            int dwFlags = 0; // TODO: Initialize to an appropriate value
            IntPtr lpSource = new IntPtr(); // TODO: Initialize to an appropriate value
            int dwMessageId = 0; // TODO: Initialize to an appropriate value
            int dwLanguageId = 0; // TODO: Initialize to an appropriate value
            StringBuilder lpBuffer = null; // TODO: Initialize to an appropriate value
            int nSize = 0; // TODO: Initialize to an appropriate value
            IntPtr vaListArguments = new IntPtr(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Kernel32.FormatMessage(dwFlags, lpSource, dwMessageId, dwLanguageId, lpBuffer, nSize, vaListArguments);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FreeConsole
        ///</summary>
        [TestMethod()]
        public void FreeConsoleTest()
        {
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.FreeConsole();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetConsoleFontSize
        ///</summary>
        [TestMethod()]
        public void GetConsoleFontSizeTest()
        {
            IntPtr hOut = new IntPtr(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            Coord expected = new Coord(); // TODO: Initialize to an appropriate value
            Coord actual;
            actual = Kernel32.GetConsoleFontSize(hOut, index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetConsoleScreenBufferInfo
        ///</summary>
        [TestMethod()]
        public void GetConsoleScreenBufferInfoTest()
        {
            IntPtr hOut = new IntPtr(); // TODO: Initialize to an appropriate value
            ConsoleScreenBufferInfo csbi = new ConsoleScreenBufferInfo(); // TODO: Initialize to an appropriate value
            ConsoleScreenBufferInfo csbiExpected = new ConsoleScreenBufferInfo(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.GetConsoleScreenBufferInfo(hOut, out csbi);
            Assert.AreEqual(csbiExpected, csbi);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetConsoleWindow
        ///</summary>
        [TestMethod()]
        public void GetConsoleWindowTest()
        {
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = Kernel32.GetConsoleWindow();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCurrentConsoleFont
        ///</summary>
        [TestMethod()]
        public void GetCurrentConsoleFontTest()
        {
            IntPtr hOut = new IntPtr(); // TODO: Initialize to an appropriate value
            bool bMaximumWnd = false; // TODO: Initialize to an appropriate value
            ConsoleFontInfo ConsoleCurrentFont = new ConsoleFontInfo(); // TODO: Initialize to an appropriate value
            ConsoleFontInfo ConsoleCurrentFontExpected = new ConsoleFontInfo(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.GetCurrentConsoleFont(hOut, bMaximumWnd, out ConsoleCurrentFont);
            Assert.AreEqual(ConsoleCurrentFontExpected, ConsoleCurrentFont);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCurrentThreadId
        ///</summary>
        [TestMethod()]
        public void GetCurrentThreadIdTest()
        {
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Kernel32.GetCurrentThreadId();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileAttributes
        ///</summary>
        [TestMethod()]
        public void GetFileAttributesTest()
        {
            string fileName = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Kernel32.GetFileAttributes(fileName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileInformationByHandle
        ///</summary>
        [TestMethod()]
        public void GetFileInformationByHandleTest()
        {
            IntPtr hFile = new IntPtr(); // TODO: Initialize to an appropriate value
            ByHandleFileInformation lpFileInformation = new ByHandleFileInformation(); // TODO: Initialize to an appropriate value
            ByHandleFileInformation lpFileInformationExpected = new ByHandleFileInformation(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.GetFileInformationByHandle(hFile, out lpFileInformation);
            Assert.AreEqual(lpFileInformationExpected, lpFileInformation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileSizeEx
        ///</summary>
        [TestMethod()]
        public void GetFileSizeExTest()
        {
            SafeFileHandle handle = null; // TODO: Initialize to an appropriate value
            long size = 0; // TODO: Initialize to an appropriate value
            long sizeExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.GetFileSizeEx(handle, out size);
            Assert.AreEqual(sizeExpected, size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileType
        ///</summary>
        [TestMethod()]
        public void GetFileTypeTest()
        {
            SafeFileHandle handle = null; // TODO: Initialize to an appropriate value
            FileType expected = new FileType(); // TODO: Initialize to an appropriate value
            FileType actual;
            actual = Kernel32.GetFileType(handle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLargestConsoleWindowSize
        ///</summary>
        [TestMethod()]
        public void GetLargestConsoleWindowSizeTest()
        {
            Coord expected = new Coord(); // TODO: Initialize to an appropriate value
            Coord actual;
            actual = Kernel32.GetLargestConsoleWindowSize();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetModuleHandle
        ///</summary>
        [TestMethod()]
        public void GetModuleHandleTest()
        {
            string lpModuleName = string.Empty; // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = Kernel32.GetModuleHandle(lpModuleName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetNumberOfConsoleInputEvents
        ///</summary>
        [TestMethod()]
        public void GetNumberOfConsoleInputEventsTest()
        {
            IntPtr hIn = new IntPtr(); // TODO: Initialize to an appropriate value
            int num = 0; // TODO: Initialize to an appropriate value
            int numExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.GetNumberOfConsoleInputEvents(hIn, out num);
            Assert.AreEqual(numExpected, num);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcAddress
        ///</summary>
        [TestMethod()]
        public void GetProcAddressTest()
        {
            IntPtr hmod = new IntPtr(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = Kernel32.GetProcAddress(hmod, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetStdHandle
        ///</summary>
        [TestMethod()]
        public void GetStdHandleTest()
        {
            StandardHandle nStandardHandle = new StandardHandle(); // TODO: Initialize to an appropriate value
            SafeFileHandle expected = null; // TODO: Initialize to an appropriate value
            SafeFileHandle actual;
            actual = Kernel32.GetStdHandle(nStandardHandle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GlobalAddAtom
        ///</summary>
        [TestMethod()]
        public void GlobalAddAtomTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Kernel32.GlobalAddAtom(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GlobalDeleteAtom
        ///</summary>
        [TestMethod()]
        public void GlobalDeleteAtomTest()
        {
            int atom = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Kernel32.GlobalDeleteAtom(atom);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GlobalLock
        ///</summary>
        [TestMethod()]
        public void GlobalLockTest()
        {
            IntPtr hMem = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr expected = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr actual;
            actual = Kernel32.GlobalLock(hMem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GlobalUnlock
        ///</summary>
        [TestMethod()]
        public void GlobalUnlockTest()
        {
            IntPtr hMem = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.GlobalUnlock(hMem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PeekConsoleInput
        ///</summary>
        [TestMethod()]
        public void PeekConsoleInputTest()
        {
            IntPtr hConsoleInput = new IntPtr(); // TODO: Initialize to an appropriate value
            FocusInputRecord lpBuffer = null; // TODO: Initialize to an appropriate value
            FocusInputRecord lpBufferExpected = null; // TODO: Initialize to an appropriate value
            int nLength = 0; // TODO: Initialize to an appropriate value
            int lpNumberOfEventsRead = 0; // TODO: Initialize to an appropriate value
            int lpNumberOfEventsReadExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            //actual = Kernel32.PeekConsoleInput(hConsoleInput, out lpBuffer, nLength, out lpNumberOfEventsRead);
            actual = Kernel32.PeekConsoleInput(hConsoleInput, lpBuffer, nLength, out lpNumberOfEventsRead);
            Assert.AreEqual(lpBufferExpected, lpBuffer);
            Assert.AreEqual(lpNumberOfEventsReadExpected, lpNumberOfEventsRead);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetConsoleActiveScreenBuffer
        ///</summary>
        [TestMethod()]
        public void SetConsoleActiveScreenBufferTest()
        {
            IntPtr hBuf = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.SetConsoleActiveScreenBuffer(hBuf);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetConsoleCtrlHandler
        ///</summary>
        [TestMethod()]
        public void SetConsoleCtrlHandlerTest()
        {
            Kernel32.ConsoleHandlerRoutine routine = null; // TODO: Initialize to an appropriate value
            bool add = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.SetConsoleCtrlHandler(routine, add);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetConsoleCursorPosition
        ///</summary>
        [TestMethod()]
        public void SetConsoleCursorPositionTest()
        {
            IntPtr hOut = new IntPtr(); // TODO: Initialize to an appropriate value
            Coord newPos = new Coord(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.SetConsoleCursorPosition(hOut, newPos);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetConsoleScreenBufferSize
        ///</summary>
        [TestMethod()]
        public void SetConsoleScreenBufferSizeTest()
        {
            IntPtr hOut = new IntPtr(); // TODO: Initialize to an appropriate value
            Coord newSize = new Coord(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.SetConsoleScreenBufferSize(hOut, newSize);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteConsole
        ///</summary>
        [TestMethod()]
        public void WriteConsoleTest()
        {
            IntPtr hConsoleOutput = new IntPtr(); // TODO: Initialize to an appropriate value
            string lpBuffer = string.Empty; // TODO: Initialize to an appropriate value
            int nNumberOfCharsToWrite = 0; // TODO: Initialize to an appropriate value
            int lpNumberOfCharsWritten = 0; // TODO: Initialize to an appropriate value
            int lpNumberOfCharsWrittenExpected = 0; // TODO: Initialize to an appropriate value
            IntPtr lpReserved = new IntPtr(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.WriteConsole(hConsoleOutput, lpBuffer, nNumberOfCharsToWrite, out lpNumberOfCharsWritten, lpReserved);
            Assert.AreEqual(lpNumberOfCharsWrittenExpected, lpNumberOfCharsWritten);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteConsoleInput
        ///</summary>
        [TestMethod()]
        public void WriteConsoleInputTest()
        {
            SafeFileHandle hIn = null; // TODO: Initialize to an appropriate value
            KeyInputRecord r = null; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            int countOut = 0; // TODO: Initialize to an appropriate value
            int countOutExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.WriteConsoleInput(hIn, r, count, out countOut);
            Assert.AreEqual(countOutExpected, countOut);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteProcessMemory
        ///</summary>
        [TestMethod()]
        public void WriteProcessMemoryTest()
        {
            IntPtr hProcess = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpBaseAddress = new IntPtr(); // TODO: Initialize to an appropriate value
            IntPtr lpBuffer = new IntPtr(); // TODO: Initialize to an appropriate value
            int nSize = 0; // TODO: Initialize to an appropriate value
            int lpNumberOfBytesWritten = 0; // TODO: Initialize to an appropriate value
            int lpNumberOfBytesWrittenExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Kernel32.WriteProcessMemory(hProcess, lpBaseAddress, lpBuffer, nSize, out lpNumberOfBytesWritten);
            Assert.AreEqual(lpNumberOfBytesWrittenExpected, lpNumberOfBytesWritten);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
