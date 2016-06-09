using System;


namespace HttpClient
{
    using System.Net.Http;
    public class HttpClientFactory
    {
        private HttpClient _httpClient;

        public HttpClientFactory()
        {
            _httpClient = new HttpClient();
        }

        public HttpClient GetHttpClient()
        {
            return _httpClient;
        }

        public HttpClient GetHttpClient(string baseAddress)
        {
            _httpClient.BaseAddress = new Uri(baseAddress);

            return _httpClient;
        }
    }
}