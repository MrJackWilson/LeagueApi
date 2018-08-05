using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueApi.Exceptions;
using LeagueApi.Api;
using LeagueApi.Resources.Match;

namespace LeagueApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChampionStaticDataApi.Load();
            var champ103 = ChampionStaticDataApi.GetById(103);

            Console.WriteLine(champ103.Name);
        }
    }
}
