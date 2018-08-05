using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueApi.Exceptions;

namespace LeagueApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long summonerId = 0;

            Task.Run(async () =>
            {
                using (var api = new SummonerApi())
                {
                    var summoner = await api.GetBySummonerName("Tennant Lady");
                    if (summoner != null)
                        summonerId = summoner.Id;
                }

                if (summonerId > 0)
                {
                    using (var api = new ChampionMasteryApi())
                    {
                        Console.WriteLine(await api.GetChampionMasteryScoreBySummonerId(summonerId));
                    }
                }
            }).Wait();
        }
    }
}
