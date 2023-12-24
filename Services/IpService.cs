using System;
using System.Threading.Tasks;
using Geolocation.Handler;

namespace Geolocation.Services;
public class IpService
{
    public static async Task<string?> GetPublicIPAddress()
    {
        try
        {
            var ipIfyHandler = new IpIfyHandler();
            var publicIP = await ipIfyHandler.GetPublicIPAddress();
            return publicIP;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error retrieving public IP address: " + e.Message);
            return null;
        }
    }
}