using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueApi.Exceptions;
using LeagueApi.Resources.ChampionMastery;

namespace LeagueApi
{
    public class ChampionMasteryApi : IDisposable
    {
        ApiHelper _apiHelper { get; set; }

        public ChampionMasteryApi()
        {
            _apiHelper = new ApiHelper("champion-mastery/v3/");
        }

        public async Task<IEnumerable<ChampionMastery>> GetChampionMasteriesBySummonerId(long summonerId)
        {
            try
            {
                return await _apiHelper.Execute<IEnumerable<ChampionMastery>>($"champion-masteries/by-summoner/{summonerId}");
            }
            catch (LeagueApiException ex)
            {
                throw ex;
            }
        }

        public async Task<ChampionMastery> GetChampionMasteryBySummonerIdForChampion(long summonerId, long championId)
        {
            try
            {
                return await _apiHelper.Execute<ChampionMastery>($"champion-masteries/by-summoner/{summonerId}/by-champion/{championId}");
            }
            catch (LeagueApiException ex)
            {
                throw ex;
            }
        }

        public async Task<int> GetChampionMasteryScoreBySummonerId(long summonerId)
        {
            try
            {
                return await _apiHelper.Execute<int>($"scores/by-summoner/{summonerId}");
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
