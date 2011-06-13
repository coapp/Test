using CoApp.Toolkit.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Tasks
{
    
    
    /// <summary>
    ///This is a test class for CoTaskFactoryTest and is intended
    ///to contain all CoTaskFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CoTaskFactoryTest
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
        ///A test for CoTaskFactory`1 Constructor
        ///</summary>
        public void CoTaskFactoryConstructorTest5Helper<TResult>()
        {
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(creationOptions, continuationOptions);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void CoTaskFactoryConstructorTest5()
        {
            CoTaskFactoryConstructorTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CoTaskFactory`1 Constructor
        ///</summary>
        public void CoTaskFactoryConstructorTest6Helper<TResult>()
        {
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(cancellationToken, creationOptions, continuationOptions, scheduler);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void CoTaskFactoryConstructorTest6()
        {
            CoTaskFactoryConstructorTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CoTaskFactory`1 Constructor
        ///</summary>
        public void CoTaskFactoryConstructorTest7Helper<TResult>()
        {
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(scheduler);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void CoTaskFactoryConstructorTest7()
        {
            CoTaskFactoryConstructorTest7Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CoTaskFactory`1 Constructor
        ///</summary>
        public void CoTaskFactoryConstructorTest8Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void CoTaskFactoryConstructorTest8()
        {
            CoTaskFactoryConstructorTest8Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CoTaskFactory`1 Constructor
        ///</summary>
        public void CoTaskFactoryConstructorTest9Helper<TResult>()
        {
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(cancellationToken);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void CoTaskFactoryConstructorTest9()
        {
            CoTaskFactoryConstructorTest9Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for AsTaskResult
        ///</summary>
        public void AsTaskResultTestHelper<TResult>()
        {
            TResult value = default(TResult); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = CoTaskFactory<TResult>.AsTaskResult(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void AsTaskResultTest()
        {
            AsTaskResultTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest48Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest48()
        {
            ContinueWhenAllTest48Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest49Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest49()
        {
            ContinueWhenAllTest49Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest50Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest50()
        {
            ContinueWhenAllTest50Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest51Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest51()
        {
            ContinueWhenAllTest51Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest52Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest52()
        {
            ContinueWhenAllTest52Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest53Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest53()
        {
            ContinueWhenAllTest53Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest54Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest54()
        {
            ContinueWhenAllTest54Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest55Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest55()
        {
            ContinueWhenAllTest55Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest56Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest56()
        {
            ContinueWhenAllTest56Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest57Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest57()
        {
            ContinueWhenAllTest57Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest58Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest58()
        {
            ContinueWhenAllTest58Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest59Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest59()
        {
            ContinueWhenAllTest59Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest60Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest60()
        {
            ContinueWhenAllTest60Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest61Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest61()
        {
            ContinueWhenAllTest61Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest62Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest62()
        {
            ContinueWhenAllTest62Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest63Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest63()
        {
            ContinueWhenAllTest63Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest64Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest64()
        {
            ContinueWhenAllTest64Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest65Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest65()
        {
            ContinueWhenAllTest65Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest66Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest66()
        {
            ContinueWhenAllTest66Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest67Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest67()
        {
            ContinueWhenAllTest67Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest68Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest68()
        {
            ContinueWhenAllTest68Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest69Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest69()
        {
            ContinueWhenAllTest69Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest70Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest70()
        {
            ContinueWhenAllTest70Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest71Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest71()
        {
            ContinueWhenAllTest71Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest48Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest48()
        {
            ContinueWhenAnyTest48Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest49Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest49()
        {
            ContinueWhenAnyTest49Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest50Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest50()
        {
            ContinueWhenAnyTest50Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest51Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest51()
        {
            ContinueWhenAnyTest51Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest52Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest52()
        {
            ContinueWhenAnyTest52Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest53Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest53()
        {
            ContinueWhenAnyTest53Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest54Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest54()
        {
            ContinueWhenAnyTest54Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest55Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest55()
        {
            ContinueWhenAnyTest55Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest56Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest56()
        {
            ContinueWhenAnyTest56Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest57Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest57()
        {
            ContinueWhenAnyTest57Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest58Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest58()
        {
            ContinueWhenAnyTest58Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest59Helper<TResult, TAntecedentResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest59()
        {
            ContinueWhenAnyTest59Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest60Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest60()
        {
            ContinueWhenAnyTest60Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest61Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest61()
        {
            ContinueWhenAnyTest61Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest62Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest62()
        {
            ContinueWhenAnyTest62Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest63Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest63()
        {
            ContinueWhenAnyTest63Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest64Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest64()
        {
            ContinueWhenAnyTest64Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest65Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest65()
        {
            ContinueWhenAnyTest65Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest66Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest66()
        {
            ContinueWhenAnyTest66Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest67Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest67()
        {
            ContinueWhenAnyTest67Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest68Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest68()
        {
            ContinueWhenAnyTest68Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest69Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest69()
        {
            ContinueWhenAnyTest69Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest70Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest70()
        {
            ContinueWhenAnyTest70Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest71Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest71()
        {
            ContinueWhenAnyTest71Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest66Helper<TResult, TArg1, TArg2>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest66()
        {
            FromAsyncTest66Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest67Helper<TResult, TArg1, TArg2>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest67()
        {
            FromAsyncTest67Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest68Helper<TResult, TArg1, TArg2>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest68()
        {
            FromAsyncTest68Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest69Helper<TResult, TArg1, TArg2>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest69()
        {
            FromAsyncTest69Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest70Helper<TResult, TArg1>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest70()
        {
            FromAsyncTest70Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest71Helper<TResult, TArg1>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest71()
        {
            FromAsyncTest71Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest72Helper<TResult, TArg1, TArg2>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest72()
        {
            FromAsyncTest72Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest73Helper<TResult, TArg1>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest73()
        {
            FromAsyncTest73Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest74Helper<TResult, TArg1, TArg2, TArg3>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest74()
        {
            FromAsyncTest74Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest75Helper<TResult, TArg1, TArg2, TArg3>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest75()
        {
            FromAsyncTest75Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest76Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest76()
        {
            FromAsyncTest76Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest77Helper<TResult, TArg1, TArg2, TArg3>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest77()
        {
            FromAsyncTest77Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest78Helper<TResult, TArg1, TArg2, TArg3>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest78()
        {
            FromAsyncTest78Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest79Helper<TResult, TArg1, TArg2>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest79()
        {
            FromAsyncTest79Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest80Helper<TResult, TArg1, TArg2, TArg3>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest80()
        {
            FromAsyncTest80Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest81Helper<TResult, TArg1, TArg2, TArg3>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest81()
        {
            FromAsyncTest81Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest82Helper<TResult, TArg1>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest82()
        {
            FromAsyncTest82Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest83Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest83()
        {
            FromAsyncTest83Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest84Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest84()
        {
            FromAsyncTest84Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest85Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest85()
        {
            FromAsyncTest85Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest86Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest86()
        {
            FromAsyncTest86Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest87Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest87()
        {
            FromAsyncTest87Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest88Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest88()
        {
            FromAsyncTest88Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest89Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest89()
        {
            FromAsyncTest89Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest90Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(asyncResult, endMethod, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest90()
        {
            FromAsyncTest90Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest91Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(beginMethod, endMethod, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest91()
        {
            FromAsyncTest91Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest92Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(beginMethod, endMethod, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest92()
        {
            FromAsyncTest92Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest93Helper<TResult, TArg1>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest93()
        {
            FromAsyncTest93Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest94Helper<TResult, TArg1>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest94()
        {
            FromAsyncTest94Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest95Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(beginMethod, endMethod, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest95()
        {
            FromAsyncTest95Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest96Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(beginMethod, endMethod, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest96()
        {
            FromAsyncTest96Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest97Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(beginMethod, endMethod, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest97()
        {
            FromAsyncTest97Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest98Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync(beginMethod, endMethod, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest98()
        {
            FromAsyncTest98Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest48Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest48()
        {
            StartNewTest48Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest49Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest49()
        {
            StartNewTest49Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest50Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest50()
        {
            StartNewTest50Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest51Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest51()
        {
            StartNewTest51Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest52Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest52()
        {
            StartNewTest52Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest53Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, cancellationToken, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest53()
        {
            StartNewTest53Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest54Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest54()
        {
            StartNewTest54Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest55Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest55()
        {
            StartNewTest55Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest56Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest56()
        {
            StartNewTest56Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest57Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest57()
        {
            StartNewTest57Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest58Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest58()
        {
            StartNewTest58Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest59Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest59()
        {
            StartNewTest59Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest60Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, cancellationToken, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest60()
        {
            StartNewTest60Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest61Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest61()
        {
            StartNewTest61Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest62Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest62()
        {
            StartNewTest62Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest63Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest63()
        {
            StartNewTest63Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest64Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest64()
        {
            StartNewTest64Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest65Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest65()
        {
            StartNewTest65Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest66Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest66()
        {
            StartNewTest66Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest67Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest67()
        {
            StartNewTest67Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest68Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest68()
        {
            StartNewTest68Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest69Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest69()
        {
            StartNewTest69Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest70Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest70()
        {
            StartNewTest70Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest71Helper<TResult>()
        {
            CoTaskFactory<TResult> target = new CoTaskFactory<TResult>(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew(function, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest71()
        {
            StartNewTest71Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CoTaskFactory Constructor
        ///</summary>
        [TestMethod()]
        public void CoTaskFactoryConstructorTest()
        {
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            CoTaskFactory target = new CoTaskFactory(creationOptions, continuationOptions);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CoTaskFactory Constructor
        ///</summary>
        [TestMethod()]
        public void CoTaskFactoryConstructorTest1()
        {
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            CoTaskFactory target = new CoTaskFactory(cancellationToken, creationOptions, continuationOptions, scheduler);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CoTaskFactory Constructor
        ///</summary>
        [TestMethod()]
        public void CoTaskFactoryConstructorTest2()
        {
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            CoTaskFactory target = new CoTaskFactory(scheduler);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CoTaskFactory Constructor
        ///</summary>
        [TestMethod()]
        public void CoTaskFactoryConstructorTest3()
        {
            CoTaskFactory target = new CoTaskFactory();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CoTaskFactory Constructor
        ///</summary>
        [TestMethod()]
        public void CoTaskFactoryConstructorTest4()
        {
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            CoTaskFactory target = new CoTaskFactory(cancellationToken);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTestHelper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest()
        {
            ContinueWhenAllTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest1Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest1()
        {
            ContinueWhenAllTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest2Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest2()
        {
            ContinueWhenAllTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest3Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest3()
        {
            ContinueWhenAllTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest4Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest4()
        {
            ContinueWhenAllTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest5Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest5()
        {
            ContinueWhenAllTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest6Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest6()
        {
            ContinueWhenAllTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest7Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest7()
        {
            ContinueWhenAllTest7Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest8Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest8()
        {
            ContinueWhenAllTest8Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest9Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest9()
        {
            ContinueWhenAllTest9Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest10Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest10()
        {
            ContinueWhenAllTest10Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest11Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest11()
        {
            ContinueWhenAllTest11Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest12Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest12()
        {
            ContinueWhenAllTest12Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest13Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest13()
        {
            ContinueWhenAllTest13Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest14Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest14()
        {
            ContinueWhenAllTest14Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest15Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest15()
        {
            ContinueWhenAllTest15Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest16Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest16()
        {
            ContinueWhenAllTest16Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest17Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest17()
        {
            ContinueWhenAllTest17Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest18Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest18()
        {
            ContinueWhenAllTest18Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest19Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest19()
        {
            ContinueWhenAllTest19Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest20Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest20()
        {
            ContinueWhenAllTest20Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest21Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest21()
        {
            ContinueWhenAllTest21Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest22Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest22()
        {
            ContinueWhenAllTest22Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest23Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>[], TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAll<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest23()
        {
            ContinueWhenAllTest23Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest24Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest24()
        {
            ContinueWhenAllTest24Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest25()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest26()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest27()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest28()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest29()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest30()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest31()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest32()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(tasks, continuationAction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest33()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest34()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest35()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAllTest36()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest37Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest37()
        {
            ContinueWhenAllTest37Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest38Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest38()
        {
            ContinueWhenAllTest38Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest39Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest39()
        {
            ContinueWhenAllTest39Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest40Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest40()
        {
            ContinueWhenAllTest40Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest41Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest41()
        {
            ContinueWhenAllTest41Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest42Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest42()
        {
            ContinueWhenAllTest42Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest43Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest43()
        {
            ContinueWhenAllTest43Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest44Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest44()
        {
            ContinueWhenAllTest44Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest45Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest45()
        {
            ContinueWhenAllTest45Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest46Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest46()
        {
            ContinueWhenAllTest46Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAll
        ///</summary>
        public void ContinueWhenAllTest47Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>[]> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAll<TAntecedentResult>(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAllTest47()
        {
            ContinueWhenAllTest47Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTestHelper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest()
        {
            ContinueWhenAnyTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest1Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest1()
        {
            ContinueWhenAnyTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest2Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest2()
        {
            ContinueWhenAnyTest2Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest3Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest3()
        {
            ContinueWhenAnyTest3Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest4Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest4()
        {
            ContinueWhenAnyTest4Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest5Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest5()
        {
            ContinueWhenAnyTest5Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest6Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest6()
        {
            ContinueWhenAnyTest6Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest7Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest7()
        {
            ContinueWhenAnyTest7Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest8Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest8()
        {
            ContinueWhenAnyTest8Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest9Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest9()
        {
            ContinueWhenAnyTest9Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest10Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest10()
        {
            ContinueWhenAnyTest10Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest11Helper<TAntecedentResult, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] tasks = null; // TODO: Initialize to an appropriate value
            Func<Task<TAntecedentResult>, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.ContinueWhenAny<TAntecedentResult, TResult>(tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest11()
        {
            ContinueWhenAnyTest11Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest12Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest12()
        {
            ContinueWhenAnyTest12Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest13Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest13()
        {
            ContinueWhenAnyTest13Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest14Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest14()
        {
            ContinueWhenAnyTest14Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest15Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest15()
        {
            ContinueWhenAnyTest15Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest16Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest16()
        {
            ContinueWhenAnyTest16Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest17Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest17()
        {
            ContinueWhenAnyTest17Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest18Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest18()
        {
            ContinueWhenAnyTest18Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest19Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest19()
        {
            ContinueWhenAnyTest19Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest20Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest20()
        {
            ContinueWhenAnyTest20Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest21Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest21()
        {
            ContinueWhenAnyTest21Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest22Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest22()
        {
            ContinueWhenAnyTest22Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest23Helper<TAntecedentResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task<TAntecedentResult>[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task<TAntecedentResult>> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TAntecedentResult>(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest23()
        {
            ContinueWhenAnyTest23Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest24Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest24()
        {
            ContinueWhenAnyTest24Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest25()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest26()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest27()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest28()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest29()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest30()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest31()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest32()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest33()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest34()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest35()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        [TestMethod()]
        public void ContinueWhenAnyTest36()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Action<Task> continuationAction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny(Tasks, continuationAction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest37Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest37()
        {
            ContinueWhenAnyTest37Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest38Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest38()
        {
            ContinueWhenAnyTest38Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest39Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest39()
        {
            ContinueWhenAnyTest39Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest40Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, continuationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest40()
        {
            ContinueWhenAnyTest40Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest41Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest41()
        {
            ContinueWhenAnyTest41Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest42Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest42()
        {
            ContinueWhenAnyTest42Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest43Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest43()
        {
            ContinueWhenAnyTest43Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest44Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest44()
        {
            ContinueWhenAnyTest44Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest45Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, continuationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest45()
        {
            ContinueWhenAnyTest45Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest46Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest46()
        {
            ContinueWhenAnyTest46Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContinueWhenAny
        ///</summary>
        public void ContinueWhenAnyTest47Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Task[] Tasks = null; // TODO: Initialize to an appropriate value
            Func<Task, TResult> continuationFunction = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskContinuationOptions continuationOptions = new TaskContinuationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.ContinueWhenAny<TResult>(Tasks, continuationFunction, cancellationToken, continuationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContinueWhenAnyTest47()
        {
            ContinueWhenAnyTest47Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTestHelper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(beginMethod, endMethod, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest()
        {
            FromAsyncTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest1Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(beginMethod, endMethod, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest1()
        {
            FromAsyncTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest2Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest2()
        {
            FromAsyncTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest3Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(beginMethod, endMethod, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest3()
        {
            FromAsyncTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest4Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(beginMethod, endMethod, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest4()
        {
            FromAsyncTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest5Helper<TArg1, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TResult>(beginMethod, endMethod, arg1, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest5()
        {
            FromAsyncTest5Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest6Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(beginMethod, endMethod, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest6()
        {
            FromAsyncTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest7Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(beginMethod, endMethod, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest7()
        {
            FromAsyncTest7Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest8Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest8()
        {
            FromAsyncTest8Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest9Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest9()
        {
            FromAsyncTest9Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest10Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest10()
        {
            FromAsyncTest10Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest11Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest11()
        {
            FromAsyncTest11Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest12Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest12()
        {
            FromAsyncTest12Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest13Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest13()
        {
            FromAsyncTest13Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest14Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest14()
        {
            FromAsyncTest14Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest15Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TResult>(asyncResult, endMethod, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest15()
        {
            FromAsyncTest15Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest16Helper<TArg1, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TResult>(beginMethod, endMethod, arg1, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest16()
        {
            FromAsyncTest16Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest17Helper<TArg1, TArg2, TArg3, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3, TResult>(beginMethod, endMethod, arg1, arg2, arg3, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest17()
        {
            FromAsyncTest17Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest18Helper<TArg1, TArg2, TArg3, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3, TResult>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest18()
        {
            FromAsyncTest18Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest19Helper<TArg1, TArg2, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TResult>(beginMethod, endMethod, arg1, arg2, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest19()
        {
            FromAsyncTest19Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest20Helper<TArg1, TArg2, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TResult>(beginMethod, endMethod, arg1, arg2, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest20()
        {
            FromAsyncTest20Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest21Helper<TArg1, TArg2, TArg3, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3, TResult>(beginMethod, endMethod, arg1, arg2, arg3, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest21()
        {
            FromAsyncTest21Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest22Helper<TArg1, TArg2, TArg3, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3, TResult>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest22()
        {
            FromAsyncTest22Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest23Helper<TArg1, TArg2, TArg3, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3, TResult>(beginMethod, endMethod, arg1, arg2, arg3, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest23()
        {
            FromAsyncTest23Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest24Helper<TArg1, TArg2, TArg3, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3, TResult>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest24()
        {
            FromAsyncTest24Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest25Helper<TArg1, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TResult>(beginMethod, endMethod, arg1, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest25()
        {
            FromAsyncTest25Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest26Helper<TArg1, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TResult>(beginMethod, endMethod, arg1, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest26()
        {
            FromAsyncTest26Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest27Helper<TArg1, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TResult>(beginMethod, endMethod, arg1, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest27()
        {
            FromAsyncTest27Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest28Helper<TArg1, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TResult>(beginMethod, endMethod, arg1, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest28()
        {
            FromAsyncTest28Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest29Helper<TArg1, TArg2, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TResult>(beginMethod, endMethod, arg1, arg2, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest29()
        {
            FromAsyncTest29Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest30Helper<TArg1, TArg2, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TResult>(beginMethod, endMethod, arg1, arg2, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest30()
        {
            FromAsyncTest30Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest31Helper<TArg1, TArg2, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TResult>(beginMethod, endMethod, arg1, arg2, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest31()
        {
            FromAsyncTest31Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest32Helper<TArg1, TArg2, TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Func<IAsyncResult, TResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.FromAsync<TArg1, TArg2, TResult>(beginMethod, endMethod, arg1, arg2, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest32()
        {
            FromAsyncTest32Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest33()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(beginMethod, endMethod, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest34()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(beginMethod, endMethod, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest35()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest36()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(beginMethod, endMethod, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest37()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(beginMethod, endMethod, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest38Helper<TArg1>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest38()
        {
            FromAsyncTest38Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest39()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(beginMethod, endMethod, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest40()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(beginMethod, endMethod, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest41()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest42()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest43()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest44()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest45()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest46()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest47()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        [TestMethod()]
        public void FromAsyncTest48()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            IAsyncResult asyncResult = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync(asyncResult, endMethod, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest49Helper<TArg1>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest49()
        {
            FromAsyncTest49Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest50Helper<TArg1, TArg2, TArg3>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest50()
        {
            FromAsyncTest50Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest51Helper<TArg1, TArg2, TArg3>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest51()
        {
            FromAsyncTest51Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest52Helper<TArg1, TArg2>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest52()
        {
            FromAsyncTest52Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest53Helper<TArg1, TArg2>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest53()
        {
            FromAsyncTest53Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest54Helper<TArg1, TArg2, TArg3>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest54()
        {
            FromAsyncTest54Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest55Helper<TArg1, TArg2, TArg3>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest55()
        {
            FromAsyncTest55Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest56Helper<TArg1, TArg2, TArg3>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest56()
        {
            FromAsyncTest56Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest57Helper<TArg1, TArg2, TArg3>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            TArg3 arg3 = default(TArg3); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest57()
        {
            FromAsyncTest57Helper<GenericParameterHelper, GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest58Helper<TArg1>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest58()
        {
            FromAsyncTest58Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest59Helper<TArg1>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest59()
        {
            FromAsyncTest59Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest60Helper<TArg1>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest60()
        {
            FromAsyncTest60Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest61Helper<TArg1>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest61()
        {
            FromAsyncTest61Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest62Helper<TArg1, TArg2>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest62()
        {
            FromAsyncTest62Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest63Helper<TArg1, TArg2>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest63()
        {
            FromAsyncTest63Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest64Helper<TArg1, TArg2>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest64()
        {
            FromAsyncTest64Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for FromAsync
        ///</summary>
        public void FromAsyncTest65Helper<TArg1, TArg2>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod = null; // TODO: Initialize to an appropriate value
            Action<IAsyncResult> endMethod = null; // TODO: Initialize to an appropriate value
            TArg1 arg1 = default(TArg1); // TODO: Initialize to an appropriate value
            TArg2 arg2 = default(TArg2); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FromAsyncTest65()
        {
            FromAsyncTest65Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTestHelper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest()
        {
            StartNewTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest1Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest1()
        {
            StartNewTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest2Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest2()
        {
            StartNewTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest3Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest3()
        {
            StartNewTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest4Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest4()
        {
            StartNewTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest5Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest5()
        {
            StartNewTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest6Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest6()
        {
            StartNewTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest7Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest7()
        {
            StartNewTest7Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest8Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest8()
        {
            StartNewTest8Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest9Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest9()
        {
            StartNewTest9Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest10Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest10()
        {
            StartNewTest10Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest11Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<TResult> function = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, cancellationToken, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest11()
        {
            StartNewTest11Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest12Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest12()
        {
            StartNewTest12Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest13Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest13()
        {
            StartNewTest13Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest14Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest14()
        {
            StartNewTest14Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest15Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest15()
        {
            StartNewTest15Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest16Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest16()
        {
            StartNewTest16Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest17Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest17()
        {
            StartNewTest17Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest18Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest18()
        {
            StartNewTest18Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest19Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest19()
        {
            StartNewTest19Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest20Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest20()
        {
            StartNewTest20Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest21Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest21()
        {
            StartNewTest21Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest22Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest22()
        {
            StartNewTest22Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        public void StartNewTest23Helper<TResult>()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Func<object, TResult> function = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task<TResult> expected = null; // TODO: Initialize to an appropriate value
            Task<TResult> actual;
            actual = target.StartNew<TResult>(function, state, cancellationToken, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void StartNewTest23()
        {
            StartNewTest23Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest24()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest25()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest26()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest27()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest28()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest29()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest30()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest31()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest32()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest33()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest34()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest35()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action action = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, cancellationToken, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest36()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest37()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest38()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest39()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, cancellationToken, creationOptions, scheduler, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest40()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, cancellationToken, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest41()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            IEnumerable<MessageHandlers> messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest42()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, cancellationToken);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest43()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, creationOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest44()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest45()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, creationOptions, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest46()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartNew
        ///</summary>
        [TestMethod()]
        public void StartNewTest47()
        {
            CoTaskFactory target = new CoTaskFactory(); // TODO: Initialize to an appropriate value
            Action<object> action = null; // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            CancellationToken cancellationToken = new CancellationToken(); // TODO: Initialize to an appropriate value
            TaskCreationOptions creationOptions = new TaskCreationOptions(); // TODO: Initialize to an appropriate value
            TaskScheduler scheduler = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.StartNew(action, state, cancellationToken, creationOptions, scheduler);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CompletedTask
        ///</summary>
        [TestMethod()]
        public void CompletedTaskTest()
        {
            Task actual;
            actual = CoTaskFactory.CompletedTask;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
