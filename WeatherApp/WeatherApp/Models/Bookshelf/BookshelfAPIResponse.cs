using System;
namespace WeatherApp.Client.Models.Bookshelf
{
	public class BookshelfAPIResponse<T>
	{
		public T data { get; set; }
		public string message { get; set; }
		public bool success { get; set; }

    }
}

