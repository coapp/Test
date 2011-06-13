using CoApp.Toolkit.Scripting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Test.CoApp.Toolkit.Scripting
{
    
    
    /// <summary>
    ///This is a test class for IDispatchTest and is intended
    ///to contain all IDispatchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IDispatchTest
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


        internal virtual IDispatch CreateIDispatch()
        {
            // TODO: Instantiate an appropriate concrete class.
            IDispatch target = null;
            return target;
        }

        /// <summary>
        ///A test for GetIDsOfNames
        ///</summary>
        [TestMethod()]
        public void GetIDsOfNamesTest()
        {
            IDispatch target = CreateIDispatch(); // TODO: Initialize to an appropriate value
            Guid riid = new Guid(); // TODO: Initialize to an appropriate value
            Guid riidExpected = new Guid(); // TODO: Initialize to an appropriate value
            string[] rgszNames = null; // TODO: Initialize to an appropriate value
            int cNames = 0; // TODO: Initialize to an appropriate value
            int lcid = 0; // TODO: Initialize to an appropriate value
            int[] rgDispId = null; // TODO: Initialize to an appropriate value
            int[] rgDispIdExpected = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            //actual = target.GetIDsOfNames(ref riid, rgszNames, cNames, lcid, out rgDispId);
            actual = target.GetIDsOfNames(ref riid, rgszNames, cNames, lcid, rgDispId);
            Assert.AreEqual(riidExpected, riid);
            Assert.AreEqual(rgDispIdExpected, rgDispId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTypeInfo
        ///</summary>
        [TestMethod()]
        public void GetTypeInfoTest()
        {
            IDispatch target = CreateIDispatch(); // TODO: Initialize to an appropriate value
            int iTInfo = 0; // TODO: Initialize to an appropriate value
            int lcid = 0; // TODO: Initialize to an appropriate value
            ITypeInfo expected = null; // TODO: Initialize to an appropriate value
            ITypeInfo actual;
            actual = target.GetTypeInfo(iTInfo, lcid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTypeInfoCount
        ///</summary>
        [TestMethod()]
        public void GetTypeInfoCountTest()
        {
            IDispatch target = CreateIDispatch(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetTypeInfoCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Invoke
        ///</summary>
        [TestMethod()]
        public void InvokeTest()
        {
            IDispatch target = CreateIDispatch(); // TODO: Initialize to an appropriate value
            int dispIdMember = 0; // TODO: Initialize to an appropriate value
            Guid riid = new Guid(); // TODO: Initialize to an appropriate value
            Guid riidExpected = new Guid(); // TODO: Initialize to an appropriate value
            int lcid = 0; // TODO: Initialize to an appropriate value
            ushort wFlags = 0; // TODO: Initialize to an appropriate value
            DISPPARAMS pDispParams = new DISPPARAMS(); // TODO: Initialize to an appropriate value
            DISPPARAMS pDispParamsExpected = new DISPPARAMS(); // TODO: Initialize to an appropriate value
            object varResult = null; // TODO: Initialize to an appropriate value
            object varResultExpected = null; // TODO: Initialize to an appropriate value
            EXCEPINFO pExcepInfo = new EXCEPINFO(); // TODO: Initialize to an appropriate value
            EXCEPINFO pExcepInfoExpected = new EXCEPINFO(); // TODO: Initialize to an appropriate value
            int puArgErr = 0; // TODO: Initialize to an appropriate value
            int puArgErrExpected = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Invoke(dispIdMember, ref riid, lcid, wFlags, out pDispParams, out varResult, out pExcepInfo, out puArgErr);
            Assert.AreEqual(riidExpected, riid);
            Assert.AreEqual(pDispParamsExpected, pDispParams);
            Assert.AreEqual(varResultExpected, varResult);
            Assert.AreEqual(pExcepInfoExpected, pExcepInfo);
            Assert.AreEqual(puArgErrExpected, puArgErr);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
