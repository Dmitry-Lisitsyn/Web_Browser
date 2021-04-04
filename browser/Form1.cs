using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MySqlConnector;
using EasyTabs;

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
            this.TopMost = true;
          
            InitializeComponent();
            this.Update();
            InitializeChromium();
            this.SizeChanged += Form1_SizeChanged;
            toolStrip2.ImageScalingSize = new Size(30, 30);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
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

       
        private void button1_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load(textUrl.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buBack_Click(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        private void buForward_Click(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
 

