using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using P04WeatherForecastAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace P04WeatherForecastAPI.Client.Services
{
    internal class AccuWeatherService
    {
        private const string base_url = "http://dataservice.accuweather.com";
        private const string autocomplete_endpoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}&language{2}";
        private const string current_conditions_endpoint = "currentconditions/v1/{0}?apikey={1}&language{2}";

        // TODO: NEW ENDPOINTS 
        private const string city_neigh_by_locationkey_endpoint = "locations/v1/cities/neighbors/{0}?apikey={1}&language{2}";
        private const string day_of_daily_forecast_endpoint = "forecasts/v1/daily/1day/{0}?apikey={1}&language{2}";

        // private const string api_key = "5hFl75dja3ZuKSLpXFxUzSc9vXdtnwG5";
        string api_key;
        //private const string language = "pl";
        string language;

        public AccuWeatherService()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<App>()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json");

            var configuration = builder.Build();
            api_key = configuration["api_key"];
            language = configuration["default_language"];
        }


        public async Task<City[]> GetLocations(string locationName)
        {
            string uri = base_url + "/" + string.Format(autocomplete_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City cities2 = JsonConvert.DeserializeObject<City>(json);
                City[] citiesArr = new City[1];
                citiesArr[0] = cities2;
                return citiesArr;
                City[] cities = JsonConvert.DeserializeObject<City[]>(json);
                return cities;

            }
        }

        public async Task<City> GetNeighbourCity(string cityKey)
        {
            string uri = base_url + "/" + string.Format(city_neigh_by_locationkey_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                Trace.WriteLine("cities json: "+json);
                City[] cities = JsonConvert.DeserializeObject<City[]>(json);
                return cities.FirstOrDefault();
            }
        }

        public async Task<Weather> GetCurrentConditions(string cityKey)
        {
            string uri = base_url + "/" + string.Format(current_conditions_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                Weather[] weathers = JsonConvert.DeserializeObject<Weather[]>(json);
                return weathers.FirstOrDefault();
            }
        }

        public async Task<Forecast> GetForecast(string cityKey, string numOfDays)
        {
            string uri = base_url + "/" + string.Format(day_of_daily_forecast_endpoint, cityKey, api_key, language);
            System.Diagnostics.Debug.WriteLine("uri: "+uri);
            Trace.WriteLine("uri: "+uri);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine("json: "+json);
                Trace.WriteLine("json: "+json);
                Forecast forecast = JsonConvert.DeserializeObject<Forecast>(json);
                return forecast;
            }
        }
    }
}
