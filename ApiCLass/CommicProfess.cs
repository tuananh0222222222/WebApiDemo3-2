using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCLass
{
    public class CommicProfess
    {
        public static async Task<CommicModel> LoadCommic(int CommicNumber = 0)
        {
            string url = "";

            if (CommicNumber>0)
            {
                url = $"https://xkcd.com/{CommicNumber}/info.0.json";
            }
            else
            {
                url = $"https://xkcd.com/info.0.json";

            }

            using(HttpResponseMessage rs = await ApiHelper.apiClient.GetAsync(url))
            {
                if(rs.IsSuccessStatusCode)
                {
                    CommicModel comic = await rs.Content.ReadAsAsync<CommicModel>();
                    return comic;
                }
                else
                {
                    throw new Exception(rs.ReasonPhrase);
                }
            }
        }
    }
}
