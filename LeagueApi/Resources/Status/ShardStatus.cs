using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Status
{
    public class ShardStatus
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_tag")]
        public string RegionTag { get; set; }

        [JsonProperty("hostname")]
        public string HostName { get; set; }

        [JsonProperty("services")]
        public IEnumerable<Service> Services { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("locales")]
        public IEnumerable<string> Locales { get; set; }
    }
}
