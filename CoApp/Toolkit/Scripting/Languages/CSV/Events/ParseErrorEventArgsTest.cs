using CoApp.Toolkit.Scripting.Languages.CSV.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Languages.CSV.Exceptions;
using CoApp.Toolkit.Scripting.Languages.CSV;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSV.Events
{
    
    
    /// <summary>
    ///This is a test class for ParseErrorEventArgsTest and is intended
    ///to contain all ParseErrorEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ParseErrorEventArgsTest
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
        ///A test for ParseErrorEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void ParseErrorEventArgsConstructorTest()
        {
            MalformedCsvException error = null; // TODO: Initialize to an appropriate value
            ParseErrorAction defaultAction = new ParseErrorAction(); // TODO: Initialize to an appropriate value
            ParseErrorEventArgs target = new ParseErrorEventArgs(error, defaultAction);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Action
        ///</summary>
        [TestMethod()]
        public void ActionTest()
        {
            MalformedCsvException error = null; // TODO: Initialize to an appropriate value
            ParseErrorAction defaultAction = new ParseErrorAction(); // TODO: Initialize to an appropriate value
            ParseErrorEventArgs target = new ParseErrorEventArgs(error, defaultAction); // TODO: Initialize to an appropriate value
            ParseErrorAction expected = new ParseErrorAction(); // TODO: Initialize to an appropriate value
            ParseErrorAction actual;
            target.Action = expected;
            actual = target.Action;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest()
        {
            MalformedCsvException error = null; // TODO: Initialize to an appropriate value
            ParseErrorAction defaultAction = new ParseErrorAction(); // TODO: Initialize to an appropriate value
            ParseErrorEventArgs target = new ParseErrorEventArgs(error, defaultAction); // TODO: Initialize to an appropriate value
            MalformedCsvException actual;
            actual = target.Error;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
