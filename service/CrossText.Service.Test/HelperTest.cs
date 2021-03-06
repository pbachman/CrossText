﻿using CrossText.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Drawing;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for HelperTest and is intended
    ///to contain all HelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HelperTest
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
        ///A test for CheckIfURLExists
        ///</summary>
        [TestMethod()]
        public void CheckIfURLExistsTest()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Helper.CheckIfURLExists(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetImageFromURL
        ///</summary>
        [TestMethod()]
        public void GetImageFromURLTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = Helper.GetImageFromURL(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for byteArrayToImage
        ///</summary>
        [TestMethod()]
        public void byteArrayToImageTest()
        {
            byte[] byteArrayIn = null; // TODO: Initialize to an appropriate value
            Image expected = null; // TODO: Initialize to an appropriate value
            Image actual;
            actual = Helper_Accessor.byteArrayToImage(byteArrayIn);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for imageToByteArray
        ///</summary>
        [TestMethod()]
        public void imageToByteArrayTest()
        {
            Image imageIn = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = Helper_Accessor.imageToByteArray(imageIn);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
