using System;
using System.Collections.Generic;
using System.Linq;

using CefSharp;
using CefSharp.WinForms;

namespace browser
{
   public class Class_Tests
    {
        private ChromiumWebBrowser chrometest;
        private bool pdfLoad_check = false;
        public Class_Tests() {

            chrometest = new ChromiumWebBrowser();

        }
        public bool IsPdfLoad(string link)
        {
             chrometest.Load(link);
              chrometest.LoadingStateChanged += Chrometest_LoadingStateChanged;

           return pdfLoad_check;
           
          
        }

        private void Chrometest_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
                pdfLoad_check = true;
        }

    }
}
