using WeatherApp.Client.Models;

namespace WeatherApp.Client.Services
{
    public interface IAccuWeatherService
    {
        Task<City[]> GetLocations(string locationName);
        Task<City> GetNeighbourCity(string cityKey);
        Task<City> GetTopCity();
        Task<City> GetCityInfo(string cityKey);
        Task<City> GetCityByIPAddress(string ip);
        Task<Weather> GetCurrentConditions(string cityKey);
        Task<Forecast> GetForecast(string cityKey, string numOfDays);
        String GetLang();
    }
}
