using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Client.Models
{
    public class Forecast
    {
        public Headline Headline { get; set; }
        public DailyForecasts[] DailyForecasts { get; set; }
    }
}
