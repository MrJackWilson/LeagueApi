using LeagueApi.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApi
{
    public class Api : IDisposable
    {
        private HttpClient _client { get; }
        private string _baseUrl { get; set; } = "https://euw1.api.riotgames.com/lol/";
        private string _region { get; set; }
        private string _apiKey => "RGAPI-ea4018d8-30f2-4db2-bbd4-d57f11deab3d";
        private string _apiKeyHeaderName => "X-Riot-Token";

        public Api(string region, string baseUrl)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add(_apiKeyHeaderName, _apiKey);
            _region = region;
            _baseUrl += baseUrl;
        }

        public Api(string baseUrl) : this(Region.EUW1, baseUrl) { }

        public async Task<TReturn> Execute<TReturn>(string resource)
        {
            var response = await _client.GetAsync(_baseUrl + resource);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(content))
                    return JsonConvert.DeserializeObject<TReturn>(content);
            }

            return default(TReturn);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
