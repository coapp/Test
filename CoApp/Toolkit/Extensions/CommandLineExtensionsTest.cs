using CoApp.Toolkit.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Extensions
{
    
    
    /// <summary>
    ///This is a test class for CommandLineExtensionsTest and is intended
    ///to contain all CommandLineExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommandLineExtensionsTest
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
        ///A test for GetComplexOptions
        ///</summary>
        [TestMethod()]
        public void GetComplexOptionsTest()
        {
            IEnumerable<string> rawParameterList = null; // TODO: Initialize to an appropriate value
            IEnumerable<ComplexOption> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<ComplexOption> actual;
            actual = CommandLineExtensions.GetComplexOptions(rawParameterList);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetParametersForSwitch
        ///</summary>
        [TestMethod()]
        public void GetParametersForSwitchTest()
        {
            IEnumerable<string> args = null; // TODO: Initialize to an appropriate value
            string key = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = CommandLineExtensions.GetParametersForSwitch(args, key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetParametersForSwitchOrNull
        ///</summary>
        [TestMethod()]
        public void GetParametersForSwitchOrNullTest()
        {
            IEnumerable<string> args = null; // TODO: Initialize to an appropriate value
            string key = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = CommandLineExtensions.GetParametersForSwitchOrNull(args, key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LoadConfiguration
        ///</summary>
        [TestMethod()]
        public void LoadConfigurationTest()
        {
            string file = string.Empty; // TODO: Initialize to an appropriate value
            CommandLineExtensions.LoadConfiguration(file);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Parameters
        ///</summary>
        [TestMethod()]
        public void ParametersTest()
        {
            IEnumerable<string> args = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = CommandLineExtensions.Parameters(args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SwitchValue
        ///</summary>
        [TestMethod()]
        public void SwitchValueTest()
        {
            IEnumerable<string> args = null; // TODO: Initialize to an appropriate value
            string key = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CommandLineExtensions.SwitchValue(args, key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Switches
        ///</summary>
        [TestMethod()]
        public void SwitchesTest()
        {
            IEnumerable<string> args = null; // TODO: Initialize to an appropriate value
            Dictionary<string, IEnumerable<string>> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, IEnumerable<string>> actual;
            actual = CommandLineExtensions.Switches(args);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
