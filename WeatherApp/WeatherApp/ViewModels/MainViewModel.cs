using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Client.Models;
using WeatherApp.Client.Models.Bookshelf;
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
        private readonly IBookshelfService _bookshelfService;

        public MainViewModel(IAccuWeatherService accuWeatherService, IBookshelfService bookshelfService)
        {
            //_accuWeatherService = Application.Current.Handler.MauiContext.Services.GetService<AccuWeatherService>();
            _accuWeatherService = accuWeatherService;
            _bookshelfService = bookshelfService;
            Console.WriteLine("Main Vieww");
            Console.WriteLine("Loaded accu weather service lang: " + _accuWeatherService.GetLang());
            Cities = new ObservableCollection<CityViewModel>();
            GotBooks = new ObservableCollection<BookViewModel>();
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
                Console.WriteLine("firecast: " + Forecast.ForecastRealFeelTemperature);
            }
        }

        // City searching
        public ObservableCollection<CityViewModel> Cities { get; set; }

        [RelayCommand]
        public async void LoadCities(string locationName)
        {
            Console.WriteLine("Clicked SEARCH");
            var cities = await _accuWeatherService.GetLocations(locationName);
            Cities.Clear();
            foreach (var city in cities)
                Cities.Add(new CityViewModel(city));
        }

        [RelayCommand]
        public async void LoadIP()
        {
            Console.WriteLine("Clicked IP");
            LoadCityByIPAddress();
        }

        [RelayCommand]
        public async void LoadTop()
        {
            Console.WriteLine("Clicked TOP");
            LoadTopCityWorldwide();
        }

        // Bookshelf

        // Author data
        public ObservableCollection<BookViewModel> GotBooks { get; set; }
        private AuthorViewModel _authorViewModel;
        public AuthorViewModel GotAuthor
        {
            get => _authorViewModel;
            set
            {
                _authorViewModel = value;
                OnPropertyChanged();
            }
        }

        private async void LoadBooksFromAPI(long id)
        {
            GotBooks.Clear();
            var books = await _bookshelfService.GetBooks(id);
            Console.WriteLine("Getting books...");
            if(books != null)
                foreach (var book in books)
                {
                    GotBooks.Add(new BookViewModel(book));
                    Console.WriteLine("Got book: " + book.name);
                }

                
        }

        private async void LoadAuthorFromAPI(long id)
        {
            var author = await _bookshelfService.GetAuthor(id);
            if(author != null)
                GotAuthor = new AuthorViewModel(author);
            else
                GotAuthor = null;
        }

        [RelayCommand]
        public async void LoadAuthorData(string id)
        {
            Console.WriteLine("Clicked Load Author data");
            long convertedId = Int64.Parse(id);
            LoadAuthorFromAPI(convertedId);
            LoadBooksFromAPI(convertedId);
        }

        // PUT author
        private async void PutAuthorToAPI(Author author)
        {
            var response = await _bookshelfService.PutAuthor(author);
            Console.WriteLine(response);
        }

        [RelayCommand]
        public async void PutAuthorData(Author author)
        {
            Console.WriteLine("Clicked Put Author data");
            PutAuthorToAPI(author);
        }

        // PUT book
        private async void PutBookToAPI(Book book)
        {
            var response = await _bookshelfService.PutBook(book);
            Console.WriteLine(response);
        }

        [RelayCommand]
        public async void PutBookData(Book book)
        {
            Console.WriteLine("Clicked Put Book data");
            PutBookToAPI(book);
        }
    }
}
