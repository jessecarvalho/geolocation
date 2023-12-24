using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Geolocation.Handler;

public class IpInfoHandler
{
    private readonly HttpClient client;

    public IpInfoHandler()
    {
        client = new HttpClient();
    }
    
    public async Task<dynamic?> GetIpInfo(string apiUrl)
    {
        try
        {
            var response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic ipInfo = JObject.Parse(jsonResponse);
                return ipInfo;
            }
            else 
            {
                Console.WriteLine("Error retrieving IP details: " + response.StatusCode);
                return null;
            }
        } catch(Exception e)
        {
            Console.WriteLine("Error retrieving IP details: " + e.Message);
            return null;
        }
    }
}
