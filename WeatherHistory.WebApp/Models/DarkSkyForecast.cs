using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WeatherHistory.WebApp.Interfaces;
using System.Net.Http;
using WeatherHistory.WebApp.App_Code;
using RestSharp;
using Newtonsoft.Json;

namespace WeatherHistory.WebApp.Models
{
    public class DarkSkyForecast
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Timezone { get; set; }
        public CurrentForecast Currently { get; set; }
        public MinuteForecast Minutely { get; set; }
        public HourlyForecast Hourly { get; set; }
        public List<WeatherAlerts> Alerts { get; set; }
        
        //TODO Create Weekly Forecast property and classes

        public static async Task<DarkSkyForecast> GetForecastInformationByDate(DateTime date)
        {
            DarkSkyForecast forecast = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(GlobalVariables.DarkSkyBaseUri);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("forecast/" + GlobalVariables.DarkSkyKey + "/" + GlobalVariables.LocationLat.ToString() + "," + GlobalVariables.LocationLong.ToString());
                if (res.IsSuccessStatusCode)
                {
                    var forecastResponse = res.Content.ReadAsStringAsync().Result;

                    forecast = JsonConvert.DeserializeObject<DarkSkyForecast>(forecastResponse);
                }
            }
            return forecast;
        }
    }
}