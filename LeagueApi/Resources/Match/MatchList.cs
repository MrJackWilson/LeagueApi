using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Match
{
    public class MatchList
    {
        [JsonProperty("matches")]
        public IEnumerable<MatchReference> Matches { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }
}
