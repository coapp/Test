using CoApp.Toolkit.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.Toolkit.Engine.Core
{
    
    
    /// <summary>
    ///This is a test class for TestRegistryView and is intended
    ///to contain all TestRegistryView Unit Tests
    ///</summary>
    [TestClass()]
    public class TestRegistryView
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
///A test for DeleteSubkey
///</summary>
[TestMethod()]
public void TestDeleteSubkey()
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
public void TestGetEnumValueHelper<T>()

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
public void TestGetEnumValue()
{
    TestGetEnumValueHelper<GenericParameterHelper>();
}

/// <summary>
///A test for SetEnumValue
///</summary>
public void TestSetEnumValueHelper<T>()

{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
T value = default(T); // TODO: Initialize to an appropriate value
    target.SetEnumValue<T>(value);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

[TestMethod()]
public void TestSetEnumValue()
{
    TestSetEnumValueHelper<GenericParameterHelper>();
}

/// <summary>
///A test for ApplicationSystem
///</summary>
[TestMethod()]
public void TestApplicationSystem()
{
    RegistryView actual;
    actual = RegistryView.ApplicationSystem;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for ApplicationUser
///</summary>
[TestMethod()]
public void TestApplicationUser()
{
    RegistryView actual;
    actual = RegistryView.ApplicationUser;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for BinaryValue
///</summary>
[TestMethod()]
public void TestBinaryValue()
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
public void TestBoolValue()
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
public void TestClassesRoot()
{
    RegistryView actual;
    actual = RegistryView.ClassesRoot;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for CoAppSystem
///</summary>
[TestMethod()]
public void TestCoAppSystem()
{
    RegistryView actual;
    actual = RegistryView.CoAppSystem;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for CoAppUser
///</summary>
[TestMethod()]
public void TestCoAppUser()
{
    RegistryView actual;
    actual = RegistryView.CoAppUser;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for EncryptedBinaryValue
///</summary>
[TestMethod()]
public void TestEncryptedBinaryValue()
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
public void TestEncryptedStringValue()
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
public void TestIntValue()
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
public void TestItem()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
string keyName = string.Empty; // TODO: Initialize to an appropriate value
string valueName = string.Empty; // TODO: Initialize to an appropriate value
    RegistryView actual;
    actual = target[keyName, valueName];
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Item
///</summary>
[TestMethod()]
public void TestItem1()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistryView_Accessor target = new RegistryView_Accessor(param0); // TODO: Initialize to an appropriate value
string keyName = string.Empty; // TODO: Initialize to an appropriate value
string valueName = string.Empty; // TODO: Initialize to an appropriate value
    RegistryView actual;
    actual = target[keyName, valueName];
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for LongValue
///</summary>
[TestMethod()]
public void TestLongValue()
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
///A test for StringValue
///</summary>
[TestMethod()]
public void TestStringValue()
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
public void TestStringsValue()
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
public void TestSubkeys()
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
public void TestSystem()
{
    RegistryView actual;
    actual = RegistryView.System;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for User
///</summary>
[TestMethod()]
public void TestUser()
{
    RegistryView actual;
    actual = RegistryView.User;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Value
///</summary>
[TestMethod()]
public void TestValue()
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
    }
}
