using CoApp.Toolkit.Spec;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Spec
{
    
    
    /// <summary>
    ///This is a test class for LinkTest and is intended
    ///to contain all LinkTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LinkTest
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
        ///A test for Link Constructor
        ///</summary>
        [TestMethod()]
        public void LinkConstructorTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Link target = new Link(rule);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Libraries
        ///</summary>
        [TestMethod()]
        public void LibrariesTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Link target = new Link(rule); // TODO: Initialize to an appropriate value
            IList<string> actual;
            actual = target.Libraries;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Output
        ///</summary>
        [TestMethod()]
        public void OutputTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Link target = new Link(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Output = expected;
            actual = target.Output;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Subsystem
        ///</summary>
        [TestMethod()]
        public void SubsystemTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Link target = new Link(rule); // TODO: Initialize to an appropriate value
            LinkSubsystem expected = new LinkSubsystem(); // TODO: Initialize to an appropriate value
            LinkSubsystem actual;
            target.Subsystem = expected;
            actual = target.Subsystem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Type
        ///</summary>
        [TestMethod()]
        public void TypeTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Link target = new Link(rule); // TODO: Initialize to an appropriate value
            LinkType expected = new LinkType(); // TODO: Initialize to an appropriate value
            LinkType actual;
            target.Type = expected;
            actual = target.Type;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
