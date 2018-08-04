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

        [JsonProperty("bans")]
        public IEnumerable<TeamBans> Bans { get; set; }

        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }

        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
    }
}
