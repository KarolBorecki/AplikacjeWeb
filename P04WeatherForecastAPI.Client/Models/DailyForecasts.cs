using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Models
{
    internal class DailyForecasts
    {
        public DateTime Date { get; set; }
        public RealFeelTemperature RealFeelTemperature { get; set; }
    }
}
