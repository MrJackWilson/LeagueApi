using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Status
{
    public class Service
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("incidents")]
        public IEnumerable<Incident> Incidents { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
