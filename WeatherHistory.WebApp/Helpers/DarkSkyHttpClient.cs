using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHistory.WebApp.Helpers
{
    public sealed class DarkSkyHttpClient
    {
        static DarkSkyHttpClient() { }
        private DarkSkyHttpClient() { }

        public static HttpClient DarkSkyHttpClientObj { get; } = new HttpClient();
    }
}
