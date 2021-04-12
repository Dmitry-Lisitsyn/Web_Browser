using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using MySqlConnector;
using EasyTabs;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace browser
{

    public partial class Form1 : Form
    {


        protected TitleBarTabs ParentTabs {
            get {
                return (ParentForm as TitleBarTabs);
            }

        }
        public ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Update();
            InitializeChromium();
           
            toolStrip2.ImageScalingSize = new Size(30, 30);
           

            toolStrip2.SizeChanged += ToolStrip2_SizeChanged;
            this.SizeChanged += Form1_SizeChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
            chromeBrowser.AddressChanged += ChromeBrowser_AddressChanged;
            textUrl.Click += TextUrl_Click;
            textUrl.KeyUp += TextUrl_KeyUp;    
        }

        private void TextUrl_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textUrl.Text))
            {
                textUrl.SelectionStart = 0;
                textUrl.SelectionLength = textUrl.Text.Length;
            }
        }


        private void ToolStrip2_SizeChanged(object sender, EventArgs e)
        {
            int size = buBack.Width + buForward.Width + buRefresh.Width + buSearch.Width + buSettings.Width + buProfile.Width;
            textUrl.Width = toolStrip2.Width - size;
        }

        private void TextUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(textUrl.Text);
        }

  
        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
              
               chromeBrowser.Load(url);
            }
            else
            {
                chromeBrowser.Load("https://www.google.com/search?q=" + url);
            }
        }

        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = e.Title);
        }


        private void ChromeBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => textUrl.Text = e.Address);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            toolStrip2.Width = this.Width;
            //chromeBrowser.Size = pContainer.Size;
            //this.Invalidate();

        }

        public void InitializeChromium()
        {
            
            textUrl.Text = "https://www.google.com";
            chromeBrowser = new ChromiumWebBrowser(textUrl.Text);

            chromeBrowser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(chromeBrowser);
            

        }


        private void buRefresh_Click(object sender, EventArgs e)
        {
            chromeBrowser.Refresh();
        }

        private void buSearch_Click(object sender, EventArgs e)
        {
           LoadUrl(textUrl.Text);
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Office Files|*.pdf;*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textUrl.Text = dialog.FileName;
                chromeBrowser.Load(textUrl.Text);
            }
        }

        private void buBack_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        private void buForward_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void buProfile_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
 

