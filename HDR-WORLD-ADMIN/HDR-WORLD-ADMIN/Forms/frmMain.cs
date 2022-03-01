using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDR_WORLD_ADMIN.Forms
{
	public partial class frmMain : Form
	{
		Form _frm;
		public frmMain()
		{
			InitializeComponent();
		}
		public frmMain(Form frm)
		{
			InitializeComponent();
			_frm = frm;
		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			if (_frm != null)
				_frm.Hide();
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(_frm !=null)
				_frm.Dispose();
		}

		private void newTsm_Click(object sender, EventArgs e)
		{
			ShowForm(new frmNewProduct());
		}
		private void ShowForm(Form frm)
		{
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
