using WeatherApp.Client.ViewModels;

namespace WeatherApp;

public partial class AuthorsPage : ContentPage
{
	public AuthorsPage(AuthorsViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}