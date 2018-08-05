using LeagueApi.Constants;
using LeagueApi.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApi.Api
{
    public abstract class BaseApi : IDisposable
    {
        HttpClient _client { get; }
        string _baseUrl { get; set; } = "https://euw1.api.riotgames.com/lol/";
        string _region { get; set; }
        string _apiKey => "RGAPI-a8f9b12c-ffc3-4183-aec1-401f9a72e27c";
        string _apiKeyHeaderName => "X-Riot-Token";

        protected BaseApi(string region, string baseUrl)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add(_apiKeyHeaderName, _apiKey);
            _region = region;
            _baseUrl += baseUrl;
        }

        protected BaseApi(string baseUrl) : this(Region.EUW1, baseUrl) { }

        protected async Task<TReturn> Execute<TReturn>(string action)
        {
            var response = await _client.GetAsync(_baseUrl + action);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(content))
                    return JsonConvert.DeserializeObject<TReturn>(content);
            }
            else
            {
                throw new LeagueApiException(response.StatusCode);
            }

            return default(TReturn);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
