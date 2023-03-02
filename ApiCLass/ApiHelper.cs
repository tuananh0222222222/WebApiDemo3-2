using System.Net.Http.Headers;

namespace ApiCLass
{
    public class ApiHelper
    {
        public static HttpClient apiClient { get; set; }

        public static void initializeClient()
        {
            apiClient = new HttpClient();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  
            
        }
    }
}