using WeatherApp.Client.Models.Bookshelf;

namespace WeatherApp.Client.ViewModels
{
    public class BookViewModel
    {
        public string name { get; set; }
        public DateTime dateTime { get; set; }

        public BookViewModel(Book book)
        {
            name = book.name;
            dateTime = book.publishDate;
        }

        public override String ToString()
        {
            return name + "   " + dateTime.ToString();
        }
    }
}
