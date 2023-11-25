using System;
namespace WeatherApp.Client.Models.Bookshelf
{
    public class Book
	{
        public long id { get; set; }
        public string name { get; set; }
        public long authorId { get; set; }
        public DateTime publishDate { get; set; }
	}
}

