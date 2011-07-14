using CoApp.Toolkit.Spec;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.PropertySheet;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Spec
{
    
    
    /// <summary>
    ///This is a test class for ProcessTest and is intended
    ///to contain all ProcessTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcessTest
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

        /*
        /// <summary>
        ///A test for Process Constructor
        ///</summary>
        [TestMethod()]
        public void ProcessConstructorTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Process target = new Process(rule);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompileAs
        ///</summary>
        [TestMethod()]
        public void CompileAsTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Process target = new Process(rule); // TODO: Initialize to an appropriate value
            ProcessCompileAs expected = new ProcessCompileAs(); // TODO: Initialize to an appropriate value
            ProcessCompileAs actual;
            target.CompileAs = expected;
            actual = target.CompileAs;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IncludeDirectory
        ///</summary>
        [TestMethod()]
        public void IncludeDirectoryTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Process target = new Process(rule); // TODO: Initialize to an appropriate value
            IList<string> actual;
            actual = target.IncludeDirectory;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadOnlyStringPooling
        ///</summary>
        [TestMethod()]
        public void ReadOnlyStringPoolingTest()
        {
            Rule rule = null; // TODO: Initialize to an appropriate value
            Process target = new Process(rule); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ReadOnlyStringPooling = expected;
            actual = target.ReadOnlyStringPooling;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }*/
    }
}
