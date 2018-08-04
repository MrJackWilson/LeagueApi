using System;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Match
{
    public class ParticipantIdentity
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
    }
}
