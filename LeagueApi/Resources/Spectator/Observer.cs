using System;
using Newtonsoft.Json;

namespace LeagueApi.Resources.Spectator
{
    public class Observer
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}
