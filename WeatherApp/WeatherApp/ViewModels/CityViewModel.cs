using WeatherApp.Client.Models;

namespace WeatherApp.Client.ViewModels
{
    public class CityViewModel
    {
        public string LocalizedName { get; set; }
        public string Key { get; set; }

        public CityViewModel(City city)
        {
            LocalizedName = city.LocalizedName; 
            Key = city.Key;
        }
    }
}
