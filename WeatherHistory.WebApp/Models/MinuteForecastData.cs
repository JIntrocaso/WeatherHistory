namespace WeatherHistory.WebApp.Models
{
    public class MinuteForecastData
    {
        public long Time { get; set; }
        public decimal PrecipIntensity { get; set; }
        public decimal PrecipIntensityError { get; set; }
        public decimal PrecipProbability { get; set; }
        public string PrecipType { get; set; }
    }
}
