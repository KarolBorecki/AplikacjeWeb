using System;
namespace WeatherApp
{ 
    public class Bookshlef
    {
        public string base_url { get; set; }
        public string getbooks_enpoint { get; set; }
        public string geauthors_enpoint { get; set; }
        public string getbook_endpoint { get; set; }
        public string getauthor_endpoint { get; set; }
        public string putbook_endpoint { get; set; }
        public string putAuthor_endpoint { get; set; }

        public string delete_book_endpoint { get; set; }
    }

    public class AppSettings
    {
        public string default_language { get; set; }
        public Bookshlef bookshlef { get; set; }
    }

}

