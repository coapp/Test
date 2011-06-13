using CoApp.Toolkit.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Tasks
{
    
    
    /// <summary>
    ///This is a test class for TaskExtensionsTest and is intended
    ///to contain all TaskExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TaskExtensionsTest
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
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTestHelper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest()
        {
            ContinueWithParentTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest1Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest1()
        {
            ContinueWithParentTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest2Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest2()
        {
            ContinueWithParentTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest3Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest3()
        {
            ContinueWithParentTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest4Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest4()
        {
            ContinueWithParentTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest5Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest5()
        {
            ContinueWithParentTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest6Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest6()
        {
            ContinueWithParentTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest7Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest7()
        {
            ContinueWithParentTest7Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest8Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest8()
        {
            ContinueWithParentTest8Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest9Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest9()
        {
            ContinueWithParentTest9Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest10Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest10()
        {
            ContinueWithParentTest10Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest11Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest11()
        {
            ContinueWithParentTest11Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest12Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest12()
        {
            ContinueWithParentTest12Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest13Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest13()
        {
            ContinueWithParentTest13Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest14Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest14()
        {
            ContinueWithParentTest14Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest15Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest15()
        {
            ContinueWithParentTest15Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest16Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest16()
        {
            ContinueWithParentTest16Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest17Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest17()
        {
            ContinueWithParentTest17Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest18Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest18()
        {
            ContinueWithParentTest18Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest19Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest19()
        {
            ContinueWithParentTest19Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest20Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest20()
        {
            ContinueWithParentTest20Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest21Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest21()
        {
            ContinueWithParentTest21Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest22Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest22()
        {
            ContinueWithParentTest22Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest23Helper<TResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task<TResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest23()
        {
            ContinueWithParentTest23Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest24Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest24()
        {
            ContinueWithParentTest24Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest25Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest25()
        {
            ContinueWithParentTest25Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest26Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest26()
        {
            ContinueWithParentTest26Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest27Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest27()
        {
            ContinueWithParentTest27Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest28Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest28()
        {
            ContinueWithParentTest28Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest29Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest29()
        {
            ContinueWithParentTest29Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest30Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest30()
        {
            ContinueWithParentTest30Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest31Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest31()
        {
            ContinueWithParentTest31Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest32Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest32()
        {
            ContinueWithParentTest32Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest33Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest33()
        {
            ContinueWithParentTest33Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest34Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest34()
        {
            ContinueWithParentTest34Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest35Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest35()
        {
            ContinueWithParentTest35Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest36Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest36()
        {
            ContinueWithParentTest36Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest37Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest37()
        {
            ContinueWithParentTest37Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest38Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest38()
        {
            ContinueWithParentTest38Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest39Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest39()
        {
            ContinueWithParentTest39Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest40Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest40()
        {
            ContinueWithParentTest40Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest41Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest41()
        {
            ContinueWithParentTest41Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest42Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest42()
        {
            ContinueWithParentTest42Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest43Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest43()
        {
            ContinueWithParentTest43Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest44Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest44()
        {
            ContinueWithParentTest44Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest45Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest45()
        {
            ContinueWithParentTest45Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest46Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest46()
        {
            ContinueWithParentTest46Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest47Helper<TResult, TNewResult>()
        {
            Task<TResult> thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task<TResult>, TNewResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TNewResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult, TNewResult>(thisTask, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest47()
        {
            ContinueWithParentTest47Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest48()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest49()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest50()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest51()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest52()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest53()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest54()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest55()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest56()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest57()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest58()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest59()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest60()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest61()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest62()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest63()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest64()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest65()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest66()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest67()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest68()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest69()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest70()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        [TestMethod()]
        public void ContinueWithParentTest71()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent(thisTask, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest72Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest72()
        {
            ContinueWithParentTest72Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest73Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest73()
        {
            ContinueWithParentTest73Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest74Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest74()
        {
            ContinueWithParentTest74Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest75Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest75()
        {
            ContinueWithParentTest75Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest76Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest76()
        {
            ContinueWithParentTest76Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest77Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest77()
        {
            ContinueWithParentTest77Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest78Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest78()
        {
            ContinueWithParentTest78Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest79Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest79()
        {
            ContinueWithParentTest79Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest80Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest80()
        {
            ContinueWithParentTest80Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest81Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest81()
        {
            ContinueWithParentTest81Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest82Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest82()
        {
            ContinueWithParentTest82Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest83Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest83()
        {
            ContinueWithParentTest83Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest84Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest84()
        {
            ContinueWithParentTest84Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest85Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest85()
        {
            ContinueWithParentTest85Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest86Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest86()
        {
            ContinueWithParentTest86Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest87Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest87()
        {
            ContinueWithParentTest87Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest88Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest88()
        {
            ContinueWithParentTest88Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest89Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest89()
        {
            ContinueWithParentTest89Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest90Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest90()
        {
            ContinueWithParentTest90Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest91Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest91()
        {
            ContinueWithParentTest91Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest92Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest92()
        {
            ContinueWithParentTest92Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest93Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest93()
        {
            ContinueWithParentTest93Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest94Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest94()
        {
            ContinueWithParentTest94Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWithParent
        ///</summary>
        public void ContinueWithParentTest95Helper<TResult>()
        {
            Task thisTask = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = global::CoApp.Toolkit.Tasks.TaskExtensions.ContinueWithParent<TResult>(thisTask, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWithParentTest95()
        {
            ContinueWithParentTest95Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Ignore
        ///</summary>
        [TestMethod()]
        public void IgnoreTest()
        {
            AggregateException aggregateException = null; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            Action saySomething = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Tasks.TaskExtensions.Ignore(aggregateException, type, saySomething);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Iterate
        ///</summary>
        public void IterateTestHelper<TResult>()
        {
            TaskCompletionSource<TResult> tcs = null; // TODO: Initialize to an appropriate value
            IEnumerable<Task> asyncIterator = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Tasks.TaskExtensions.Iterate<TResult>(tcs, asyncIterator);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void IterateTest()
        {
            IterateTestHelper<GenericParameterHelper>();
        }
    }
}
