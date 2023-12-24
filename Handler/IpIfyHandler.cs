using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Geolocation.Handler;

public class IpIfyHandler
{
    private readonly HttpClient client;
    
    public IpIfyHandler()
    {
        client = new HttpClient();
    }

    public async Task<string?> GetPublicIPAddress()
    {
        try
        {
            var response = await client.GetStringAsync("https://api.ipify.org?format=json");
            dynamic jsonResponse = JObject.Parse(response);
            return jsonResponse.ip;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error retrieving public IP address: " + e.Message);
            return null;
        }
    }
}
