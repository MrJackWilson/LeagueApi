using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueApi.Exceptions;
using LeagueApi.Api;

namespace LeagueApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                using (var api = new ChampionApi())
                {
                    Console.WriteLine(await api.GetChampionById(103));
                }
            }).Wait();
        }
    }
}
