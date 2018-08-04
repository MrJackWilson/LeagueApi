using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.League
{
    public class MiniSeries
    {
        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }
    }
}
