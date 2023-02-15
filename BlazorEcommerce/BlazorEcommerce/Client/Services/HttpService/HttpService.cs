using Framework.Front.Services;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace BlazorEcommerce.Client.Services.HttpService
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Get<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            return await SendRequest<T>(request);
        }
        public async Task Post<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content = new StringContent(
                JsonSerializer.Serialize(value),
                Encoding.UTF8,
                "application/json");

            await SendRequest(request);

        }
        public async Task Put<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            request.Content = new StringContent(
                JsonSerializer.Serialize(value),
                Encoding.UTF8,
                "application/json");

            await SendRequest(request);
        }
        public async Task Delete(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, uri);
            await SendRequest(request);
        }
        private async Task<T> SendRequest<T>(HttpRequestMessage request)
        {
            using var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["Message"]);
            }

            return await response.Content.ReadFromJsonAsync<T>();
        }
        private async Task SendRequest(HttpRequestMessage request)
        {
            using var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["Message"]);
            }

        }


    }
}
