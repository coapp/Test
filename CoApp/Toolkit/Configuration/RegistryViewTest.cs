using System.Windows.Forms;
using CoApp.Toolkit.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Configuration
{
    
    
    /// <summary>
    ///This is a test class for RegistryViewTest and is intended
    ///to contain all RegistryViewTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RegistryViewTest
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
        ///A test for RegistryView Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void RegistryViewConstructorTest()
        {
            RegistryKey rootKey = null; // TODO: Initialize to an appropriate value
            string subKey = string.Empty; // TODO: Initialize to an appropriate value
            string valuename = string.Empty; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(rootKey, subKey, valuename);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RegistryView Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void RegistryViewConstructorTest1()
        {
            RegistryKey rootKey = null; // TODO: Initialize to an appropriate value
            string subKey = string.Empty; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(rootKey, subKey);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RegistryView Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void RegistryViewConstructorTest2()
        {
            RegistryKey rootKey = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(rootKey);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CastToEnum
        ///</summary>
        public void CastToEnumTestHelper<T>()
        {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = RegistryView_Accessor.CastToEnum<T>(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void CastToEnumTest()
        {
            CastToEnumTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CastToString
        ///</summary>
        public void CastToStringTestHelper<T>()
        {
            T value = default(T); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = RegistryView_Accessor.CastToString<T>(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void CastToStringTest()
        {
            CastToStringTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteSubkey
        ///</summary>
        [TestMethod()]
        public void DeleteSubkeyTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            string subkey = string.Empty; // TODO: Initialize to an appropriate value
            target.DeleteSubkey(subkey);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetEnumValue
        ///</summary>
        public void GetEnumValueTestHelper<T>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.GetEnumValue<T>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetEnumValueTest()
        {
            GetEnumValueTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ParseEnum
        ///</summary>
        public void ParseEnumTestHelper<T>()
        {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            T defaultValue = default(T); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = RegistryView_Accessor.ParseEnum<T>(value, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void ParseEnumTest()
        {
            ParseEnumTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SetEnumValue
        ///</summary>
        public void SetEnumValueTestHelper<T>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            T value = default(T); // TODO: Initialize to an appropriate value
            target.SetEnumValue<T>(value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void SetEnumValueTest()
        {
            SetEnumValueTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ApplicationSystem
        ///</summary>
        [TestMethod()]
        public void ApplicationSystemTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.ApplicationSystem;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ApplicationUser
        ///</summary>
        [TestMethod()]
        public void ApplicationUserTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.ApplicationUser;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BinaryValue
        ///</summary>
        [TestMethod()]
        public void BinaryValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            target.BinaryValue = expected;
            actual = target.BinaryValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BoolValue
        ///</summary>
        [TestMethod()]
        public void BoolValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.BoolValue = expected;
            actual = target.BoolValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClassesRoot
        ///</summary>
        [TestMethod()]
        public void ClassesRootTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.ClassesRoot;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CoAppSystem
        ///</summary>
        [TestMethod()]
        public void CoAppSystemTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.CoAppSystem;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CoAppUser
        ///</summary>
        [TestMethod()]
        public void CoAppUserTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.CoAppUser;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EncryptedBinaryValue
        ///</summary>
        [TestMethod()]
        public void EncryptedBinaryValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            IEnumerable<byte> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<byte> actual;
            target.EncryptedBinaryValue = expected;
            actual = target.EncryptedBinaryValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EncryptedStringValue
        ///</summary>
        [TestMethod()]
        public void EncryptedStringValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.EncryptedStringValue = expected;
            actual = target.EncryptedStringValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IntValue
        ///</summary>
        [TestMethod()]
        public void IntValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.IntValue = expected;
            actual = target.IntValue;
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
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            string keyName = string.Empty; // TODO: Initialize to an appropriate value
            string valueName = string.Empty; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = target[keyName, valueName];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            string keyName = string.Empty; // TODO: Initialize to an appropriate value
            string valueName = string.Empty; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = target[keyName, valueName];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LongValue
        ///</summary>
        [TestMethod()]
        public void LongValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            target.LongValue = expected;
            actual = target.LongValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadableKey
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void ReadableKeyTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            RegistryKey actual;
            actual = target.ReadableKey;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StringValue
        ///</summary>
        [TestMethod()]
        public void StringValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.StringValue = expected;
            actual = target.StringValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StringsValue
        ///</summary>
        [TestMethod()]
        public void StringsValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            target.StringsValue = expected;
            actual = target.StringsValue;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Subkeys
        ///</summary>
        [TestMethod()]
        public void SubkeysTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = target.Subkeys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for System
        ///</summary>
        [TestMethod()]
        public void SystemTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.System;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A custom test for System
        ///</summary>
        [TestMethod()]
        public void SystemTest_custom()
        {
            string output = global::CoApp.Toolkit.Configuration.RegistryView.System[@"SOFTWARE\Microsoft\Microsoft SDKs\Windows", "CurrentInstallFolder"].Value as string;
            MessageBox.Show(output);
            Assert.IsNotNull(output);
        }

        /// <summary>
        ///A test for User
        ///</summary>
        [TestMethod()]
        public void UserTest()
        {
            global::CoApp.Toolkit.Configuration.RegistryView actual;
            actual = global::CoApp.Toolkit.Configuration.RegistryView.User;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteableKey
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CoApp.Toolkit.dll")]
        public void WriteableKeyTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
            RegistryKey actual;
            actual = target.WriteableKey;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
