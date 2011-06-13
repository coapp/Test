using CoApp.Toolkit.Text.Sgml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.CoApp.Toolkit.Text.Sgml
{
    
    
    /// <summary>
    ///This is a test class for ElementDeclTest and is intended
    ///to contain all ElementDeclTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ElementDeclTest
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
        ///A test for ElementDecl Constructor
        ///</summary>
        [TestMethod()]
        public void ElementDeclConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddAttDefs
        ///</summary>
        [TestMethod()]
        public void AddAttDefsTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            Dictionary<string, AttDef> list = null; // TODO: Initialize to an appropriate value
            target.AddAttDefs(list);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CanContain
        ///</summary>
        [TestMethod()]
        public void CanContainTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            string name1 = string.Empty; // TODO: Initialize to an appropriate value
            SgmlDtd dtd = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CanContain(name1, dtd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindAttribute
        ///</summary>
        [TestMethod()]
        public void FindAttributeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            string name1 = string.Empty; // TODO: Initialize to an appropriate value
            AttDef expected = null; // TODO: Initialize to an appropriate value
            AttDef actual;
            actual = target.FindAttribute(name1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContentModel
        ///</summary>
        [TestMethod()]
        public void ContentModelTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            ContentModel actual;
            actual = target.ContentModel;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EndTagOptional
        ///</summary>
        [TestMethod()]
        public void EndTagOptionalTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.EndTagOptional;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartTagOptional
        ///</summary>
        [TestMethod()]
        public void StartTagOptionalTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool sto = false; // TODO: Initialize to an appropriate value
            bool eto = false; // TODO: Initialize to an appropriate value
            ContentModel cm = null; // TODO: Initialize to an appropriate value
            string[] inclusions = null; // TODO: Initialize to an appropriate value
            string[] exclusions = null; // TODO: Initialize to an appropriate value
            ElementDecl target = new ElementDecl(name, sto, eto, cm, inclusions, exclusions); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.StartTagOptional;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
