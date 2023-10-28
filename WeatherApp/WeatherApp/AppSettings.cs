using System;
namespace WeatherApp
{
    public class AccuWeather
    {
        public string api_key { get; set; }
        public string base_url { get; set; }
        public string autocomplete_endpoint { get; set; }
        public string current_conditions_endpoint { get; set; }
        public string city_neigh_by_locationkey_endpoint { get; set; }
        public string city_top_worldwide_endpoint { get; set; }
        public string city_info_by_location_key_endpoint { get; set; }
        public string city_by_ip_endpoint { get; set; }
        public string day_of_daily_forecast_endpoint { get; set; }
    }

    public class Bookshlef
    {
        public string base_url { get; set; }
        public string getbooks_enpoint { get; set; }
        public string geauthors_enpoint { get; set; }
        public string getbook_endpoint { get; set; }
        public string getauthor_endpoint { get; set; }
        public string putbook_endpoint { get; set; }
        public string putAuthor_endpoint { get; set; }
    }

    public class AppSettings
    {
        public string default_language { get; set; }
        public AccuWeather accu_weather { get; set; }
        public Bookshlef bookshlef { get; set; }
    }

}

