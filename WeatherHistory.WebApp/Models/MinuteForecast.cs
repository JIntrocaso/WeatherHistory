using System.Collections.Generic;

namespace WeatherHistory.WebApp.Models
{
    public class MinuteForecast
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public IEnumerable<MinuteForecastData> Data { get; set; }
    }
}
