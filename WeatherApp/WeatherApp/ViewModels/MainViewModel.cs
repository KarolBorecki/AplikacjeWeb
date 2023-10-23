using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Client.Models;
using WeatherApp.Client.Services;

namespace WeatherApp.Client.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private CityViewModel _selectedCity;
        private CityViewModel _topCityWorldwide;
        private CityInfoViewModel _selectedCityInfo;
        private CityViewModel _neighbourCity;
        private WeatherViewModel _weatherView;
        private ForecastViewModel _forecastViewModel;
        private CityViewModel _cityByIP;
        private Weather _weather;
        private Forecast _forecast;
        private readonly IAccuWeatherService _accuWeatherService;

        public MainViewModel()
        {
            _accuWeatherService = new AccuWeatherService();
            Cities = new ObservableCollection<CityViewModel>();

            //_weather = new Weather();
            //Temperature t = new Temperature();
            //Metric m = new Metric();
            //m.Value = 69;
            //t.Metric = m;
            //_weather.Temperature = t;
            //weatherView = new WeatherViewModel(_weather);
        }

        // Wheather / Neighbour city
        public WeatherViewModel WeatherView
        {
            get => _weatherView;
            set
            {
                _weatherView = value;
                OnPropertyChanged();
            }
        }

        public CityViewModel NeighbourCityView
        {
            get => _neighbourCity;
            set
            {
                _neighbourCity = value;
                OnPropertyChanged();
            }
        }


        public CityViewModel SelectedCity
        {
            get => _selectedCity;
            set
            {
                _selectedCity = value;

                OnPropertyChanged();
                LoadWeather();
                LoadNeighbourCity();
                LoadSelectedCityInfo();
                LoadForecast();
                LoadCityInfo();
            }
        }

         
        private async void LoadWeather()
        {
           
            if(SelectedCity != null)
            {
                _weather = await _accuWeatherService.GetCurrentConditions(SelectedCity.Key);
                WeatherView = new WeatherViewModel(_weather);
                Console.WriteLine("weather: " + WeatherView.CurrentTemperature);
            }
        }

        private async void LoadNeighbourCity()
        {
            if(SelectedCity != null)
            {
                var city = await _accuWeatherService.GetNeighbourCity(SelectedCity.Key);
                NeighbourCityView = new CityViewModel(city);
            }
        }

        // Top city worldwide
        public CityViewModel TopCityWorldwide
        {
            get => _topCityWorldwide;
            set
            {
                _topCityWorldwide = value;
                OnPropertyChanged();
            }
        }

        private async void LoadTopCityWorldwide()
        {
            var city = await _accuWeatherService.GetTopCity();
            TopCityWorldwide = new CityViewModel(city);
        }

        // City info
        public CityInfoViewModel CityInfo
        {
            get => _selectedCityInfo;
            set
            {
                _selectedCityInfo = value;
                OnPropertyChanged();
            }
        }

        private async void LoadCityInfo()
        {
            if(SelectedCity != null)
            {
                var city = await _accuWeatherService.GetCityInfo(SelectedCity.Key);
                CityInfo = new CityInfoViewModel(city);
            }
        }

        // Selected city info
        public CityInfoViewModel CityInfoViewModel
        {
            get => _selectedCityInfo;
            set
            {
                _selectedCityInfo = value;
                OnPropertyChanged();
            }
        }

        private async void LoadSelectedCityInfo()
        {
            if(SelectedCity != null)
            {
                var city = await _accuWeatherService.GetCityInfo(SelectedCity.Key);
                CityInfoViewModel = new CityInfoViewModel(city);
            }
        }

        // City by IP
        public CityViewModel CityByIP
        {
            get => _cityByIP;
            set
            {
                _cityByIP = value;
                OnPropertyChanged();
            }
        }

        private async void LoadCityByIPAddress()
        {
            var ip = IPAddressService.GetLocalIPAddress();
            var city = await _accuWeatherService.GetCityByIPAddress(ip);
            CityByIP = new CityViewModel(city);
        }


        // Forecast
        public ForecastViewModel Forecast
        {
            get => _forecastViewModel;
            set
            {
                _forecastViewModel = value;
                OnPropertyChanged();
            }
        }

        private async void LoadForecast()
        {
            if (SelectedCity != null)
            {
                _forecast = await _accuWeatherService.GetForecast(SelectedCity.Key, "1");
                Console.WriteLine();
                Forecast = new ForecastViewModel(_forecast);
                Console.WriteLine("firecadt: " + Forecast.ForecastRealFeelTemperature);
            }
        }

        // City searching
        public ObservableCollection<CityViewModel> Cities { get; set; }

        [RelayCommand]
        public async void LoadCities(string locationName)
        {
            var cities = await _accuWeatherService.GetLocations(locationName);
            Cities.Clear();
            foreach (var city in cities)
                Cities.Add(new CityViewModel(city));
        }

        [RelayCommand]
        public async void LoadIP()
        {
            LoadCityByIPAddress();
        }

        [RelayCommand]
        public async void LoadTop()
        {
            LoadTopCityWorldwide();
        }
    }
}
