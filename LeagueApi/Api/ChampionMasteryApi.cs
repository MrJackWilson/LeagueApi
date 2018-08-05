using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueApi.Exceptions;
using LeagueApi.Resources.ChampionMastery;

namespace LeagueApi.Api
{
    public class ChampionMasteryApi : BaseApi
    {
        public ChampionMasteryApi() : base("champion-mastery/v3/") { }

        public async Task<IEnumerable<ChampionMastery>> GetChampionMasteriesBySummonerId(long summonerId)
        {
            return await Execute<IEnumerable<ChampionMastery>>($"champion-masteries/by-summoner/{summonerId}");
        }

        public async Task<ChampionMastery> GetChampionMasteryBySummonerIdForChampion(long summonerId, long championId)
        {
            return await Execute<ChampionMastery>($"champion-masteries/by-summoner/{summonerId}/by-champion/{championId}");
        }

        public async Task<int> GetChampionMasteryScoreBySummonerId(long summonerId)
        {
            return await Execute<int>($"scores/by-summoner/{summonerId}");
        }
    }
}
