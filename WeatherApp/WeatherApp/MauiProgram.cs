using Microsoft.Extensions.Configuration;
using System.Reflection;
using Microsoft.Extensions.Logging;
using WeatherApp.Client.Services;
using WeatherApp.Client.ViewModels;

namespace WeatherApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		var a = Assembly.GetExecutingAssembly();
		using var stream = a.GetManifestResourceStream("WeatherApp.appsettings.json");

		var config = new ConfigurationBuilder()
					.AddJsonStream(stream)
					.Build();

		builder.Configuration.AddConfiguration(config);
		builder
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<IAccuWeatherService, AccuWeatherService>();
        builder.Services.AddSingleton<IBookshelfService, BookshelfService>();
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

