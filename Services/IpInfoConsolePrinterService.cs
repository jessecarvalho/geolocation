using System;
using Newtonsoft.Json.Linq;

namespace Geolocation.Services;

public class IpInfoConsolePrinterService
{
    public static void PrintIpInfoDetails(JObject ipInfo)
    {
        if (ipInfo == null)
        {
            Console.WriteLine("Nenhuma informação de IP para exibir.");
            return;
        }

        Console.WriteLine("Detalhes do IP:");
        Console.WriteLine($"País: {ipInfo["country"]}");
        Console.WriteLine($"Região: {ipInfo["region"]}");
        Console.WriteLine($"Cidade: {ipInfo["city"]}");
        Console.WriteLine($"Código Postal: {ipInfo["postal"]}");
        Console.WriteLine($"Localização: {ipInfo["loc"]}");
        Console.WriteLine($"Fuso Horário: {ipInfo["timezone"]}");
    }
}
