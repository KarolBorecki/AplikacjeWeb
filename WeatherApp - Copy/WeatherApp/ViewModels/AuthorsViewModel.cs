using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Client.Models;
using WeatherApp.Client.Models.Bookshelf;
using WeatherApp.Client.Services;

namespace WeatherApp.Client.ViewModels
{
    public partial class AuthorsViewModel : ObservableObject
    {

        private readonly IBookshelfService _bookshelfService;

        public AuthorsViewModel(IBookshelfService bookshelfService)
        {
            _bookshelfService = bookshelfService;
            Console.WriteLine("Main Vieww");
            GotBooks = new ObservableCollection<BookViewModel>();
        }

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
            if (books != null)
                foreach (var book in books)
                {
                    GotBooks.Add(new BookViewModel(book));
                    Console.WriteLine("Got book: " + book.name);
                }


        }

        private async void LoadAuthorFromAPI(long id)
        {
            var author = await _bookshelfService.GetAuthor(id);
            if (author != null)
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

        [RelayCommand]
        public async void Back()
        {
            App.Current.MainPage = new NavigationPage(new MainPage(new MainViewModel(_bookshelfService)));
        }
    }
}
