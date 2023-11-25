using WeatherApp.Client.Models.Bookshelf;

namespace WeatherApp.Client.ViewModels
{
    public class AuthorViewModel
    {
        public string name { get; set; }

        public AuthorViewModel(Author author)
        {
            name = author.name; 
        }

        public override String ToString()
        {
            return name;
        }
    }
}
