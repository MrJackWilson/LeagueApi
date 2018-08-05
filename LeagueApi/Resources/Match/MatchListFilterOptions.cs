using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueApi.Resources.Match
{
    public class MatchListFilterOptions
    {
        public long BeginTime { get; set; } = -1;
        public long EndTime { get; set; } = -1;
        public int BeginIndex { get; set; } = -1;
        public int EndIndex { get; set; } = -1;
        public IEnumerable<int> Champion { get; set; }
        public IEnumerable<int> Queue { get; set; }
        public IEnumerable<int> Season { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (BeginTime != -1)
                sb.Append($"beginTime={BeginTime}");
            
            if (EndTime != -1)
                sb.Append($"&endTime={EndTime}");
            
            if (BeginIndex != -1)
                sb.Append($"&beginIndex={BeginIndex}");
            
            if (EndIndex != -1)
                sb.Append($"&endIndex={EndIndex}");

            if (Champion != null)
                sb.Append($"&champion={string.Join(",", Champion)}");

            if (Queue != null)
                sb.Append($"&queue={string.Join(",", Queue)}");

            if (Season != null)
                sb.Append($"&season={string.Join(",", Season)}");

            return sb.ToString();
        }
    }
}
