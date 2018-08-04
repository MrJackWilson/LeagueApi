using System;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Match
{
    public class MatchPosition
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
