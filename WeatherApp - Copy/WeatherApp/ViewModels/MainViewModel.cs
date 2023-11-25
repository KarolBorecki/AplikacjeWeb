using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Client.Models;
using WeatherApp.Client.Models.Bookshelf;
using WeatherApp.Client.Services;
using Microsoft.Maui.Controls;

namespace WeatherApp.Client.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        IBookshelfService _bookshelfService;
        public MainViewModel(IBookshelfService bookshelfService)
        {
            _bookshelfService = bookshelfService;
        }


        [RelayCommand]
        public async void GoToBooksPage()
        {
            App.Current.MainPage = new NavigationPage(new BooksPage(new BooksViewModel(_bookshelfService)));
        }

        [RelayCommand]
        public async void GoToAuthorsPage()
        {
            App.Current.MainPage = new NavigationPage(new AuthorsPage(new AuthorsViewModel(_bookshelfService)));
        }
    }
}
