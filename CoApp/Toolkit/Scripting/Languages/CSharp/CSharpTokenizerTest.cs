﻿using CoApp.Toolkit.Scripting.Languages.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoApp.Toolkit.Scripting.Utility;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Scripting.Languages.CSharp
{
    
    
    /// <summary>
    ///This is a test class for CSharpTokenizerTest and is intended
    ///to contain all CSharpTokenizerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CSharpTokenizerTest
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
        ///A test for Tokenize
        ///</summary>
        [TestMethod()]
        public void TokenizeTest()
        {
            char[] text = null; // TODO: Initialize to an appropriate value
            List<Token> expected = null; // TODO: Initialize to an appropriate value
            List<Token> actual;
            actual = CSharpTokenizer.Tokenize(text);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Tokenize
        ///</summary>
        [TestMethod()]
        public void TokenizeTest1()
        {
            string text = string.Empty; // TODO: Initialize to an appropriate value
            List<Token> expected = null; // TODO: Initialize to an appropriate value
            List<Token> actual;
            actual = CSharpTokenizer.Tokenize(text);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
