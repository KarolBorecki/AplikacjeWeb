using System.Text.Json;
using WeatherApp.Client.Models;

namespace WeatherApp.Client.Services
{
    internal class AccuWeatherService : IAccuWeatherService
    {
        private HttpClient client;

        private const string base_url = "http://dataservice.accuweather.com";

        private const string autocomplete_endpoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}&language{2}";
        private const string current_conditions_endpoint = "currentconditions/v1/{0}?apikey={1}&language{2}";

        private const string city_neigh_by_locationkey_endpoint = "locations/v1/cities/neighbors/{0}?apikey={1}&language{2}";
        private const string city_top_worldwide_endpoint = "locations/v1/topcities/{0}?apikey={1}&language{2}";
        private const string city_info_by_location_key_endpoint = "locations/v1/{0}?apikey={1}&language{2}";
        private const string city_by_ip_endpoint = "locations/v1/cities/ipaddress?apikey={0}&q={1}&language{2}";
        private const string day_of_daily_forecast_endpoint = "forecasts/v1/daily/{0}day/{1}?apikey={2}&language{3}";

        string api_key = "0JSdIGlvYUJmfevMvJnWyWoOkkWZArai";
        string language = "pl";

        public AccuWeatherService()
        {
            //var builder = new ConfigurationBuilder()
            //    .AddUserSecrets<App>()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsetings.json");

            //var configuration = builder.Build();
            //api_key = configuration["api_key"];
            //language = configuration["default_language"];

           // client = new HttpClient();
        }


        public async Task<City[]> GetLocations(string locationName)
        {
            string uri = base_url + "/" + string.Format(autocomplete_endpoint, api_key, locationName, language);
            Console.WriteLine("Calling for cities: " + uri);

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for cities: " + json);
                    City[] cities = JsonSerializer.Deserialize<City[]>(json);
                    return cities;
                }
            }
        }

        public async Task<City> GetNeighbourCity(string cityKey)
        {
            string uri = base_url + "/" + string.Format(city_neigh_by_locationkey_endpoint, cityKey, api_key, language);
            Console.WriteLine("Calling for neighbour: " + uri);
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for neighbour: " + json);
                    City[] cities = JsonSerializer.Deserialize<City[]>(json);
                    return cities.FirstOrDefault();
                }
            }
        }

        public async Task<City> GetTopCity()
        {
            Console.WriteLine("Calling for top....");
            string uri = base_url + "/" + string.Format(city_top_worldwide_endpoint, 50, api_key, language);
            Console.WriteLine("Calling for top city: " + uri);
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for topcity: " + json);
                    City[] topCity = JsonSerializer.Deserialize<City[]>(json);
                    return topCity.FirstOrDefault();
                }
            }
        }

        public async Task<City> GetCityInfo(string cityKey)
        {
            string uri = base_url + "/" + string.Format(city_info_by_location_key_endpoint, cityKey, api_key, language);
            Console.WriteLine("Calling for city info: " + uri);
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for city info: " + json);
                    City cityInfo = JsonSerializer.Deserialize<City>(json);
                    Console.WriteLine("GOT ENGLISH NAME: " + cityInfo.EnglishName);
                    return cityInfo;
                }

            }
        }

        public async Task<City> GetCityByIPAddress(string ip)
        {
            string uri = base_url + "/" + string.Format(city_by_ip_endpoint, api_key, ip, language);
            Console.WriteLine("Calling for city by ip: " + uri);
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for city by ip: " + json);
                    City cityInfo = JsonSerializer.Deserialize<City>(json);
                    return cityInfo;
                }
            }
        }

        public async Task<Weather> GetCurrentConditions(string cityKey)
        {
            string uri = base_url + "/" + string.Format(current_conditions_endpoint, cityKey, api_key, language);
            Console.WriteLine("Calling for conditions: " + uri);
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for conditions: " + json);
                    Weather[] weathers = JsonSerializer.Deserialize<Weather[]>(json);
                    return weathers.FirstOrDefault();
                }
            }
        }

        public async Task<Forecast> GetForecast(string cityKey, string numOfDays)
        {
            string uri = base_url + "/" + string.Format(day_of_daily_forecast_endpoint, numOfDays, cityKey, api_key, language);
            Console.WriteLine("Calling for forecast: " + uri);
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json for forecast: " + json);
                    Forecast forecast = JsonSerializer.Deserialize<Forecast>(json);
                    Console.WriteLine("GTO FORECAST: " + forecast.DailyForecasts.FirstOrDefault().Temperature.Maximum.Value);
                    return forecast;
                }
            }
        }
    }
}
