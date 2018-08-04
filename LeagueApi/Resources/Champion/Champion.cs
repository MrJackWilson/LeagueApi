using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Champion
{
    public class Champion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }

        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }

        [JsonProperty("botMmEnabled")]
        public bool BotMMEnabled { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }

        public void Log()
        {
            var sb = new StringBuilder();

            sb.Append($"Id: {Id}\n");
            sb.Append($"Ranked play enabled: {RankedPlayEnabled}\n");
            sb.Append($"Bot enabled: {BotEnabled}\n");
            sb.Append($"Bot Mm enabled: {BotMMEnabled}\n");
            sb.Append($"Active: {Active}\n");
            sb.Append($"Free to play: {FreeToPlay}\n\n");

            Console.WriteLine(sb.ToString());
        }
    }
}
