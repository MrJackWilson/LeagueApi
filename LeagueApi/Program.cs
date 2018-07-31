using LeagueApi;
using LeagueApi.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var api = new Api("platform/v3/champions/"))
            {
                Task.Run(async () =>
                {
                    Console.WriteLine("Executing...");

                    var allChampions = await api.Execute<Champions>("");

                    if (allChampions != null && allChampions != null)
                    {
                        foreach (var champion in allChampions)
                            champion.Log();
                    }
                    else
                    {
                        Console.WriteLine("No results");
                    }
                }).Wait();
            }

            Console.ReadLine();
        }
    }
}
