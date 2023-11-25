using Microsoft.Extensions.Configuration;
using System.Reflection;
using Microsoft.Extensions.Logging;
using WeatherApp.Client.Services;
using WeatherApp.Client.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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

        HttpClientHandler handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
        {
            return true;
        };
		HttpClient httpClient = new HttpClient(handler, false);
		builder.Services.AddSingleton<HttpClient>(httpClient);

        builder.Services.AddSingleton<IBookshelfService, BookshelfService>();

        builder.Services.AddTransient<AuthorsPage>();
        builder.Services.AddTransient<BooksPage>();
        builder.Services.AddTransient<MainPage>();

        builder.Services.AddSingleton<AuthorsViewModel>();
        builder.Services.AddSingleton<BooksViewModel>();
        builder.Services.AddSingleton<MainViewModel>();


        //builder.Services.AddHttpClient<IBookshelfService, BookshelfService>(httpClient);

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

