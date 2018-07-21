using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WeatherHistory.WebApp.App_Code
{
    public static class GlobalVariables
    {
        public static string LocationName
        {
            get
            {
                return WebConfigurationManager.AppSettings["LocationName"];
            }
        }
        public static decimal LocationLat
        {
            get
            {
                return Convert.ToDecimal(WebConfigurationManager.AppSettings["LocationLat"]);
            }
        }

        public static decimal LocationLong
        {
            get
            {
                return Convert.ToDecimal(WebConfigurationManager.AppSettings["LocationLong"]);
            }
        }

        public static string DarkSkyBaseUri
        {
            get
            {
                return "https://api.darksky.net/";
            }
        }

        public static string DarkSkyKey
        {
            get
            {
                return WebConfigurationManager.AppSettings["DarkSkyKey"];
            }
        }


    }
}