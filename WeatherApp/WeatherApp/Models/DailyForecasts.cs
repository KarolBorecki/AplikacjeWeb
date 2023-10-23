using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Client.Models
{
    public class DailyForecasts
    {
        public DateTime Date { get; set; }
        public RealFeelTemperature Temperature { get; set; }
    }
}
