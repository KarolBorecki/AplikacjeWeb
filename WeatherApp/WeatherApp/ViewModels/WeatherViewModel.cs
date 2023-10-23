using WeatherApp.Client.Models;

namespace WeatherApp.Client.ViewModels
{
    public class WeatherViewModel
    {
        public WeatherViewModel(Weather weather)
        {
            CurrentTemperature = weather.Temperature.Metric.Value;
            HasPrecipitation = weather.HasPrecipitation;
        }
        public double CurrentTemperature { get; set; }
        public bool HasPrecipitation { get; set;}
    }
}
