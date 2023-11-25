namespace WeatherApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(BooksPage), typeof(BooksPage));
        Routing.RegisterRoute(nameof(AuthorsPage), typeof(AuthorsPage));
    }
}

