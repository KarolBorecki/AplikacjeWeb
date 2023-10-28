using Microsoft.Extensions.Configuration;
using System.Text.Json;
using WeatherApp.Client.Models.Bookshelf;
using System.Text;

namespace WeatherApp.Client.Services
{
	public class BookshelfService : IBookshelfService
    {
        private string base_url;
        private AppSettings _settings;

        public BookshelfService(IConfiguration config)
        {
            Console.WriteLine("Loading bookshelf service service...");
            _settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();
            base_url = _settings.bookshlef.base_url;
            Console.WriteLine("Settings:" + _settings);
        }

        public async Task<Author> GetAuthor(long id)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.getauthor_endpoint, id);
            Console.WriteLine("Calling for author: " + uri);

            return await GetResponseForEndpoint<Author>(uri);
        }

        public async Task<Author[]> GetAuthors()
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.geauthors_enpoint);
            Console.WriteLine("Calling for authors: " + uri);

            return await GetResponseForEndpoint<Author[]>(uri);
        }

        public async Task<Book> GetBook(long id)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.getbook_endpoint, id);
            Console.WriteLine("Calling for book: " + uri);

            return await GetResponseForEndpoint<Book>(uri);
        }

        public async Task<Book[]> GetBooks(long authorId)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.getbooks_enpoint, authorId);
            Console.WriteLine("Calling for books: " + uri);

            return await GetResponseForEndpoint<Book[]>(uri);
        }

        public async Task<string> PutAuthor(Author author)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.putAuthor_endpoint);
            Console.WriteLine("Calling to put author: " + uri);
            using (var client = new HttpClient())
            {
                var stringContent = JsonSerializer.Serialize(author);
                var content = new StringContent(stringContent, Encoding.UTF8, "application/json");
                Console.WriteLine("Got payload: " + stringContent);
                using (var response = await client.PostAsync(uri, content))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<BookshelfAPIResponse<string>>(json);
                    return result.data;
                }
            }
                    
        }

        public async Task<string> PutBook(Book book)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.putbook_endpoint);
            Console.WriteLine("Calling to put book: " + uri);
            using (var client = new HttpClient())
            {
                var stringContent = JsonSerializer.Serialize(book);
                var content = new StringContent(stringContent, Encoding.UTF8, "application/json");
                Console.WriteLine("Got payload: " + stringContent);
                using (var response = await client.PostAsync(uri, content))
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<BookshelfAPIResponse<string>>(json);
                    return result.data;
                }
            }
        }

        public async Task<T> GetResponseForEndpoint<T>(string uri)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    Console.WriteLine("status code is: " + response.StatusCode);
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Got json: " + json);
                    var result = JsonSerializer.Deserialize<BookshelfAPIResponse<T>>(json);
                    Console.WriteLine("Message: " + result.message);
                    Console.WriteLine("Data: " + result.data);
                    return result.data;
                }
            }
        }
    }
}

