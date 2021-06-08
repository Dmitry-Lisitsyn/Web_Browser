using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;

namespace browser
{
	public partial class FmAutofill : Form
	{
		public FmAutofill()
		{
			InitializeComponent();
			/*if (afAdidas)
			{
				cbAdidas.Checked = true;
			}
			else
			{
				cbAdidas.Checked = false;

			}

			if (afEnd)
			{
				cbEnd.Checked = true;
			}
			else
			{
				cbEnd.Checked = false;

			}*/
		}

		public bool afAdidas;
		public bool afEnd;

		

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void cbAdidas_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAdidas.Checked)
			{
				afAdidas = true;
			}
			else
			{
				afAdidas = false;
			}
		}

		private void cbEnd_CheckedChanged(object sender, EventArgs e)
		{
			if (cbEnd.Checked)
			{
				afEnd = true;
			}
			else
			{
				afEnd = false;
			}
		}
	}
}
