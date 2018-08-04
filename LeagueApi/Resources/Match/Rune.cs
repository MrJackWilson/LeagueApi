using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Match
{
    public class Rune
    {
        [JsonProperty("runeId")]
        public int RuneId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
