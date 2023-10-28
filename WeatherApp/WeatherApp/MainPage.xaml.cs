namespace WeatherApp;

using Microsoft.Extensions.Configuration;
using WeatherApp.Client.ViewModels;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}


