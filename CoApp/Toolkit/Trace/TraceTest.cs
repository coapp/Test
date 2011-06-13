using CoApp.Toolkit.Trace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CoApp.Toolkit.Trace
{
    
    
    /// <summary>
    ///This is a test class for TraceTest and is intended
    ///to contain all TraceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TraceTest
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
        ///A test for Trace Constructor
        ///</summary>
        [TestMethod()]
        public void TraceConstructorTest()
        {
            global::CoApp.Toolkit.Trace.Trace target = new global::CoApp.Toolkit.Trace.Trace();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            global::CoApp.Toolkit.Trace.Trace target = new global::CoApp.Toolkit.Trace.Trace(); // TODO: Initialize to an appropriate value
            Process aProcess = null; // TODO: Initialize to an appropriate value
            Process expected = null; // TODO: Initialize to an appropriate value
            Process actual;
            actual = target.Add(aProcess);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Trace.Trace expected = null; // TODO: Initialize to an appropriate value
            global::CoApp.Toolkit.Trace.Trace actual;
            actual = global::CoApp.Toolkit.Trace.Trace.Load(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            global::CoApp.Toolkit.Trace.Trace target = new global::CoApp.Toolkit.Trace.Trace(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            target.Save(path);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetParentProcessId
        ///</summary>
        [TestMethod()]
        public void SetParentProcessIdTest()
        {
            global::CoApp.Toolkit.Trace.Trace target = new global::CoApp.Toolkit.Trace.Trace(); // TODO: Initialize to an appropriate value
            Process proc = null; // TODO: Initialize to an appropriate value
            int ppid = 0; // TODO: Initialize to an appropriate value
            target.SetParentProcessId(proc, ppid);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
