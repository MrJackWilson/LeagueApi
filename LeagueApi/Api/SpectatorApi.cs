using System;
using System.Threading.Tasks;
using LeagueApi.Resources.Spectator;

namespace LeagueApi.Api
{
    public class SpectatorApi : BaseApi
    {
        public SpectatorApi() : base("spectator/v3/") { }

        public async Task<CurrentGameInfo> GetCurrentGameInfoBySummonerId(long summonerId)
        {
            return await Execute<CurrentGameInfo>($"active-games/by-summoner/{summonerId}");
        }

        public async Task<FeaturedGames> GetFeaturedGames()
        {
            return await Execute<FeaturedGames>("featured-games");
        }
    }
}
