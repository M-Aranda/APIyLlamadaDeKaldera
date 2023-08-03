using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


class LlamarAPIKaldera
{
    static void Main()
    {
        var apiUrl = GetApiUrlFromConfiguration(); 

        var timer = new Timer(async _ =>
        {
           await CallApiAsync(apiUrl);
        }, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

        
        Console.ReadKey();
        timer.Dispose();
    }

    private static string GetApiUrlFromConfiguration()
    {
        return System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
    }


    private static async Task CallApiAsync(string apiUrl)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(apiUrl, null);
                response.EnsureSuccessStatusCode();
                Console.WriteLine($"Llamada exitosa: {response.StatusCode}");
                Console.WriteLine($"Contentido de mensaje: {await response.Content.ReadAsStringAsync()}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


