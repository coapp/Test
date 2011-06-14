using System.Collections;
using System.IO;
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
        private static List<string> testStrings;

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
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            testStrings = new List<string>();
            StreamReader In = new StreamReader("..\\..\\..\\..\\Test\\CoApp\\Toolkit\\Extensions\\TestStrings.txt");
            //StreamReader In = new StreamReader("..\\Extensions\\TestStrings.txt");
            testStrings.AddRange(In.ReadToEnd().Split('\n'));
            In.Close();
        }
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
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\ContainStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\ContainStrings.csv", "ContainStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void ContainsIgnoreCaseTest()
        {
            IEnumerable<string> source = testStrings;
            string value = (string)testContextInstance.DataRow["STR"];
            bool expected = false;
            if ((int)testContextInstance.DataRow["exists"] > 0)
                expected = true;
            bool actual;
            actual = source.ContainsIgnoreCase(value);
            Assert.AreEqual(expected, actual, "String "+value+"  --  Expected: "+expected+"  Actual: "+actual);
        }

        /// <summary>
        ///A test for CreateGuid
        /// TR01: TODO: Confirm this test.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\GuidStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\GuidStrings.csv", "GUIDStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void CreateGuidTest()
        {
            string str = (string)testContextInstance.DataRow["STR"];
            string expected = (string)testContextInstance.DataRow["GUID"];
            Guid actual;
            actual = str.CreateGuid();
            Assert.IsTrue(expected.Equals(actual.ToString()), "GUID did not match.  Expected: "+expected+", Actual: "+actual);
        }

        /// <summary>
        ///A test for CreatePublicKeyToken
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void CreatePublicKeyTokenTest()
        {
            string publicKey = string.Empty;
            string expected = string.Empty;
            string actual;
            actual = publicKey.CreatePublicKeyToken();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Error
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ErrorTest()
        {
            string formatString = string.Empty;
            object[] args = null;
            formatString.Error(args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExtendVersion
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ExtendVersionTest()
        {
            string input = string.Empty;
            string expected = string.Empty;
            string actual;
            actual = input.ExtendVersion();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Compress/Decompress
        /// TR01: TODO: verify.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void CompressDecompressTest()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            byte[] bytes;
            bytes = input.Gzip();
            Assert.IsTrue(input.ToByteArray().LongLength > bytes.LongLength, "Compressed object is not smaller than decompressed object.");

            string output;
            output = bytes.Gunzip();
            Assert.AreEqual(input,output, "Decompressed output does not match input.");
        }

        /// <summary>
        ///A test for Compress64/Decompress64
        /// TR01: TODO: verify.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void CompressDecompress64Test()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            string compressed;
            compressed = input.GzipToBase64();
            Assert.IsTrue(input.ToByteArray().LongLength > compressed.ToByteArray().LongLength, "Compressed object is not smaller than decompressed object.");

            string output;
            output = compressed.GunzipFromBase64();
            Assert.AreEqual(input, output, "Decompressed output does not match input.");
        }

        /// <summary>
        ///A test for HasWildcardMatch
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\ContainStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\ContainStrings.csv", "ContainStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void HasWildcardMatchTest()
        {
            IEnumerable<string> source = testStrings;
            string value = (string)testContextInstance.DataRow["STR"];
            ///////////////
            string ignorePrefix = string.Empty;
            bool escapePrefix = false;
            bool expected = false;
            bool actual;
            actual = source.HasWildcardMatch(value, ignorePrefix, escapePrefix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsEmail
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\EmailStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\EmailStrings.csv", "EmailStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsEmailTest()
        {
            string email = (string)testContextInstance.DataRow["STR"];
            bool expected;
            if ((int)testContextInstance.DataRow["isEmail"] > 0)
                expected = true;
            else
                expected = false;
            bool actual;
            actual = email.IsEmail();
            Assert.AreEqual(expected, actual, "String \""+email+"\"  Expected: "+expected+"  Actual: "+actual);
        }

        /// <summary>
        ///A test for IsFalse
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\TrueFalseStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\TrueFalseStrings.csv", "TrueFalseStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsFalseTest()
        {
            string text = (string)testContextInstance.DataRow["STR"];
            bool expected = false;
            if ((int)testContextInstance.DataRow["False"] > 0)
                expected = true;
            bool actual;
            actual = text.IsFalse();
            Assert.AreEqual(expected, actual, "String \"" + text + "\"  Expected: " + expected + "  Actual: " + actual);
        }

        /// <summary>
        ///A test for IsTrue
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\TrueFalseStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\TrueFalseStrings.csv", "TrueFalseStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsTrueTest()
        {
            string text = (string)testContextInstance.DataRow["STR"];
            bool expected = false;
            if ((int)testContextInstance.DataRow["True"] > 0)
                expected = true;
            bool actual;
            actual = text.IsTrue();
            Assert.AreEqual(expected, actual, "String \"" + text + "\"  Expected: " + expected + "  Actual: " + actual);
        }

        /// <summary>
        ///A test for IsValidMajorMinorVersion
        /// TR01: TODO: Verify correct testing.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\VersionStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\VersionStrings.csv", "VersionStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsValidMajorMinorVersionTest()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            bool expected = false;
            if ((int)testContextInstance.DataRow["MajorMinor"] > 0)
                expected = true;
            bool actual;
            actual = input.IsValidMajorMinorVersion();
            Assert.AreEqual(expected, actual, "String \"" + input + "\"  Expected: " + expected + "  Actual: " + actual);
        }

        /// <summary>
        ///A test for IsValidVersion
        /// TR01: TODO: Verify correct testing.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\VersionStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\VersionStrings.csv", "VersionStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsValidVersionTest()
        {
            string input = (string) testContextInstance.DataRow["STR"];
            bool general = false;
            bool strict = false;
            bool expected = false;
            bool actual;
            if ((int) testContextInstance.DataRow["General"] > 0)
                general = true;
            if (general)
            {
                if ((int)testContextInstance.DataRow["Strict"] > 0)
                {
                    strict = true;
                    expected = true;
                    actual = input.IsValidVersion(strict);
                    Assert.AreEqual(expected, actual, "On input \""+input+"\": Is strict-compliant, failed strict test.");
                }
                strict = false;
                expected = true;
                actual = input.IsValidVersion(strict);
                Assert.AreEqual(expected, actual, "On input \"" + input + "\": Is generally compliant, failed non-strict test.");
            }
            else
            {
                actual = input.IsValidVersion(strict);
                Assert.AreEqual(expected, actual, "On input\"" + input + "\": non-compliant string was accepted as valid under non-strict.");
                strict = true;
                actual = input.IsValidVersion(strict);
                Assert.AreEqual(expected, actual, "On input\""+input+"\": non-compliant string was accepted as valid under strict.");
            }

        }

        /// <summary>
        ///A test for IsValidVersionPart
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void IsValidVersionPartTest()
        {
            string input = string.Empty;
            bool expected = false;
            bool actual;
            actual = input.IsValidVersionPart();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsWildcardMatch
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void IsWildcardMatchTest()
        {
            string text = string.Empty;
            string wildcardMask = string.Empty;
            string ignorePrefix = string.Empty;
            bool escapePrefix = false;
            bool expected = false;
            bool actual;
            actual = text.IsWildcardMatch(wildcardMask, ignorePrefix, escapePrefix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MD5Hash
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void MD5HashTest()
        {
            string input = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = input.MD5Hash();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeSafeDirectoryId
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void MakeSafeDirectoryIdTest()
        {
            string input = string.Empty;
            string expected = string.Empty;
            string actual;
            actual = input.MakeSafeDirectoryId();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Match
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void MatchTest()
        {
            string input = string.Empty;
            string rxExpression = string.Empty;
            Match expected = null;
            Match actual;
            actual = input.Match(rxExpression);
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
            actual = input.MatchIgnoreCase(rxExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnlyContains
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void OnlyContainsTest()
        {
            string str = string.Empty;
            string characters = string.Empty;
            bool expected = false;
            bool actual;
            actual = str.OnlyContains(characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnlyContains
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void OnlyContainsTest1()
        {
            string str = string.Empty;
            char[] characters = null;
            bool expected = false;
            bool actual;
            actual = str.OnlyContains(characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PositionOfFirstCharacterNotIn
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void PositionOfFirstCharacterNotInTest()
        {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string characters = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = str.PositionOfFirstCharacterNotIn(characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PositionOfFirstCharacterNotIn
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void PositionOfFirstCharacterNotInTest1()
        {
            string str = string.Empty;
            char[] characters = null;
            int expected = 0;
            int actual;
            actual = str.PositionOfFirstCharacterNotIn(characters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Print
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void PrintTest()
        {
            string formatString = string.Empty; 
            object[] args = null; 
            formatString.Print(args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ProtectBinaryForMachine
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ProtectBinaryForMachineTest()
        {
            IEnumerable<byte> binaryData = null;
            string salt = string.Empty;
            IEnumerable<byte> expected = null;
            IEnumerable<byte> actual;
            actual = binaryData.ProtectBinaryForMachine(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProtectBinaryForUser
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ProtectBinaryForUserTest()
        {
            IEnumerable<byte> binaryData = null;
            string salt = string.Empty;
            IEnumerable<byte> expected = null;
            IEnumerable<byte> actual;
            actual = binaryData.ProtectBinaryForUser(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProtectForMachine
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ProtectForMachineTest()
        {
            string text = string.Empty;
            string salt = string.Empty;
            IEnumerable<byte> expected = null;
            IEnumerable<byte> actual;
            actual = text.ProtectForMachine(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProtectForUser
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ProtectForUserTest()
        {
            string text = string.Empty;
            string salt = string.Empty;
            IEnumerable<byte> expected = null;
            IEnumerable<byte> actual;
            actual = text.ProtectForUser(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToByteArray
        ///</summary>
        [TestMethod()]
        public void ToByteArrayTest()
        {
            string text = "1aB\n\0k"; // Arbitrary string
            byte[] expected = { (byte)'1', (byte)'a', (byte)'B', (byte)'\n',(byte)'\0', (byte)'k'};
            byte[] actual;
            actual = text.ToByteArray();
            bool good = true;
            for (int i = 0; i < actual.Length; i++)
                if (actual[i] != expected[i])
                    good = false;
            Assert.IsTrue(good, "String \""+text+"\"  --  Expected: "+expected+"  Actual: "+actual);
        }

        /// <summary>
        ///A test for ToInt32
        ///</summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\NumericStrings.csv", "NumericStrings#csv", DataAccessMethod.Sequential), DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\NumericStrings.csv"), TestMethod()]
        public void ToInt32TestWithDefault()
        {
            string str = (string)testContextInstance.DataRow["STR"];
            int defaultValue = 30; // Arbitrary value
            int expected;
            if ((int)testContextInstance.DataRow["is32"] > 0)
                expected = int.Parse(str);
            else
                expected = defaultValue;
            int actual;
            actual = str.ToInt32(defaultValue);
            Assert.AreEqual(expected, actual, "String \"" + str + "\"  --  Expected: " + expected + "  Actual: " + actual);
        }

        /// <summary>
        ///A test for ToInt32
        ///</summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\NumericStrings.csv", "NumericStrings#csv", DataAccessMethod.Sequential), DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\NumericStrings.csv"), TestMethod()]
        public void ToInt32TestNoDefault()
        {
            string str = (string)testContextInstance.DataRow["STR"];
            int expected;
            if ((int)testContextInstance.DataRow["is32"] > 0)
                expected = int.Parse(str);
            else
                expected = 0;
            int actual;
            actual = str.ToInt32();
            Assert.AreEqual(expected, actual, "String \"" + str + "\"  --  Expected: " + expected + "  Actual: " + actual);
        }

        /// <summary>
        ///A test for ToUtf8String
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void ToUtf8StringTest()
        {
            IEnumerable<byte> bytes = null;
            string expected = string.Empty;
            string actual;
            actual = bytes.ToUtf8String();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UInt64VersiontoString
        ///</summary>
        [TestMethod()]
        public void UInt64VersiontoStringTest()
        {
            ulong version = 71777214294589695; // Arbitrary uint64
            string expected = "255.255.255.255"; // Matching version string
            string actual;
            actual = version.UInt64VersiontoString();
            Assert.AreEqual(expected, actual, "Version "+version+"  --  Expected: "+expected+"  Actual: "+actual);
        }

        /// <summary>
        ///A test for UnprotectBinaryForMachine
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void UnprotectBinaryForMachineTest()
        {
            IEnumerable<byte> binaryData = null;
            string salt = string.Empty;
            IEnumerable<byte> expected = null;
            IEnumerable<byte> actual;
            actual = binaryData.UnprotectBinaryForMachine(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectBinaryForUser
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void UnprotectBinaryForUserTest()
        {
            IEnumerable<byte> binaryData = null;
            string salt = string.Empty;
            IEnumerable<byte> expected = null;
            IEnumerable<byte> actual;
            actual = binaryData.UnprotectBinaryForUser(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectForMachine
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void UnprotectForMachineTest()
        {
            IEnumerable<byte> binaryData = null;
            string salt = string.Empty;
            string expected = string.Empty;
            string actual;
            actual = binaryData.UnprotectForMachine(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnprotectForUser
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void UnprotectForUserTest()
        {
            IEnumerable<byte> binaryData = null;
            string salt = string.Empty;
            string expected = string.Empty;
            string actual;
            actual = binaryData.UnprotectForUser(salt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VersionStringToUInt64
        ///</summary>
        [TestMethod()]
        public void VersionStringToUInt64Test()
        {
            string version = "255.255.255.255"; // Arbitrary version string
            ulong expected = 71777214294589695; // Matching uint64
            ulong actual;
            actual = version.VersionStringToUInt64();
            Assert.AreEqual(expected, actual, "Version "+version+"  --  Expected: "+expected+",  Actual: "+actual);
        }

        /// <summary>
        ///A test for format
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void FormatTest()
        {
            string formatString = string.Empty;
            object[] args = null;
            string expected = string.Empty;
            string actual;
            actual = formatString.format(args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for oldIsWildcardMatch
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void OldIsWildcardMatchTest()
        {
            string text = string.Empty;
            string wildcardMask = string.Empty;
            bool expected = false;
            bool actual;
            actual = text.OldIsWildcardMatch(wildcardMask);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
