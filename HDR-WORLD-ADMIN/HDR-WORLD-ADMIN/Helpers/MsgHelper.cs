using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDR_WORLD_ADMIN.Helpers
{
	public class MsgHelper
	{
		private const string _msgTitle = "HDR World Clothes";
		public static DialogResult MsgInfo(string msgText, string msgTitle = null)
		{
			return MessageBox.Show(msgText, msgTitle??_msgTitle, MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		public static DialogResult MsgWarning(string msgText, string msgTitle = null)
		{
			return MessageBox.Show(msgText, msgTitle ?? _msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		public static DialogResult MsgError(string msgText, string msgTitle = null)
		{
			return MessageBox.Show(msgText, msgTitle ?? _msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
