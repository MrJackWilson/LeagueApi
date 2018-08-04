using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Match
{
    public class Mastery
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
