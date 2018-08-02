using LeagueApi;
using LeagueApi.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueApi.Models.Status;

namespace LeagueApi
{
    public class Program
    {
        private static readonly string _summonerId = "44997133";

        public static void Main(string[] args)
        {
            using (var api = new Api("status/v3/"))
            {
                Task.Run(async () =>
                {
                    var status = await api.Execute<ShardStatus>($"shard-data");

                }).Wait();
            }

            Console.ReadLine();
        }
    }
}
