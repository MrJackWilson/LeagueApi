using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Spectator
{
    public class FeaturedGames
    {
        [JsonProperty("clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        [JsonProperty("gameList")]
        public IEnumerable<FeaturedGameInfo> GameList { get; set; }
    }
}
