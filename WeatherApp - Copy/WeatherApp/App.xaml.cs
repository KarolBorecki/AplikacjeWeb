using WeatherApp.Client.ViewModels;
using WeatherApp.Client.Services;
using Microsoft.Extensions.Configuration;
using WeatherApp;

namespace WeatherApp;

public partial class App : Application
{
    IServiceProvider _serviceProvider;
    IConfiguration _config;

    public App(MainPage page, IConfiguration config)
    {
        MainPage = new NavigationPage(page);
        _config = config;
        AppSettings _settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();
        Console.WriteLine("Config (App):");
        Console.WriteLine("lang: " + _settings.default_language);
    }


    protected override Window CreateWindow(IActivationState activationState)
    {
        return base.CreateWindow(activationState);
    }
}

