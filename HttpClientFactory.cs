using System.Net.Http;

namespace httpclient_demo
{
    public class HttpClientFactory
    {

        private static HttpClient _httpClient;

        static HttpClientFactory()
        {
            _httpClient = new HttpClient();
        }

        public static HttpClient GetInstance()
        {
            return _httpClient;
        }

    }
}