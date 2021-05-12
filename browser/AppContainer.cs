using System;
using CefSharp;
using CefSharp.WinForms;
using EasyTabs;

namespace browser
{
    public partial class AppContainer : TitleBarTabs
    {
       // public ChromiumWebBrowser chromeBrowser;
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }
        static AppContainer()
        {

            CefSettings cefSettings = new CefSettings();
            cefSettings.DisableGpuAcceleration();

            Cef.Initialize(cefSettings);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {

                Content = new Main_Form
                {

                    Text = "New Tab"
                }
            };
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {
            

        }
    }
}
