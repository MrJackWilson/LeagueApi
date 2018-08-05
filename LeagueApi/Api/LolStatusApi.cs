using System;
using System.Threading.Tasks;
using LeagueApi.Resources.Status;

namespace LeagueApi.Api
{
    public class LolStatusApi : BaseApi
    {
        public LolStatusApi() : base("status/v3/") { }

        public async Task<ShardStatus> GetShardStatus()
        {
            return await Execute<ShardStatus>("shard-data");
        }
    }
}
