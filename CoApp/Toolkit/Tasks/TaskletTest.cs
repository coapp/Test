using CoApp.Toolkit.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace Test.CoApp.Toolkit.Tasks
{
    
    
    /// <summary>
    ///This is a test class for TaskletTest and is intended
    ///to contain all TaskletTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TaskletTest
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
        ///A test for Tasklet Constructor
        ///</summary>
        [TestMethod()]
        public void TaskletConstructorTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Tasklet Constructor
        ///</summary>
        [TestMethod()]
        public void TaskletConstructorTest1()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Task parentTask = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task, parentTask);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddMessageHandler
        ///</summary>
        [TestMethod()]
        public void AddMessageHandlerTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            MessageHandlers handler = null; // TODO: Initialize to an appropriate value
            MessageHandlers expected = null; // TODO: Initialize to an appropriate value
            MessageHandlers actual;
            actual = target.AddMessageHandler(handler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddMessageHandlers
        ///</summary>
        [TestMethod()]
        public void AddMessageHandlersTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> handlers = null; // TODO: Initialize to an appropriate value
            target.AddMessageHandlers(handlers);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AsTask
        ///</summary>
        public void AsTaskTestHelper<TResult>()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.AsTask<TResult>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void AsTaskTest()
        {
            AsTaskTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetMessageHandler
        ///</summary>
        [TestMethod()]
        public void GetMessageHandlerTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            Type t = null; // TODO: Initialize to an appropriate value
            MessageHandlers expected = null; // TODO: Initialize to an appropriate value
            MessageHandlers actual;
            actual = target.GetMessageHandler(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WaitforChildTasks
        ///</summary>
        [TestMethod()]
        public void WaitforChildTasksTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            int millisecondsTimeout = 0; // TODO: Initialize to an appropriate value
            target.WaitforChildTasks(millisecondsTimeout);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WaitforChildTasks
        ///</summary>
        [TestMethod()]
        public void WaitforChildTasksTest1()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            target.WaitforChildTasks();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WaitforCurrentChildTasks
        ///</summary>
        [TestMethod()]
        public void WaitforCurrentChildTasksTest()
        {
            Tasklet.WaitforCurrentChildTasks();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WaitforCurrentChildTasks
        ///</summary>
        [TestMethod()]
        public void WaitforCurrentChildTasksTest1()
        {
            int millisecondsTimeout = 0; // TODO: Initialize to an appropriate value
            Tasklet.WaitforCurrentChildTasks(millisecondsTimeout);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        [TestMethod()]
        public void op_ImplicitTest()
        {
            Tasklet t = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = t;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        [TestMethod()]
        public void op_ImplicitTest1()
        {
            Task t = null; // TODO: Initialize to an appropriate value
            Tasklet expected = null; // TODO: Initialize to an appropriate value
            Tasklet actual;
            actual = t;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ChildTasks
        ///</summary>
        [TestMethod()]
        public void ChildTasksTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            IEnumerable<Task> actual;
            actual = target.ChildTasks;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentCancellationToken
        ///</summary>
        [TestMethod()]
        public void CurrentCancellationTokenTest()
        {
            CancellationToken actual;
            actual = Tasklet.CurrentCancellationToken;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentTask
        ///</summary>
        [TestMethod()]
        public void CurrentTaskTest()
        {
            Task actual;
            actual = Tasklet.CurrentTask;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentTasklet
        ///</summary>
        [TestMethod()]
        public void CurrentTaskletTest()
        {
            Tasklet actual;
            actual = Tasklet.CurrentTasklet;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsCancellationRequested
        ///</summary>
        [TestMethod()]
        public void IsCancellationRequestedTest()
        {
            bool actual;
            actual = Tasklet.IsCancellationRequested;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MessageHandlerList
        ///</summary>
        [TestMethod()]
        public void MessageHandlerListTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            List<MessageHandlers> actual;
            actual = target.MessageHandlerList;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParentTask
        ///</summary>
        [TestMethod()]
        public void ParentTaskTest()
        {
            Task task = null; // TODO: Initialize to an appropriate value
            Tasklet target = new Tasklet(task); // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ParentTask;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
