﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Models
{
    internal class Forecast
    {
        public Headline Headline { get; set; }
        public DailyForecasts DailyForecasts { get; set; }
    }
}
