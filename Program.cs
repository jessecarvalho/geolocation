using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Geolocation.Handler;
using Geolocation.Services;

namespace Geolocation
{
    class Program
    {
        public static async Task Main()
        {
            var publicIP = await IpService.GetPublicIPAddress();
            if (publicIP == null)
            {
                Console.WriteLine("Failed to retrieve public IP address.");
                return;
            }

            var apiUrl = $"https://ipinfo.io/{publicIP}/json";
            var ipInfo = await GeolocationService.GetIpInfo(apiUrl);
            if (ipInfo == null)
            {
                Console.WriteLine("Failed to retrieve IP details.");
                return;
            }

            IpInfoConsolePrinterService.PrintIpInfoDetails(ipInfo);
        }

    }
}
