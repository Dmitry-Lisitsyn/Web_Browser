using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace browser.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void loadPDf_returnTrue()
        {
            // arrange 
            var browser = new Class_Tests();
            var str = "https://google.com/";
            // act
            var result = browser.IsPdfLoad(str);
            // assert            
            Assert.IsTrue(result);
        }
    }
}
