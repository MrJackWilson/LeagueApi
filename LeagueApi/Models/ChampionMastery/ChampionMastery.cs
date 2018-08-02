using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Models.ChampionMastery
{
    public class ChampionMastery
    {
        [JsonProperty("chestGranted")]
        public bool ChestGranted { get; set; }

        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("playerId")]
        public long PlayerId { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("tokensEarned")]
        public int TokensEarned { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }

        public void Log()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Chest granted: {ChestGranted}");
            sb.AppendLine($"Champion level: {ChampionLevel}");
            sb.AppendLine($"Champion points: {ChampionPoints}");
            sb.AppendLine($"Champion Id: {ChampionId}");
            sb.AppendLine($"Player Id: {PlayerId}");
            sb.AppendLine($"Points to next level: {ChampionPointsUntilNextLevel}");
            sb.AppendLine($"Tokens earned: {TokensEarned}");
            sb.AppendLine($"Points since last level: {ChampionPointsSinceLastLevel}");
            sb.AppendLine($"Last play time: {LastPlayTime}");

            Console.WriteLine(sb.ToString());
        }
    }
}
