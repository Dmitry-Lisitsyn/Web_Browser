using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
	public partial class FmAutofill : Form
	{
		public FmAutofill()
		{
			InitializeComponent();
		}

		public bool afAdidas;
		public bool afEnd;

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
	}
}
