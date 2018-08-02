using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Models.Champion
{
    [JsonObject]
    public class ChampionList : IEnumerable<Champion>
    {
        [JsonProperty("champions")]
        private IEnumerable<Champion> All { get; set; }

        public IEnumerator<Champion> GetEnumerator()
        {
            return All.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
