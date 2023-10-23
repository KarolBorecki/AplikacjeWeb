using WeatherApp.Client.Models;

namespace WeatherApp.Client.ViewModels
{
    public class CityInfoViewModel
    {
        public string EnglishName { get; set; }

        public CityInfoViewModel(City city)
        {
            EnglishName = city.EnglishName; 
        }
    }
}
