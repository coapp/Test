using CoApp.Toolkit.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CoApp.Toolkit.Tasks;
using System.Threading.Tasks;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for PackageManagerTest and is intended
    ///to contain all PackageManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PackageManagerTest
    {
        private static System.Data.DataSet _data;
        private static readonly string[] ItemDelim = { "\",\"", "\" ,\"", "\", \"", "\" , \"" };


        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext Context { get; set; }

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
        ///A test for PackageManager Constructor
        ///All I'm checking for is that the returned object is not null.
        ///</summary>
        [TestMethod()]
        public void SystemFeedLocationsTest()
        {
            PackageManager target = new PackageManager();
            IEnumerable<string> item = target.SystemFeedLocations;
            Assert.IsNotNull(item, "Object returned by SystemFeedLocations was null.");
        }
        
        /// <summary>
        ///A test for SessionFeedLocations
        ///This ensures that SessionFeedLocations returns something and that assignment to it works.
        ///</summary>
        [TestMethod()]
        public void SessionFeedLocationsTest()
        {
            PackageManager target = new PackageManager();
            System.Collections.ArrayList expected, actual;
            string[] var = {"c:\\"};
            expected = new System.Collections.ArrayList();
            IEnumerable<string> tmp = target.SessionFeedLocations;
            IEnumerator<string> stepper = tmp.GetEnumerator();
            stepper.MoveNext(); //init to first item
            while (stepper.Current != null)
            {
                expected.Add(stepper.Current);
                stepper.MoveNext();
            }
            expected.Add(var[0].ToLower());
            // The following line generates downstream tasks, and must be waited on to pass the test.
            target.SessionFeedLocations = var;

            // Adding this did not cause the test to run successfully.
            // Tasklet.WaitforCurrentChildTasks();
            
            actual = new System.Collections.ArrayList();
            tmp = target.SessionFeedLocations;
            stepper = tmp.GetEnumerator();
            stepper.MoveNext(); //init to first item
            while (stepper.Current != null)
            {
                actual.Add(stepper.Current);
                stepper.MoveNext();
            } 
            Assert.IsNotNull(actual, "Received NULL session feed list after assignment.");
            
            for (int i = 0; i < expected.Count; i++)
                if (!actual.Contains(expected[i]))
                {
                    string Estring = "";
                    for (int j = 0; j < expected.Count; j++)
                        Estring += (string)expected[j] + "\n";
                    string Astring = "";
                    for (int j = 0; j < actual.Count; j++)
                        Astring += (string)actual[j] + "\n";

                    Assert.Fail("Added feed location does not match expectation.\tMay be caused by incompleted child tasks.");
                }
            Assert.IsTrue(true, "Retrieved and altered Session feed locations successfully.");
        }

        /// <summary>
        ///A test for DoNotScanLocations
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void DoNotScanLocationsTest()
        {
            PackageManager target = new PackageManager();
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            target.DoNotScanLocations = expected;
            actual = target.DoNotScanLocations;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Upgrade
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void UpgradeTest()
        {
            PackageManager target = new PackageManager();
            IEnumerable<string> packageList = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.Upgrade(packageList, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InstallPackages
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void InstallPackagesTest()
        {
            PackageManager target = new PackageManager();
            IEnumerable<Package> packages = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.InstallPackages(packages, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemovePackages
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void RemovePackagesTest()
        {
            PackageManager target = new PackageManager();
            IEnumerable<string> packages = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.RemovePackages(packages, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InstallPackages
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void InstallPackagesTest1()
        {
            PackageManager target = new PackageManager();
            IEnumerable<string> packageMasks = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.InstallPackages(packageMasks, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetInstalledPackages
        ///All this checks for is to make sure a non-null list is returned. (An empty list is fine.)
        ///</summary>
        [TestMethod()]
        public void GetInstalledPackagesTest()
        {
            PackageManager target = new PackageManager();
            Assert.IsNotNull(target.GetInstalledPackages(), "Returned list of packages was null.");
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateAtomFeed
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void GenerateAtomFeedTest()
        {
            PackageManager target = new PackageManager();
            string outputFilename = string.Empty; // TODO: Initialize to an appropriate value
            string packageSource = string.Empty; // TODO: Initialize to an appropriate value
            bool recursive = false; // TODO: Initialize to an appropriate value
            string rootUrl = string.Empty; // TODO: Initialize to an appropriate value
            string packageUrl = string.Empty; // TODO: Initialize to an appropriate value
            string actualUrl = string.Empty; // TODO: Initialize to an appropriate value
            string title = string.Empty; // TODO: Initialize to an appropriate value
            target.GenerateAtomFeed(outputFilename, packageSource, recursive, rootUrl, packageUrl, actualUrl, title);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FlushCache
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void FlushCacheTest()
        {
            PackageManager target = new PackageManager();
            target.FlushCache();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteSystemFeeds
        ///TR01: TODO: Write this test.
        ///</summary>
        [TestMethod()]
        public void DeleteSystemFeedsTest()
        {
            PackageManager target = new PackageManager();
            IEnumerable<string> feedLocations = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual;
            actual = target.DeleteSystemFeeds(feedLocations, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddSystemFeeds
        ///TR01: TODO: Write this test.
        ///</summary>
        [DeploymentItem("testStrings.txt")]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\testStrings.txt", "testStrings#txt", DataAccessMethod.Sequential), TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "testStrings.txt", "testStrings#txt", DataAccessMethod.Sequential), TestMethod()]
        public void AddSystemFeedsTest()
        {
            //column name in the data file
            string name = "AddSystemFeedsTest";
            //get the expected result from this data row for this test
            string testval = (string)Context.DataRow[name];
            int val;
            if (int.TryParse(testval, out val))
            {
                if (Test.misc.Results.Ignore.Equals(val))
                {
                    Console.Out.WriteLine("Skipping string " + (string) Context.DataRow["string"] + " for test " +
                                          name);
                    return;
                }
            }
            PackageManager target = new PackageManager();
            IEnumerable<string> feedLocations = null; // TODO: Initialize to an appropriate value
            MessageHandlers messageHandlers = null; // TODO: Initialize to an appropriate value
            Task expected = null; // TODO: Initialize to an appropriate value
            Task actual = target.AddSystemFeeds(feedLocations, messageHandlers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PackageManager Constructor
        ///All I'm checking for is that the returned object is not null.
        ///</summary>
        [TestMethod()]
        public void PackageManagerConstructorTest()
        {
            PackageManager target = new PackageManager();
            Assert.IsNotNull(target, "Object returned by constructor was null.");
        }
    }
}
