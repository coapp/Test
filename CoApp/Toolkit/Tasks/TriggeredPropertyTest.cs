using CoApp.Toolkit.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.CoApp.Toolkit.Tasks
{
    
    
    /// <summary>
    ///This is a test class for TriggeredPropertyTest and is intended
    ///to contain all TriggeredPropertyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TriggeredPropertyTest
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
        ///A test for TriggeredProperty`1 Constructor
        ///</summary>
        public void TriggeredPropertyConstructorTestHelper<T>()
        {
            T initialValue = default(T); // TODO: Initialize to an appropriate value
            TriggeredProperty<T> target = new TriggeredProperty<T>(initialValue);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void TriggeredPropertyConstructorTest()
        {
            TriggeredPropertyConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TriggeredProperty`1 Constructor
        ///</summary>
        public void TriggeredPropertyConstructorTest1Helper<T>()
        {
            TriggeredProperty<T> target = new TriggeredProperty<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void TriggeredPropertyConstructorTest1()
        {
            TriggeredPropertyConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TriggeredProperty`1 Constructor
        ///</summary>
        public void TriggeredPropertyConstructorTest2Helper<T>()
        {
            T initialValue = default(T); // TODO: Initialize to an appropriate value
            Func<T, bool> condition = null; // TODO: Initialize to an appropriate value
            TriggeredProperty<T> target = new TriggeredProperty<T>(initialValue, condition);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void TriggeredPropertyConstructorTest2()
        {
            TriggeredPropertyConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TriggeredProperty`1 Constructor
        ///</summary>
        public void TriggeredPropertyConstructorTest3Helper<T>()
        {
            Func<T, bool> condition = null; // TODO: Initialize to an appropriate value
            TriggeredProperty<T> target = new TriggeredProperty<T>(condition);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void TriggeredPropertyConstructorTest3()
        {
            TriggeredPropertyConstructorTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for OnTrigger
        ///</summary>
        public void OnTriggerTestHelper<T>()
        {
            TriggeredProperty<T> target = new TriggeredProperty<T>(); // TODO: Initialize to an appropriate value
            Func<T, bool> condition = null; // TODO: Initialize to an appropriate value
            Action<T> notification = null; // TODO: Initialize to an appropriate value
            target.OnTrigger(condition, notification);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void OnTriggerTest()
        {
            OnTriggerTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        public void op_ImplicitTestHelper<T>()
        {
            TriggeredProperty<T> v = null; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = v;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ImplicitTest()
        {
            op_ImplicitTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Notification
        ///</summary>
        public void NotificationTestHelper<T>()
        {
            TriggeredProperty<T> target = new TriggeredProperty<T>(); // TODO: Initialize to an appropriate value
            Action<T> expected = null; // TODO: Initialize to an appropriate value
            Action<T> actual;
            target.Notification = expected;
            actual = target.Notification;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void NotificationTest()
        {
            NotificationTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        public void ValueTestHelper<T>()
        {
            TriggeredProperty<T> target = new TriggeredProperty<T>(); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ValueTest()
        {
            ValueTestHelper<GenericParameterHelper>();
        }
    }
}
