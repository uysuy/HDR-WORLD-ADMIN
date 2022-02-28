using HDR_WORLD_ADMIN.Helpers;
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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (!ControlHelper.isControlValid(this))
				return;
			else
			{
				if(txtUsr.Text=="hdr" && txtPwd.Text == "123")
				{
					var frmMain = new frmMain(this);
					frmMain.ShowDialog();
				}
			}
		}
	}
}
