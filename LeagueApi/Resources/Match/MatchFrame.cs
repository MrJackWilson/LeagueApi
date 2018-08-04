using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Match
{
    public class MatchFrame
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("participantFrames")]
        public IDictionary<int, MatchParticipantFrame> ParticipantFrames { get; set; }

        [JsonProperty("events")]
        public IEnumerable<MatchEvent> Events { get; set; }
    }
}
