using CoApp.Toolkit.DynamicXml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Dynamic;

namespace Test.CoApp.Toolkit.DynamicXml
{
    
    
    /// <summary>
    ///This is a test class for DynamicNodeTest and is intended
    ///to contain all DynamicNodeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DynamicNodeTest
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
        ///A test for DynamicNode Constructor
        ///</summary>
        [TestMethod()]
        public void DynamicNodeConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(name);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DynamicNode Constructor
        ///</summary>
        [TestMethod()]
        public void DynamicNodeConstructorTest1()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            DynamicNode expected = null; // TODO: Initialize to an appropriate value
            DynamicNode actual;
            actual = target.Add(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TryConvert
        ///</summary>
        [TestMethod()]
        public void TryConvertTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            ConvertBinder binder = null; // TODO: Initialize to an appropriate value
            object result = null; // TODO: Initialize to an appropriate value
            object resultExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TryConvert(binder, out result);
            Assert.AreEqual(resultExpected, result);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TryGetMember
        ///</summary>
        [TestMethod()]
        public void TryGetMemberTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            GetMemberBinder binder = null; // TODO: Initialize to an appropriate value
            object result = null; // TODO: Initialize to an appropriate value
            object resultExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TryGetMember(binder, out result);
            Assert.AreEqual(resultExpected, result);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TryInvokeMember
        ///</summary>
        [TestMethod()]
        public void TryInvokeMemberTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            InvokeMemberBinder binder = null; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            object result = null; // TODO: Initialize to an appropriate value
            object resultExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TryInvokeMember(binder, args, out result);
            Assert.AreEqual(resultExpected, result);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrySetMember
        ///</summary>
        [TestMethod()]
        public void TrySetMemberTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            SetMemberBinder binder = null; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.TrySetMember(binder, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            DynamicNode actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Node
        ///</summary>
        [TestMethod()]
        public void NodeTest()
        {
            XElement node = null; // TODO: Initialize to an appropriate value
            DynamicNode target = new DynamicNode(node); // TODO: Initialize to an appropriate value
            XElement actual;
            actual = target.Node;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
