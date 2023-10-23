using WeatherApp.Client.Models;

namespace WeatherApp.Client.ViewModels
{
    public class ForecastViewModel
    {
        public ForecastViewModel(Forecast forecast)
        {
            ForecastRealFeelTemperature = forecast.DailyForecasts[0].Temperature.Maximum.Value;
        }
        public double ForecastRealFeelTemperature { get; set; }
    }
}
