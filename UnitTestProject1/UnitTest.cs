using browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace browser_tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void firstLoad_returnGoogle()
        {
            var test = new Class_Tests();

            string url = "https://www.google.com";

            bool expected = true;

            bool result = test.IspageCorrect(url);

            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void sizeWindow_returnMaximum()
        {
            var test = new Class_Tests();
            var window = new Main_Form();

            var width = window.width;
            var height = window.height;
            bool expected = true;

            bool result = test.IsSizeMax(width, height);

            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void strlink_returnValid()
        {
            var test = new Class_Tests();
            var str = "https://lms.mospolytech.ru/";

            bool expected = true;

            bool result = test.isLinkCorrect(str);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void urlSize_returnCorrectSize()
        {
            var test = new Class_Tests();

            var num = 600;

            bool expected = true;

            bool result = test.ISUrlSizeCorrect(num);

            Assert.AreEqual(expected, result);
        }
    }
}
