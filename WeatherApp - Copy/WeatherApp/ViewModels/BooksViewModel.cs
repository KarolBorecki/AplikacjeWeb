using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherApp.Client.Models;
using WeatherApp.Client.Models.Bookshelf;
using WeatherApp.Client.Services;

namespace WeatherApp.Client.ViewModels
{
    public partial class BooksViewModel : ObservableObject
    {
        ObservableCollection<BookViewModel> GotBooks { get; set; }
        private readonly IBookshelfService _bookshelfService;

        public BooksViewModel(IBookshelfService bookshelfService)
        {
            _bookshelfService = bookshelfService;
            Console.WriteLine("Main Vieww");
            GotBooks = new ObservableCollection<BookViewModel>();
        }

        // Book data
        private BookViewModel _bookViewModel;
        
        public BookViewModel GotBook
        {
            get => _bookViewModel;
            set
            {
                _bookViewModel = value;
                OnPropertyChanged();
            }
        }

        private async void LoadBookFromAPI(long id)
        {
            var book = await _bookshelfService.GetBook(id);
            Console.WriteLine("Getting books...");
            GotBook = new BookViewModel(book);


        }

        [RelayCommand]
        public async void LoadBookData(string id)
        {
            Console.WriteLine("Clicked Load Book data");
            long convertedId = Int64.Parse(id);
            LoadBookFromAPI(convertedId);
        }

        // PUT book
        private async void PutBookToAPI(Book book)
        {
            var response = await _bookshelfService.PutBook(book);
            Console.WriteLine(response);
        }

        [RelayCommand]
        public async void PutBookData(Book book)
        {
            Console.WriteLine("Clicked Put Book data");
            PutBookToAPI(book);
        }

        // DELETE BOOK

        private async void DeleteBookById(long bookId)
        {
           
            var response = await _bookshelfService.DeleteBook(bookId);
            Console.WriteLine(response);
        }

        [RelayCommand]
        public async void DeleteBook(string id)
        {
            Console.WriteLine("Clicked DELETE Book data");
            long convertedId = Int64.Parse(id);
            DeleteBookById(convertedId);
        }
            

        [RelayCommand]
        public async void Back()
        {
            App.Current.MainPage = new NavigationPage(new MainPage(new MainViewModel(_bookshelfService)));
        }


    }
}
