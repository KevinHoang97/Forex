using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Forex
{
    public static class ServiceExtension
    {

        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url); //makes request
            request.Headers.Add("Authorization", "Bearer 50f5b6cf1d7ec2e9adbb46f534883f5a-d9f458ef2e65108b1ba1ade2f0f68926"); //no point in hiding this, in public header anyway.

            var response = await httpClient.SendAsync(request);
            response.Headers.Add("Access-Control-Allow-Origin", "*"); //Allows for CORS in response headers
            response.EnsureSuccessStatusCode();

            var responseBytes = await response.Content.ReadAsByteArrayAsync();

            return JsonSerializer.Deserialize<T>(responseBytes);
        }
    }
}
