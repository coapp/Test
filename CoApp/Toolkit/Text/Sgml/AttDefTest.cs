using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for AttDefTest and is intended
    ///to contain all AttDefTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AttDefTest
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
        ///A test for AttDef Constructor
        ///</summary>
        [TestMethod()]
        public void AttDefConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SetEnumeratedType
        ///</summary>
        [TestMethod()]
        public void SetEnumeratedTypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            string[] enumValues = null; // TODO: Initialize to an appropriate value
            AttributeType type = new AttributeType(); // TODO: Initialize to an appropriate value
            target.SetEnumeratedType(enumValues, type);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetPresence
        ///</summary>
        [TestMethod()]
        public void SetPresenceTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.SetPresence(token);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetType
        ///</summary>
        [TestMethod()]
        public void SetTypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            string type = string.Empty; // TODO: Initialize to an appropriate value
            target.SetType(type);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AttributePresence
        ///</summary>
        [TestMethod()]
        public void AttributePresenceTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            AttributePresence actual;
            actual = target.AttributePresence;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Default
        ///</summary>
        [TestMethod()]
        public void DefaultTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Default = expected;
            actual = target.Default;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EnumValues
        ///</summary>
        [TestMethod()]
        public void EnumValuesTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.EnumValues;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Type
        ///</summary>
        [TestMethod()]
        public void TypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AttDef target = new AttDef(name); // TODO: Initialize to an appropriate value
            AttributeType actual;
            actual = target.Type;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
