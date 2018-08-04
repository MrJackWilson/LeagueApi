using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Match
{
    public class TeamStats
    {
        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }
    }
}
