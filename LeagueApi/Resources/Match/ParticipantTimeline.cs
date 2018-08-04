using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Match
{
    public class ParticipantTimeline
    {
        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public (string, double) CSDiffPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public (string, double) GoldPerMinDeltas { get; set; }

        [JsonProperty("xpDiffPerMinDeltas")]
        public (string, double) XPDiffPerMinDeltas { get; set; }

        [JsonProperty("creepsPerMinDeltas")]
        public (string, double) CreepsPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public (string, double) XPPerMinDeltas { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public (string, double) DamageTakenDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public (string, double) DamageTakenPerMinDeltas { get; set; }
    }
}
