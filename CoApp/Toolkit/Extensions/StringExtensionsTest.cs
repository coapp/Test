using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for StringExtensionsTest and is intended
    ///to contain all StringExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringExtensionsTest
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
        ///A test for ContainsIgnoreCase
        ///</summary>
        [TestMethod()]
        public void ContainsIgnoreCaseTest()
        {
            IEnumerable<string> source = null; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.ContainsIgnoreCase(source, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateGuid
        ///</summary>
        [TestMethod()]
        public void CreateGuidTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            actual = StringExtensions.CreateGuid(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreatePublicKeyToken
        ///</summary>
        [TestMethod()]
        public void CreatePublicKeyTokenTest()
        {
            string publicKey = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.CreatePublicKeyToken(publicKey);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest()
        {
            string formatString = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            StringExtensions.Error(formatString, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExtendVersion
        ///</summary>
        [TestMethod()]
        public void ExtendVersionTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.ExtendVersion(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Gunzip
        ///</summary>
        [TestMethod()]
        public void GunzipTest()
        {
            byte[] input = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.Gunzip(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GunzipFromBase64
        ///</summary>
        [TestMethod()]
        public void GunzipFromBase64Test()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.GunzipFromBase64(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Gzip
        ///</summary>
        [TestMethod()]
        public void GzipTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = StringExtensions.Gzip(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GzipToBase64
        ///</summary>
        [TestMethod()]
        public void GzipToBase64Test()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.GzipToBase64(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasWildcardMatch
        ///</summary>
        [TestMethod()]
        public void HasWildcardMatchTest()
        {
            IEnumerable<string> source = null; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            string ignorePrefix = string.Empty; // TODO: Initialize to an appropriate value
            bool escapePrefix = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.HasWildcardMatch(source, value, ignorePrefix, escapePrefix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsEmail
        ///</summary>
        [TestMethod()]
        public void IsEmailTest()
        {
            string email = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsEmail(email);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsFalse
        ///</summary>
        [TestMethod()]
        public void IsFalseTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsFalse(text);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsTrue
        ///</summary>
        [TestMethod()]
        public void IsTrueTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsTrue(text);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsValidMajorMinorVersion
        ///</summary>
        [TestMethod()]
        public void IsValidMajorMinorVersionTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsValidMajorMinorVersion(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsValidVersion
        ///</summary>
        [TestMethod()]
        public void IsValidVersionTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            bool strict = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsValidVersion(input, strict);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsValidVersionPart
        ///</summary>
        [TestMethod()]
        public void IsValidVersionPartTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsValidVersionPart(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsWildcardMatch
        ///</summary>
        [TestMethod()]
        public void IsWildcardMatchTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            string wildcardMask = string.Empty; // TODO: Initialize to an appropriate value
            string ignorePrefix = string.Empty; // TODO: Initialize to an appropriate value
            bool escapePrefix = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.IsWildcardMatch(text, wildcardMask, ignorePrefix, escapePrefix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MD5Hash
        ///</summary>
        [TestMethod()]
        public void MD5HashTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.MD5Hash(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeSafeDirectoryId
        ///</summary>
        [TestMethod()]
        public void MakeSafeDirectoryIdTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.MakeSafeDirectoryId(input);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Match
        ///</summary>
        [TestMethod()]
        public void MatchTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string rxExpression = string.Empty; // TODO: Initialize to an appropriate value
            Match expected = null; // TODO: Initialize to an appropriate value
            Match actual;
            actual = StringExtensions.Match(input, rxExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MatchIgnoreCase
        ///</summary>
        [TestMethod()]
        public void MatchIgnoreCaseTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string rxExpression = string.Empty; // TODO: Initialize to an appropriate value
            Match expected = null; // TODO: Initialize to an appropriate value
            Match actual;
            actual = StringExtensions.MatchIgnoreCase(input, rxExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnlyContains
        ///</summary>
        [TestMethod()]
        public void OnlyContainsTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string characters = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.OnlyContains(str, characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnlyContains
        ///</summary>
        [TestMethod()]
        public void OnlyContainsTest1()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char[] characters = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.OnlyContains(str, characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PositionOfFirstCharacterNotIn
        ///</summary>
        [TestMethod()]
        public void PositionOfFirstCharacterNotInTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string characters = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = StringExtensions.PositionOfFirstCharacterNotIn(str, characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PositionOfFirstCharacterNotIn
        ///</summary>
        [TestMethod()]
        public void PositionOfFirstCharacterNotInTest1()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char[] characters = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = StringExtensions.PositionOfFirstCharacterNotIn(str, characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Print
        ///</summary>
        [TestMethod()]
        public void PrintTest()
        {
            string formatString = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            StringExtensions.Print(formatString, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ProtectBinaryForMachine
        ///</summary>
        [TestMethod()]
        public void ProtectBinaryForMachineTest()
        {
            IEnumerable<byte> binaryData = null; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            actual = StringExtensions.ProtectBinaryForMachine(binaryData, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProtectBinaryForUser
        ///</summary>
        [TestMethod()]
        public void ProtectBinaryForUserTest()
        {
            IEnumerable<byte> binaryData = null; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            actual = StringExtensions.ProtectBinaryForUser(binaryData, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProtectForMachine
        ///</summary>
        [TestMethod()]
        public void ProtectForMachineTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            actual = StringExtensions.ProtectForMachine(text, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProtectForUser
        ///</summary>
        [TestMethod()]
        public void ProtectForUserTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            actual = StringExtensions.ProtectForUser(text, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToByteArray
        ///</summary>
        [TestMethod()]
        public void ToByteArrayTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = StringExtensions.ToByteArray(text);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt32
        ///</summary>
        [TestMethod()]
        public void ToInt32Test()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            int defaultValue = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = StringExtensions.ToInt32(str, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt32
        ///</summary>
        [TestMethod()]
        public void ToInt32Test1()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = StringExtensions.ToInt32(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUtf8String
        ///</summary>
        [TestMethod()]
        public void ToUtf8StringTest()
        {
            IEnumerable<byte> bytes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.ToUtf8String(bytes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UInt64VersiontoString
        ///</summary>
        [TestMethod()]
        public void UInt64VersiontoStringTest()
        {
            ulong version = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.UInt64VersiontoString(version);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectBinaryForMachine
        ///</summary>
        [TestMethod()]
        public void UnprotectBinaryForMachineTest()
        {
            IEnumerable<byte> binaryData = null; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            actual = StringExtensions.UnprotectBinaryForMachine(binaryData, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectBinaryForUser
        ///</summary>
        [TestMethod()]
        public void UnprotectBinaryForUserTest()
        {
            IEnumerable<byte> binaryData = null; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            actual = StringExtensions.UnprotectBinaryForUser(binaryData, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectForMachine
        ///</summary>
        [TestMethod()]
        public void UnprotectForMachineTest()
        {
            IEnumerable<byte> binaryData = null; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.UnprotectForMachine(binaryData, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectForUser
        ///</summary>
        [TestMethod()]
        public void UnprotectForUserTest()
        {
            IEnumerable<byte> binaryData = null; // TODO: Initialize to an appropriate value
            string salt = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.UnprotectForUser(binaryData, salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VersionStringToUInt64
        ///</summary>
        [TestMethod()]
        public void VersionStringToUInt64Test()
        {
            string version = string.Empty; // TODO: Initialize to an appropriate value
            ulong expected = 0; // TODO: Initialize to an appropriate value
            ulong actual;
            actual = StringExtensions.VersionStringToUInt64(version);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for format
        ///</summary>
        [TestMethod()]
        public void formatTest()
        {
            string formatString = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringExtensions.format(formatString, args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for oldIsWildcardMatch
        ///</summary>
        [TestMethod()]
        public void oldIsWildcardMatchTest()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            string wildcardMask = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringExtensions.oldIsWildcardMatch(text, wildcardMask);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
