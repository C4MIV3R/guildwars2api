using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DL.GuildWars2Api
{
    internal sealed class HttpClientHelper
    {
        public async Task<T> GetStringAsync<T>(string url)
        {
            using (var httpClient = this.MakeHttpClient())
            {
                return await this.DeserializeStringAsync<T>(httpClient, url);
            }
        }

        public async Task<T> GetStringAsync<T>(string url, string key)
        {
            using (var httpClient = this.MakeHttpClient(key))
            {
                return await this.DeserializeStringAsync<T>(httpClient, url);
            }
        }

        public async Task<T> GetStreamAsync<T>(string url)
        {
            using (var httpClient = this.MakeHttpClient())
            {
                return await this.DeserializeStreamAsync<T>(httpClient, url);
            }                
        }

        public async Task<T> GetStreamAsync<T>(string url, string key)
        {
            using (var httpClient = this.MakeHttpClient(key))
            {
                return await this.DeserializeStreamAsync<T>(httpClient, url);
            }
        }

        private async Task<T> DeserializeStreamAsync<T>(HttpClient httpClient, string url)
        {
            var response = await httpClient.GetStreamAsync(url);
            T t;
            using (var sr = new StreamReader(response))
            using (var reader = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                t = serializer.Deserialize<T>(reader);
            }
            response.Dispose();
            return t;
        }
        
        private async Task<T> DeserializeStringAsync<T>(HttpClient httpClient, string url)
        {
            var json = await httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<T>(json);
        }

        private HttpClient MakeHttpClient()
        {
            return new HttpClient { BaseAddress = new Uri("https://api.guildwars2.com/") };
        }

        private HttpClient MakeHttpClient(string key)
        {
            var httpClient = this.MakeHttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
            return httpClient;
        }
    }
}
