using System;
using System.Net;

namespace LeagueApi.Exceptions
{
    public class LeagueApiException : Exception
    {
        public int ResponseCode { get; set; }

        public LeagueApiException(int code)
        {
            ResponseCode = code;
        }

        public LeagueApiException(HttpStatusCode code) : this((int)code) { }
    }
}
