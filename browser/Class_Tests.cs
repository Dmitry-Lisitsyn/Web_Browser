using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace browser
{
   public class Class_Tests
    {
        public bool IspageCorrect(string str)
        {
            if (str == "https://www.google.com")
                return true;
            else
                return false;
        }

        public bool IsSizeMax(double width, double height)
        {
            if (width == 1920 && height == 997)
                return true;
            else
                return false;
            
        }
      
    }
}
