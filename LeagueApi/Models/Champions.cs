using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Models
{
    [JsonObject]
    public class Champions : IEnumerable<Champion>
    {
        [JsonProperty("champions")]
        private IEnumerable<Champion> All { get; set; }

        public IEnumerator<Champion> GetEnumerator()
        {
            foreach (var champion in All)
                yield return champion;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
