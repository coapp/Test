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
        private static List<string> Files;

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
            testStrings.AddRange(File.ReadLines("..\\..\\..\\..\\Test\\CoApp\\Toolkit\\Extensions\\TestStrings.txt"));
            Files = new List<string>();
            Files.AddRange(File.ReadLines("..\\..\\..\\..\\Test\\CoApp\\Toolkit\\Extensions\\FileList.txt"));
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
        ///A test for CreatePublicKeyToken
        /// TR01: TODO: Need more info to write this test.
        ///</summary>
        [TestMethod()]
        public void CreatePublicKeyTokenTest()
        {
            /*
            string publicKey = string.Empty;
            string expected = string.Empty;
            string actual;
            actual = publicKey.CreatePublicKeyToken();
            Assert.AreEqual(expected, actual);
            */
            Assert.Inconclusive("Unable to implement at this time.");
        }

        /// <summary>
        ///A test for ExtendVersion
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\VersionStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\VersionStrings.csv", "VersionStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void ExtendVersionTest()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            string expected = testContextInstance.DataRow["Padded"].ToString();
            string actual;
            actual = input.ExtendVersion();
            if (expected.IsNullOrEmpty())
                Assert.IsNull(actual, "On input \""+input+"\":  Padding should have failed.  Actual: \""+actual+"\"");
            else
                Assert.AreEqual(expected, actual, "On input \"" + input + "\":  Expected \"" + expected + "\", Actual \"" + actual + "\"");
        }

        /// <summary>
        ///A test for Compress/Decompress
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
        /// TR01: TODO: Need to write this test.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\HasWildCardStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\HasWildCardStrings.csv", "HasWildCardStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void HasWildcardMatchTest()
        {
            /*
            IEnumerable<string> source = testStrings;
            string value = (string)testContextInstance.DataRow["STR"];
            ///////////////
            string ignorePrefix = string.Empty;
            bool escapePrefix = false;
            bool expected = false;
            bool actual;
            actual = source.HasWildcardMatch(value, ignorePrefix, escapePrefix);
            Assert.AreEqual(expected, actual);
            */
            Assert.Inconclusive("Test not presently implemented.");
        }

/* TR01: Deprecated
        /// <summary>
        ///A test for IsWildcardMatch
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\IsWildStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\IsWildStrings.csv", "IsWildStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsWildcardMatchTest()
        {
            // I am intentionally using the most obnoxious file name I can make for test string.
            const string text = @"C:\CoApp\Test\CoApp\Toolkit\Extensions\StringExtensionsTest\This Is A Legit File Name In Windows ,.[]{};+-_=)(&^%$#@!~`'.txt";
            // A less obnoxious text string for comparing other tests against.
            const string lessText = @"C:\adirectory\another\andanother\stuff!\filename.file";
            string wildcardMask = (string)testContextInstance.DataRow["STR"];
            bool expected = (int)testContextInstance.DataRow["Exists"] > 0;
            bool actual;
            int pick = (int)testContextInstance.DataRow["UseText"];
            if (pick == 0)
                actual = text.IsWildcardMatch(wildcardMask);
            else
                actual = lessText.IsWildcardMatch(wildcardMask);
            Assert.AreEqual(expected, actual, "String " + pick + ": " + (string)testContextInstance.DataRow["Msg"]);
        }
*/

        /// <summary>
        ///A test for IsWildcardMatch on the "Happy path"
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\Wildcards.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\Wildcards.csv", "Wildcards#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsWildcardMatchTest_Happy()
        {
            const string Special1 = @"http://somewhere.net/a_%5b^place%5d/";
            const string Special2 = @"with*specials/in!path/%26that is/";  // I checked, an asterisk is a valid URL/URI character.  (RFC 2396)
            const string Special3 = @"~fairly$24long/for/package.pkg";
            const string NotSpecial1 = @"C:/local/location/of/";
            const string NotSpecial2 = @"significant/length/but/with/";
            const string NotSpecial3 = @"no/specials/for/package.pkg";

            bool actual;
            string w1, w2, w3;
            bool useSpecial = ((string)testContextInstance.DataRow["Specials"]).Equals("yes");
            w1 = (string) testContextInstance.DataRow["Wild1"];
            w2 = (string)testContextInstance.DataRow["Wild2"];
            w3 = (string)testContextInstance.DataRow["Wild3"];

            string mask = "";
            if (useSpecial)
            {
                Random R = new Random();
                int start, len;

                // first possible wild
                switch (w1)
                {
                    case "_":
                        mask += Special1;
                        break;
                    case "?":
                        int split = R.Next(Special1.Length);
                        mask += Special1.Substring(0, split);
                        mask += '?';
                        mask += Special1.Substring(split + 1);
                        break;
                    case "*":
                        // the while loop will prevent a '*' from crossing a path boundry
                        do
                        {
                            start = R.Next(Special1.Length);
                            len = R.Next(Special1.Length - start);
                        } while (Special1.Substring(start, len).Contains(@"/"));
                        mask += Special1.Substring(0, start);
                        mask += @"*";
                        mask += Special1.Substring(start + len);
                        break;
                    case "**":
                        int rnd = R.Next(Special1.Length);
                        start = Special1.Substring(0, rnd).LastIndexOf(@"/");
                        if (start < 0)
                            start = 0;
                        mask += @"**";
                        mask += Special1.Substring(start);
                        break;
                    default:
                        Assert.Fail("Unrecognized wildcard designator from file: '" + w1 + "'");
                        break;
                }

                // second possible wild
                switch (w2)
                {
                    case "_":
                        mask += Special2;
                        break;
                    case "?":
                        int split = R.Next(Special2.Length);
                        mask += Special2.Substring(0, split);
                        mask += '?';
                        mask += Special2.Substring(split + 1);
                        break;
                    case "*":
                        // the while loop will prevent a '*' from crossing a path boundry
                        do
                        {
                            start = R.Next(Special2.Length);
                            len = R.Next(Special2.Length - start);
                        } while (Special2.Substring(start, len).Contains(@"/"));
                        mask += Special2.Substring(0, start);
                        mask += @"*";
                        mask += Special2.Substring(start + len);
                        break;
                    case "**":
                        int rnd = R.Next(Special2.Length);
                        start = Special2.Substring(0, rnd).LastIndexOf(@"/") + 1;
                        len = Special2.Substring(start).LastIndexOf(@"/");
                        mask += Special2.Substring(0, start);
                        mask += @"**";
                        mask += Special2.Substring(start + len);
                        break;
                    default:
                        Assert.Fail("Unrecognized wildcard designator from file: '" + w1 + "'");
                        break;
                }

                // third possible wild
                switch (w3)
                {
                    case "_":
                        mask += Special3;
                        break;
                    case "?":
                        int split = R.Next(Special3.Length);
                        mask += Special3.Substring(0, split);
                        mask += '?';
                        mask += Special3.Substring(split + 1);
                        break;
                    case "*":
                        start = Special3.LastIndexOf(@"/")+1;
                        mask += Special3.Substring(0, start);
                        mask += @"*";
                        break;
                    case "**":
                        int rnd = R.Next(Special3.Length);
                        start = Special3.Substring(0, rnd).LastIndexOf(@"/") + 1;
                        len = Special3.Substring(start).LastIndexOf(@"/");
                        mask += Special3.Substring(0, start);
                        mask += @"**";
                        if (len > 0)
                            mask += Special3.Substring(start + len);
                        break;
                    default:
                        Assert.Fail("Unrecognized wildcard designator from file: '" + w1 + "'");
                        break;
                }
                actual = (Special1+Special2+Special3).IsWildcardMatch(mask);
            }
            else
            {
                Random R = new Random();
                int start, len;

                // first possible wild
                switch (w1)
                {
                    case "_":
                        mask += NotSpecial1;
                        break;
                    case "?":
                        int split = R.Next(NotSpecial1.Length);
                        mask += NotSpecial1.Substring(0, split);
                        mask += '?';
                        mask += NotSpecial1.Substring(split + 1);
                        break;
                    case "*":
                        // the while loop will prevent a '*' from crossing a path boundry
                        do
                        {
                            start = R.Next(NotSpecial1.Length);
                            len = R.Next(NotSpecial1.Length - start);
                        } while (NotSpecial1.Substring(start, len).Contains(@"/"));
                        mask += NotSpecial1.Substring(0, start);
                        mask += @"*";
                        mask += NotSpecial1.Substring(start + len);
                        break;
                    case "**":
                        int rnd = R.Next(NotSpecial1.Length);
                        start = NotSpecial1.Substring(0, rnd).LastIndexOf(@"/");
                        if (start < 0)
                            start = 0;
                        mask += @"**";
                        mask += NotSpecial1.Substring(start);
                        break;
                    default:
                        Assert.Fail("Unrecognized wildcard designator from file: '" + w1 + "'");
                        break;
                }

                // second possible wild
                switch (w2)
                {
                    case "_":
                        mask += NotSpecial2;
                        break;
                    case "?":
                        int split = R.Next(NotSpecial2.Length);
                        mask += NotSpecial2.Substring(0, split);
                        mask += '?';
                        mask += NotSpecial2.Substring(split + 1);
                        break;
                    case "*":
                        // the while loop will prevent a '*' from crossing a path boundry
                        do
                        {
                            start = R.Next(NotSpecial2.Length);
                            len = R.Next(NotSpecial2.Length - start);
                        } while (NotSpecial2.Substring(start, len).Contains(@"/"));
                        mask += NotSpecial2.Substring(0, start);
                        mask += @"*";
                        mask += NotSpecial2.Substring(start + len);
                        break;
                    case "**":
                        int rnd = R.Next(NotSpecial2.Length);
                        start = NotSpecial2.Substring(0, rnd).LastIndexOf(@"/") + 1;
                        len = NotSpecial2.Substring(start).LastIndexOf(@"/");
                        mask += NotSpecial2.Substring(0, start);
                        mask += @"**";
                        mask += NotSpecial2.Substring(start + len);
                        break;
                    default:
                        Assert.Fail("Unrecognized wildcard designator from file: '" + w1 + "'");
                        break;
                }

                // third possible wild
                switch (w3)
                {
                    case "_":
                        mask += NotSpecial3;
                        break;
                    case "?":
                        int split = R.Next(NotSpecial3.Length);
                        mask += NotSpecial3.Substring(0, split);
                        mask += '?';
                        mask += NotSpecial3.Substring(split + 1);
                        break;
                    case "*":
                        start = NotSpecial3.LastIndexOf(@"/")+1;
                        mask += NotSpecial3.Substring(0, start);
                        mask += @"*";
                        break;
                    case "**":
                        int rnd = R.Next(NotSpecial3.Length);
                        start = NotSpecial3.Substring(0, rnd).LastIndexOf(@"/") + 1;
                        len = NotSpecial3.Substring(start).LastIndexOf(@"/");
                        mask += NotSpecial3.Substring(0, start);
                        mask += @"**";
                        if (len > 0)
                            mask += NotSpecial3.Substring(start + len);
                        break;
                    default:
                        Assert.Fail("Unrecognized wildcard designator from file: '" + w1 + "'");
                        break;
                }
                actual = (NotSpecial1 + NotSpecial2 + NotSpecial3).IsWildcardMatch(mask);
            }// end else
            Assert.IsTrue(actual, "Failed on "+(useSpecial?"Specials":"No-Specials")+":  Mask = \""+mask+"\"");
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
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\VersionStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\VersionStrings.csv", "VersionStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void IsValidVersionTest()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

/*  TR01:  TODO: Not doing this right now...
        /// <summary>
        ///A test for MD5Hash
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void MD5HashTest()
        {
            string input = (string) testContextInstance.DataRow["STR"];
            string expected = (string) testContextInstance.DataRow["MD5"];
            string actual;
            actual = input.MD5Hash();
            Assert.AreEqual(expected, actual);
        }
*/
        /// <summary>
        ///A test for MakeSafeDirectoryId
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\DirStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\DirStrings.csv", "DirStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void MakeSafeDirectoryIdTest()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            string expected = (string)testContextInstance.DataRow["Safe"];
            string actual;
            actual = input.MakeSafeDirectoryId();
            Assert.AreEqual(expected, actual, "Failed on input \""+input+"\"");
        }

        /// <summary>
        ///A test for OnlyContains
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CharStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CharStrings.csv", "CharStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void OnlyContainsTest()
        {
            string str = "This is a test string. It is only a test string. Please use other strings for tying knots.";
            string characters = (string)testContextInstance.DataRow["STR"];
            bool expected = (int)testContextInstance.DataRow["Present"] > 0;
            bool actual;
            actual = str.OnlyContains(characters);
            Assert.AreEqual(expected, actual, "Failed unexpectedly on test string for characters: "+characters);
        }

        /// <summary>
        ///A test for PositionOfFirstCharacterNotIn
        /// missing doc from method:
        ///     Iterates through the character array (or string) parameter.
        ///     Will return the first index of the calling string which contains a character (Case-Sensitive!) not present in the parameter.
        ///     If the end of the calling string is reached, will return the length of the calling string.
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CharStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CharStrings.csv", "CharStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void PositionOfFirstCharacterNotInTest()
        {
            
            string str = "This is a test string. It is only a test string. Please use other strings for tying knots.";
            string characters = (string)testContextInstance.DataRow["STR"];
            int expected = (int)testContextInstance.DataRow["FirstNon"];
            int actual;
            actual = str.PositionOfFirstCharacterNotIn(characters);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ProtectBinaryForMachine/UnprotectBinaryForMachine
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void ProtectBinaryForMachineTest()
        {
            IEnumerable<byte> input = ((string)testContextInstance.DataRow["STR"]).ToByteArray();
            IEnumerable<byte> protectedData;
            protectedData = input.ProtectBinaryForMachine();

            IEnumerable<byte> output;
            output = protectedData.UnprotectBinaryForMachine();
            Assert.AreEqual(input.ToString(), output.ToString(), "Protect/Unprotect round trip failed.");
        }

        /// <summary>
        ///A test for ProtectBinaryForUser/UnprotectBinaryForUser
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void ProtectBinaryForUserTest()
        {
            IEnumerable<byte> input = ((string)testContextInstance.DataRow["STR"]).ToByteArray();
            IEnumerable<byte> protectedData;
            protectedData = input.ProtectBinaryForUser();
            
            IEnumerable<byte> output;
            output = protectedData.UnprotectBinaryForUser();
            Assert.AreEqual(input.ToString(), output.ToString(), "Protect/Unprotect round trip failed.");
        }

        /// <summary>
        ///A test for ProtectForMachine/UnprotectForMachine
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void ProtectForMachineTest()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            IEnumerable<byte> protectedData;
            protectedData = input.ProtectForMachine();

            string output;
            output = protectedData.UnprotectForMachine();
            Assert.AreEqual(input, output, "Protect/Unprotect round trip failed.");
        }

        /// <summary>
        ///A test for ProtectForUser/UnprotectForUser
        ///</summary>
        [DeploymentItem("..\\Test\\CoApp\\Toolkit\\Extensions\\CompressStrings.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Extensions\\CompressStrings.csv", "CompressStrings#csv", DataAccessMethod.Sequential), TestMethod()]
        public void ProtectForUserTest()
        {
            string input = (string)testContextInstance.DataRow["STR"];
            IEnumerable<byte> protectedData;
            protectedData = input.ProtectForUser();

            string output;
            output = protectedData.UnprotectForUser();
            Assert.AreEqual(input, output, "Protect/Unprotect round trip failed.");
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

    }
}
