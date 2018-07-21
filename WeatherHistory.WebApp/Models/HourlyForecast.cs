using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHistory.WebApp.Models
{
    public class HourlyForecast
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public IEnumerable<HourlyForecastData> Data { get; set; }
    }
}
