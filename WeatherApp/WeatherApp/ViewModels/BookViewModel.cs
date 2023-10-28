using WeatherApp.Client.Models.Bookshelf;

namespace WeatherApp.Client.ViewModels
{
    public class BookViewModel
    {
        public string name { get; set; }

        public BookViewModel(Book book)
        {
            name = book.name; 
        }

        public override String ToString()
        {
            return name;
        }
    }
}
