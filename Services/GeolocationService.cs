using System;
using System.Threading.Tasks;
using Geolocation.Handler;

namespace Geolocation.Services;

public class GeolocationService
{
    public static async Task<dynamic> GetIpInfo(string publicIP)
    {
        var token = Environment.GetEnvironmentVariable("TOKEN");
        var apiUrl = $"https://ipinfo.io/{publicIP}?token={token}";
        
        var ipInfoHandler = new IpInfoHandler();
        return await ipInfoHandler.GetIpInfo(apiUrl);
    }
}