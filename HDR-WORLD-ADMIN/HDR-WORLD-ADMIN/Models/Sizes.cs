using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDR_WORLD_ADMIN.Models
{
	public class Sizes : APIResModel
	{
		public SizeModel data { get; set; }
	}
	public class SizeModel
	{
		public List<string> sizes { get; set; }
	}
}
