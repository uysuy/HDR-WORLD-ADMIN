using HDR_WORLD_ADMIN.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace HDR_WORLD_ADMIN.Helpers
{
	public class APIHelper
	{
		public async Task<APIResMsg> PostAPIStringAsync(string url, object obj, string Token = "")
		{
			try
			{
				var jr = new APIResMsg();
				if (url.Length > 0)
				{
					using (var client = new HttpClient(new HttpClientHandler { Proxy = null, UseProxy = false }))
					{
						client.DefaultRequestHeaders.Accept.Clear();
						if (Token != "") client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
						var js = JsonConvert.SerializeObject(obj);
						var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
						var respond = obj == null ? await client.GetAsync(new Uri(url)) : await client.PostAsync(new Uri(url), content);
						if (respond.IsSuccessStatusCode)
						{
							var respondContent = respond.Content;
							jr.Status = ConstantHelper.Success;
							var cte = respond.Content.Headers.ContentEncoding.FirstOrDefault();
							if (cte == "gzip")
							{
								var bytes = await respondContent.ReadAsByteArrayAsync();
							}
							else
							{
								var str = await respondContent.ReadAsStringAsync();
								jr.JsonResult = str;
							}
						}
						else
						{
							string restr = await respond.Content.ReadAsStringAsync();
							jr.Status = ConstantHelper.Error;
							jr.ErrorReason = restr.Split(',')[1].Split(':')[1].Replace("\"", "");
						}
					}
				}
				return jr;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new APIResMsg { ErrorReason = ex.Message, Status = ConstantHelper.Error };
			}
		}
	}
}
