using System;
using System.Threading.Tasks;
using LeagueApi.Resources.Summoner;

namespace LeagueApi.Api
{
    public class SummonerApi : BaseApi
    {
        public SummonerApi() : base("summoner/v3/") { }

        public async Task<Summoner> GetByAccountId(long accountId)
        {
            return await Execute<Summoner>($"summoners/by-account/{accountId}");
        }

        public async Task<Summoner> GetBySummonerName(string summonerName)
        {
            return await Execute<Summoner>($"summoners/by-name/{summonerName}");
        }

        public async Task<Summoner> GetBySummonerId(long summonerId)
        {
            return await Execute<Summoner>($"summoners/{summonerId}");
        }
    }
}
