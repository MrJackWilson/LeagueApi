using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.League
{
    public class LeagueList
    {
        [JsonProperty("leagueId")]
        public string LeagueId { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<LeagueItem> Entries { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
