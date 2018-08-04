using LeagueApi.Constants;
using LeagueApi.Resources.League;
using LeagueApi.Resources.Match;
using LeagueApi.Resources.Spectator;
using LeagueApi.Resources.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApi
{
    public class Program
    {
        static readonly string _summonerId = "44997133";
        static readonly string _accountId = "203721071";

        public static void Main(string[] args)
        {
            using (var api = new Api("spectator/v3/"))
            {
                Task.Run(async () =>
                {
                    var result = await api.Execute<FeaturedGames>($"featured-games");

                    Console.WriteLine(result.ClientRefreshInterval);

                }).Wait();
            }

            Console.ReadLine();
        }
    }
}
