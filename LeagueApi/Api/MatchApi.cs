using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueApi.Resources.Match;

namespace LeagueApi.Api
{
    public class MatchApi : BaseApi
    {
        public MatchApi() : base("match/v3/") { }

        public async Task<Match> GetMatchById(long matchId)
        {
            return await Execute<Match>($"matches/{matchId}");
        }

        public async Task<MatchList> GetMatchListByAccountId(long accountId)
        {
            return await Execute<MatchList>($"matchlists/by-account/{accountId}");
        }

        public async Task<MatchList> GetMatchListByAccountId(long accountId, MatchListFilterOptions matchListFilterOptions)
        {
            if (matchListFilterOptions == null) throw new ArgumentNullException(nameof(matchListFilterOptions));

            return await Execute<MatchList>($"matchlists/by-account/{accountId}?{matchListFilterOptions.ToString()}");
        }

        public async Task<MatchTimeline> GetTimelineByMatchId(long matchId)
        {
            return await Execute<MatchTimeline>($"timelines/by-match/{matchId}");
        }

        public async Task<IEnumerable<long>> GetMatchIdsByTournamentCode(string tournamentCode)
        {
            return await Execute<IEnumerable<long>>($"matches/by-tournament-code/{tournamentCode}/ids");
        }

        public async Task<MatchList> GetMatchByIdAndTournamentCode(long matchId, string tournamentCode)
        {
            return await Execute<MatchList>($"matches/{matchId}/by-tournament-code/{tournamentCode}");
        }
    }
}
