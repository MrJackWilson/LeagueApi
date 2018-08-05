using System;
using System.Threading.Tasks;
using LeagueApi.Exceptions;
using LeagueApi.Resources.Summoner;

namespace LeagueApi
{
    public class SummonerApi : IDisposable
    {
        ApiHelper _apiHelper { get; set; }

        public SummonerApi()
        {
            _apiHelper = new ApiHelper("summoner/v3/");
        }

        public async Task<Summoner> GetByAccountId(long accountId)
        {
            try
            {
                return await _apiHelper.Execute<Summoner>($"summoners/by-account/{accountId}");
            }
            catch (LeagueApiException ex)
            {
                throw ex;
            }
        }

        public async Task<Summoner> GetBySummonerName(string summonerName)
        {
            try
            {
                return await _apiHelper.Execute<Summoner>($"summoners/by-name/{summonerName}");
            }
            catch (LeagueApiException ex)
            {
                throw ex;
            }
        }

        public async Task<Summoner> GetBySummonerId(long summonerId)
        {
            try
            {
                return await _apiHelper.Execute<Summoner>($"summoners/{summonerId}");
            }
            catch (LeagueApiException ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _apiHelper.Dispose();
        }
    }
}
