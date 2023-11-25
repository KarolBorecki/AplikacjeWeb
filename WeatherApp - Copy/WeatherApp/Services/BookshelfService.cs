using Microsoft.Extensions.Configuration;
using System.Text.Json;
using WeatherApp.Client.Models.Bookshelf;
using System.Text;
using System.Net;
using System.Net.Http.Json;
using System.Net.Http;

namespace WeatherApp.Client.Services
{
	public class BookshelfService : IBookshelfService
    {
        private string base_url;
        private AppSettings _settings;

        private HttpClient _httpClient;
        private HttpResponseMessage _response;

        public BookshelfService(HttpClient hClient, IConfiguration config)
        {
            System.Diagnostics.Debug.WriteLine("Loading bookshelf service service...");
            _settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();
            base_url = _settings.bookshlef.base_url;
            System.Diagnostics.Debug.WriteLine("Settings:" + _settings);
            _httpClient = hClient;
        }

        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };
            return handler;
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
            await PostRequestForEndpoint(uri, author);
            return "DATA";


        }

        public async Task<string> PutBook(Book book)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.putbook_endpoint);
            System.Diagnostics.Debug.WriteLine("Calling to put book: " + uri);
            await PostRequestForEndpoint(uri, book);
            return "DATA";

        }


        public async Task<string> DeleteBook(long bookId)
        {
            string uri = base_url + "/" + string.Format(_settings.bookshlef.delete_book_endpoint, bookId);
            System.Diagnostics.Debug.WriteLine("Calling to DELETE book: " + uri);

            var response = await _httpClient.DeleteAsync(uri);
            return response.Content.ToString();
                
            
        }

        public async Task<string> PostRequestForEndpoint<T>(string uri, T data)
        {

            var serialized = JsonSerializer.Serialize(data);
            var stringedData = new StringContent(serialized, Encoding.UTF8, "application/json");
            System.Diagnostics.Debug.WriteLine("SENDINGSENDINGSENDINGSENDINGSENDINGSENDINGSENDINGSENDINGSENDINGSENDING");
            try
            {
                _response = await _httpClient.PostAsync(uri, stringedData);
            } catch (System.ObjectDisposedException e)
            {
                System.Diagnostics.Debug.WriteLine("DISPOSED: " + e.ToString());
            }
            System.Diagnostics.Debug.WriteLine("AFTERAFTERAFTERAFTERAFTERAFTERAFTERAFTER");

            return "Data";
        }

        public async Task<T> GetResponseForEndpoint<T>(string uri)
        {

            var response = await _httpClient.GetAsync(uri);
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

