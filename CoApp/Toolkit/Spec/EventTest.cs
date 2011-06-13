using CoApp.Toolkit.Spec;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;

namespace Test.CoApp.Toolkit.Spec
{
    
    
    /// <summary>
    ///This is a test class for EventTest and is intended
    ///to contain all EventTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EventTest
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
        ///A test for Event Constructor
        ///</summary>
        [TestMethod()]
        public void EventConstructorTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Event target = new Event(rule);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Condition
        ///</summary>
        [TestMethod()]
        public void ConditionTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Event target = new Event(rule); // TODO: Initialize to an appropriate value
            EventCondition expected = new EventCondition(); // TODO: Initialize to an appropriate value
            EventCondition actual;
            target.Condition = expected;
            actual = target.Condition;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Priority
        ///</summary>
        [TestMethod()]
        public void PriorityTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Event target = new Event(rule); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Priority = expected;
            actual = target.Priority;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Script
        ///</summary>
        [TestMethod()]
        public void ScriptTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Event target = new Event(rule); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Script = expected;
            actual = target.Script;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
