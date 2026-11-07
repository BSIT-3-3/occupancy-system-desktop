using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OccupancyMonitor.Services
{
    public sealed class ApiClient
    {
        private readonly HttpClient _httpClient;
        private static readonly JsonSerializerOptions JsonOptions =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<TResponse> GetAsync<TResponse>(string path, string accessToken = null)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, path))
            {
                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                using (var response = await _httpClient.SendAsync(request).ConfigureAwait(false))
                {
                    return await ReadResponseAsync<TResponse>(response).ConfigureAwait(false);
                }
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string path, TRequest body, string accessToken = null)
        {
            var json = JsonSerializer.Serialize(body, JsonOptions);
            using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
            using (var request = new HttpRequestMessage(HttpMethod.Post, path) { Content = content })
            {
                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                using (var response = await _httpClient.SendAsync(request).ConfigureAwait(false))
                {
                    return await ReadResponseAsync<TResponse>(response).ConfigureAwait(false);
                }
            }
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string path, TRequest body, string accessToken = null)
        {
            var json = JsonSerializer.Serialize(body, JsonOptions);
            using (var request = new HttpRequestMessage(HttpMethod.Put, path))
            {
                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                using (var response = await _httpClient.SendAsync(request).ConfigureAwait(false))
                {
                    return await ReadResponseAsync<TResponse>(response).ConfigureAwait(false);
                }
            }
        }

        public async Task<TResponse> DeleteAsync<TResponse>(string path, string accessToken = null)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Delete, path))
            {
                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                using (var response = await _httpClient.SendAsync(request).ConfigureAwait(false))
                {
                    return await ReadResponseAsync<TResponse>(response).ConfigureAwait(false);
                }
            }
        }

        private static async Task<TResponse> ReadResponseAsync<TResponse>(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException(response.StatusCode, body);
            }

            if (string.IsNullOrWhiteSpace(body))
            {
                return default(TResponse);
            }

            return JsonSerializer.Deserialize<TResponse>(body, JsonOptions);
        }
    }

    public sealed class ApiException : HttpRequestException
    {
        public HttpStatusCode StatusCode { get; private set; }
        public string ResponseBody { get; private set; }

        public ApiException(HttpStatusCode statusCode, string responseBody)
            : base("The server returned HTTP " + (int)statusCode + ".")
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }
    }
}
