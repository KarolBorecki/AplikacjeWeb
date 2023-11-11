using Microsoft.Extensions.Configuration;
using System.Text.Json;
using BookshelfAPI.Models;
using BookshelfWWW;
using System.Text;

namespace WeatherApp.Client.Services
{
	public class BookshelfService : IBookshelfService
    {
        private string base_url;
        private AppSettings _settings;

        public BookshelfService(IConfiguration config)
        {
            System.Diagnostics.Debug.WriteLine("Loading bookshelf service service...");
            _settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();
            base_url = _settings.bookshlef.base_url;
            System.Diagnostics.Debug.WriteLine("Settings:" + _settings);
        }

        public async Task<Author> GetAuthor(long id)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.getauthor_endpoint, id);
            System.Diagnostics.Debug.WriteLine("Calling for author: " + uri);

            return await GetResponseForEndpoint<Author>(uri);
        }

        public async Task<Author[]> GetAuthors()
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.geauthors_enpoint);
            System.Diagnostics.Debug.WriteLine("Calling for authors: " + uri);

            return await GetResponseForEndpoint<Author[]>(uri);
        }

        public async Task<Book> GetBook(long id)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.getbook_endpoint, id);
            System.Diagnostics.Debug.WriteLine("Calling for book: " + uri);

            return await GetResponseForEndpoint<Book>(uri);
        }

        public async Task<Book[]> GetBooks(long authorId)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.getbooks_enpoint, authorId);
            System.Diagnostics.Debug.WriteLine("Calling for books: " + uri);

            return await GetResponseForEndpoint<Book[]>(uri);
        }

        public async Task<string> PutAuthor(Author author)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.putAuthor_endpoint);
            System.Diagnostics.Debug.WriteLine("Calling to put author: " + uri);
            using (var client = new HttpClient())
            {
                var stringContent = JsonSerializer.Serialize(author);
                var content = new StringContent(stringContent, Encoding.UTF8, "application/json");
                System.Diagnostics.Debug.WriteLine("Got payload: " + stringContent);
                using (var response = await client.PostAsync(uri, content))
                {

                    return "Data";
                }
            }
                    
        }

        public async Task<string> PutBook(Book book)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.putbook_endpoint);
            System.Diagnostics.Debug.WriteLine("Calling to put book: " + uri);
            using (var client = new HttpClient())
            {
                var stringContent = JsonSerializer.Serialize(book);
                var content = new StringContent(stringContent, Encoding.UTF8, "application/json");
                System.Diagnostics.Debug.WriteLine("Got payload: " + stringContent);
                using (var response = await client.PostAsync(uri, content))
                {
                    return "Data";
                }
            }
        }

        public async Task<T> GetResponseForEndpoint<T>(string uri)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    System.Diagnostics.Debug.WriteLine("status code is: " + response.StatusCode);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        return default(T);

                    string json = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine("Got json: " + json);
                    var result = JsonSerializer.Deserialize<BookshelfAPIResponse<T>>(json);
                    System.Diagnostics.Debug.WriteLine("Message: " + result.message);
                    System.Diagnostics.Debug.WriteLine("Data: " + result.data);
                    return result.data;
                }
            }
        }
    }
}

