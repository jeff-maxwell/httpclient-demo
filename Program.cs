using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace httpclient_demo
{
    public class Program
    {
        async static Task Main(string[] args)
        {
            // Resolves DNS issue
            ServicePointManager.DnsRefreshTimeout = 60000;

            for(int i = 0; i < 50; i++)
            {
                using(HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("https://swapi.co/api/people/1/?format=json");
                    Console.WriteLine("Status: "+response.StatusCode);
                }

                // HttpClient client = HttpClientFactory.GetInstance();
                // HttpResponseMessage response = await client.GetAsync("https://swapi.co/api/people/1/?format=json");
                // Console.WriteLine("Status: "+response.StatusCode);

            }

        }
    }
}
