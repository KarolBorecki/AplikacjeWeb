using WeatherApp.Client.ViewModels;
using WeatherApp.Client.Services;

namespace WeatherApp;

public partial class App : Application
{
    IServiceProvider _serviceProvider;

    public App()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        _serviceProvider = serviceCollection.BuildServiceProvider();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IAccuWeatherService, AccuWeatherService>();
        services.AddSingleton<MainViewModel>();
        services.AddTransient<MainPage>();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        if (this.MainPage == null)
        {
            this.MainPage = new MainPage();
        }

        return base.CreateWindow(activationState);
    }
}

