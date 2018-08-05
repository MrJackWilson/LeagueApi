using System;
using System.Threading.Tasks;
using LeagueApi.Resources.Champion;

namespace LeagueApi.Api
{
    public class ChampionApi : BaseApi
    {
        public ChampionApi() : base("platform/v3/") { }

        public async Task<ChampionList> GetAllChampions()
        {
            return await Execute<ChampionList>("champions");
        }

        public async Task<Champion> GetChampionById(long id)
        {
            return await Execute<Champion>($"champions/{id}");
        }
    }
}
