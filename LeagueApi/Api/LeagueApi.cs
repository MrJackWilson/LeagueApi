using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueApi.Resources.League;

namespace LeagueApi.Api
{
    public class LeagueApi : BaseApi
    {
        public LeagueApi() : base("league/v3/") { }

        public async Task<LeagueList> GetChallengerLeagueByQueue(string queue)
        {
            return await Execute<LeagueList>($"challengerleagues/by-queue/{queue}");
        }

        public async Task<LeagueList> GetLeagueById(string leagueId)
        {
            return await Execute<LeagueList>($"leagues/{leagueId}");
        }

        public async Task<LeagueList> GetMasterLeagueByQueue(string queue)
        {
            return await Execute<LeagueList>($"masterleagues/by-queue/{queue}");
        }

        public async Task<IEnumerable<LeaguePosition>> GetPositionsBySummonerId(long summonerId)
        {
            return await Execute<IEnumerable<LeaguePosition>>($"positions/by-summoner/{summonerId}");
        }
    }
}
