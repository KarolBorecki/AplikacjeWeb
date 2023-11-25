using WeatherApp.Client.ViewModels;

namespace WeatherApp;

public partial class BooksPage : ContentPage
{

	public BooksPage(BooksViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}
}