using WeatherApp.Client.Models.Bookshelf;

namespace WeatherApp.Client.Services
{
    public interface IBookshelfService
    {
        Task<Book[]> GetBooks(long authorId);
        Task<Author[]> GetAuthors();

        Task<Book> GetBook(long id);
        Task<Author> GetAuthor(long id);

        Task<string> PutBook(Book book);
        Task<string> PutAuthor(Author author);

        Task<string> DeleteBook(long id);
    }
}
