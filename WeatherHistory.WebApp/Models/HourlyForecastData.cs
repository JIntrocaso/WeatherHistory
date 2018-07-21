using WeatherHistory.WebApp.Interfaces;

namespace WeatherHistory.WebApp.Models
{
    public class HourlyForecastData : IWeatherForecast
    {
        public long Time { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public decimal PrecipIntensity { get; set; }
        public decimal PrecipProbability { get; set; }
        public string PrecipType { get; set; }
        public decimal Temperature { get; set; }
        public decimal ApparentTemperature { get; set; }
        public decimal DewPoint { get; set; }
        public decimal Humidity { get; set; }
        public decimal Pressure { get; set; }
        public decimal WindSpeed { get; set; }
        public decimal WindGust { get; set; }
        public int WindBearing { get; set; }
        public decimal CloudCover { get; set; }
        public decimal UVIndex { get; set; }
        public decimal Visibility { get; set; }
        public decimal Ozone { get; set; }
    }
}