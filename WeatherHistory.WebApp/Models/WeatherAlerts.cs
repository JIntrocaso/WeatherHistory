using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHistory.WebApp.Models
{
    public class WeatherAlerts
    {
        public string Title { get; set; }
        public long UnixTime { get; set; }
        public long UnixExpires { get; set; }
        public string Description { get; set; }
        public string Uri { get; set; }
    }
}
