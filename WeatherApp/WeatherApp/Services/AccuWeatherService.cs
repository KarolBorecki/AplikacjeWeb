using System.Text.Json;
using WeatherApp.Client.Models;
using Microsoft.Extensions.Configuration;

namespace WeatherApp.Client.Services
{
    internal class AccuWeatherService : IAccuWeatherService
    {
        private string base_url;
        private string api_key;
        private string language;

        private AppSettings _settings;

        public AccuWeatherService(IConfiguration config)
        {
            _settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();
            base_url = _settings.accu_weather.base_url;
            api_key = _settings.accu_weather.api_key;
            language = _settings.default_language;
        }


        public async Task<City[]> GetLocations(string locationName)
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.autocomplete_endpoint, api_key, locationName, language);
            Console.WriteLine("Calling for cities: " + uri);
            return await GetResponseForEndpoint<City[]>(uri);
        }

        public async Task<City> GetNeighbourCity(string cityKey)
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.city_neigh_by_locationkey_endpoint, cityKey, api_key, language);
            Console.WriteLine("Calling for neighbour: " + uri);
            var cities = await GetResponseForEndpoint<City[]>(uri);
            return cities.FirstOrDefault();
        }

        public async Task<City> GetTopCity()
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.city_top_worldwide_endpoint, 50, api_key, language);
            Console.WriteLine("Calling for top city: " + uri);
            var top50Cities = await GetResponseForEndpoint<City[]>(uri);
            return top50Cities.FirstOrDefault();
        }

        public async Task<City> GetCityInfo(string cityKey)
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.city_info_by_location_key_endpoint, cityKey, api_key, language);
            Console.WriteLine("Calling for city info: " + uri);
            return await GetResponseForEndpoint<City>(uri);
        }

        public async Task<City> GetCityByIPAddress(string ip)
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.city_by_ip_endpoint, api_key, ip, language);
            Console.WriteLine("Calling for city by ip: " + uri);
            return await GetResponseForEndpoint<City>(uri);
        }

        public async Task<Weather> GetCurrentConditions(string cityKey)
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.current_conditions_endpoint, cityKey, api_key, language);
            Console.WriteLine("Calling for conditions: " + uri);
            var weathers = await GetResponseForEndpoint<Weather[]>(uri);
            return weathers.FirstOrDefault();
        }

        public async Task<Forecast> GetForecast(string cityKey, string numOfDays)
        {
            string uri = base_url + "/" + string.Format(_settings.accu_weather.day_of_daily_forecast_endpoint, numOfDays, cityKey, api_key, language);
            Console.WriteLine("Calling for forecast: " + uri);
            return await GetResponseForEndpoint<Forecast>(uri);
        }

        public async Task<T> GetResponseForEndpoint<T>(string uri)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json: " + json);
                    var result = JsonSerializer.Deserialize<T>(json);
                    return result;
                }
            }
        }

        public String GetLang()
        {
            return language;
        }
    }
}
