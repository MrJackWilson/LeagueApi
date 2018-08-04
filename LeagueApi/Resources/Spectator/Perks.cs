using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Spectator
{
    public class Perks
    {
        [JsonProperty("perkStyle")]
        public long PerkStyle { get; set; }

        [JsonProperty("perkIds")]
        public IEnumerable<long> PerkIds { get; set; }

        [JsonProperty("perkSubStyle")]
        public long PerkSubStyle { get; set; }
    }
}
