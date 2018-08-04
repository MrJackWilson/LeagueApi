using System;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Spectator
{
    public class GameCustomizationObject
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
