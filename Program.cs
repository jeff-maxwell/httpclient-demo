using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace httpclient_demo
{
    public class Program
    {
        async static Task Main(string[] args)
        {
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
