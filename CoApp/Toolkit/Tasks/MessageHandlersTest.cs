using CoApp.Toolkit.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Test.CoApp.Toolkit.Tasks
{
    
    
    /// <summary>
    ///This is a test class for MessageHandlersTest and is intended
    ///to contain all MessageHandlersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MessageHandlersTest
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
        ///A test for MessageHandlers`1 Constructor
        ///</summary>
        public void MessageHandlersConstructorTest1Helper<T>()
            where T : MessageHandlers, new()
        {
            MessageHandlers<T> target = new MessageHandlers<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MessageHandlersConstructorTest1()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call MessageHandlersConstructorTest1Helper<T>() with appropriate type par" +
                    "ameters.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        public void op_ImplicitTestHelper<T>()
            where T : MessageHandlers, new()
        {
            Tasklet coTask = null; // TODO: Initialize to an appropriate value
            MessageHandlers<T> expected = null; // TODO: Initialize to an appropriate value
            MessageHandlers<T> actual;
            actual = coTask;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ImplicitTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call op_ImplicitTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        public void op_ImplicitTest1Helper<T>()
            where T : MessageHandlers, new()
        {
            MessageHandlers<T> handlers = null; // TODO: Initialize to an appropriate value
            T expected = new T(); // TODO: Initialize to an appropriate value
            T actual;
            actual = handlers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ImplicitTest1()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call op_ImplicitTest1Helper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        public void op_ImplicitTest2Helper<T>()
            where T : MessageHandlers, new()
        {
            Task coTask = null; // TODO: Initialize to an appropriate value
            MessageHandlers<T> expected = null; // TODO: Initialize to an appropriate value
            MessageHandlers<T> actual;
            actual = coTask;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ImplicitTest2()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call op_ImplicitTest2Helper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for Invoke
        ///</summary>
        public void InvokeTestHelper<T>()
            where T : MessageHandlers, new()
        {
            T actual;
            actual = MessageHandlers<T>.Invoke;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void InvokeTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call InvokeTestHelper<T>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for MessageHandlers Constructor
        ///</summary>
        [TestMethod()]
        public void MessageHandlersConstructorTest()
        {
            MessageHandlers target = new MessageHandlers();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SetMissingDelegates
        ///</summary>
        [TestMethod()]
        public void SetMissingDelegatesTest()
        {
            MessageHandlers target = new MessageHandlers(); // TODO: Initialize to an appropriate value
            target.SetMissingDelegates();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
