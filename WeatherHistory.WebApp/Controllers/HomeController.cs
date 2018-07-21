using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeatherHistory.WebApp.App_Code;
using WeatherHistory.WebApp.Models;

namespace WeatherHistory.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.LocationName = GlobalVariables.LocationName;
            return View();
        }

        public async Task<ActionResult> Forecast()
        {
            ViewBag.LocationName = GlobalVariables.LocationName;
            DarkSkyForecast forecast = await DarkSkyForecast.GetForecastInformationByDate(DateTime.Now);
            return View(forecast);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}