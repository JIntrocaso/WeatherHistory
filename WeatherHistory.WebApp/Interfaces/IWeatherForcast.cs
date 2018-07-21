namespace WeatherHistory.WebApp.Interfaces
{
    public interface IWeatherForecast
    {
        long Time { get; set; }
        string Summary { get; set; }
        string Icon { get; set; }
        decimal PrecipIntensity { get; set; }
        decimal PrecipProbability { get; set; }
        string PrecipType { get; set; }
        decimal Temperature { get; set; }
        decimal ApparentTemperature { get; set; }
        decimal DewPoint { get; set; }
        decimal Humidity { get; set; }
        decimal Pressure { get; set; }
        decimal WindSpeed { get; set; }
        decimal WindGust { get; set; }
        int WindBearing { get; set; }
        decimal CloudCover { get; set; }
        decimal UVIndex { get; set; }
        decimal Visibility { get; set; }
        decimal Ozone { get; set; }

    }
}
