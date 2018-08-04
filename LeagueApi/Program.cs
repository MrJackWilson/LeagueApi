using LeagueApi.Constants;
using LeagueApi.Resources.League;
using LeagueApi.Resources.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApi
{
    public class Program
    {
        private static readonly string _summonerId = "44997133";

        public static void Main(string[] args)
        {
            using (var api = new Api("match/v3/"))
            {
                Task.Run(async () =>
                {
                    var result = await api.Execute<IEnumerable<LeaguePosition>>($"positions/by-summoner/{_summonerId}");

                }).Wait();
            }

            Console.ReadLine();
        }
    }
}
