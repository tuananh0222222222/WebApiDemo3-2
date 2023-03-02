using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCLass
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunInfomation()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400&date=today";

            using (HttpResponseMessage rs = await ApiHelper.apiClient.GetAsync(url))
            {
                if (rs.IsSuccessStatusCode)
                {
                    SunResultModel rsSun = await rs.Content.ReadAsAsync<SunResultModel>();
                    return rsSun.Results;
                }
                else
                {
                    throw new Exception(rs.ReasonPhrase);
                }
            }
        }
    }
}
