using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDR_WORLD_ADMIN.Helpers
{
	public class ControlHelper
	{
		public static IEnumerable<Control> GetAllControls(Control control)
		{
			var controls = control.Controls.Cast<Control>();

			return controls.SelectMany(ctrl => GetAllControls(ctrl))
									  .Concat(controls);
		}
		public static bool isControlValid(Form frm)
		{
			bool valid = true;
			var allControls = GetAllControls(frm).OrderBy(t=>t.TabIndex).ToList();
			foreach (var control in allControls)
			{
				if (control is TextBox)
				{
					var txt = control as TextBox;
					var flag = txt?.Tag == null ? false : true;
					if (flag && string.IsNullOrEmpty(txt?.Text))
					{
						MsgHelper.MsgWarning(txt?.Tag.ToString());
						txt.Focus();
						valid = false;
						break;
					}
				}
			}
			return valid;
		}
	}
}
