﻿using CoApp.Toolkit.Crypto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Crypto
{
    
    
    /// <summary>
    ///This is a test class for VerifierTest and is intended
    ///to contain all VerifierTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VerifierTest
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
        ///A test for Verifier Constructor
        ///</summary>
        [TestMethod()]
        public void VerifierConstructorTest()
        {
            Verifier target = new Verifier();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetPublisherInformation
        ///</summary>
        [TestMethod()]
        public void GetPublisherInformationTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, string> actual;
            actual = Verifier.GetPublisherInformation(filename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSignatureInformation
        ///</summary>
        [TestMethod()]
        public void GetSignatureInformationTest()
        {
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            Verifier.GetSignatureInformation(filename);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for HasValidSignature
        ///</summary>
        [TestMethod()]
        public void HasValidSignatureTest()
        {
            string fileName = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Verifier.HasValidSignature(fileName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
