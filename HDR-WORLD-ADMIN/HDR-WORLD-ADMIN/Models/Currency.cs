using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDR_WORLD_ADMIN.Models
{
	public class Currency : APIResModel
	{
		public List<CurrencyModel> data { get; set; }
	}
	public class CurrencyModel
	{
		public string ccy { get; set; }
	}
}
