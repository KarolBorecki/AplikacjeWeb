using BookshelfAPI.Models;

namespace BookshelfAPI.Services
{
	public interface IBookshelfService
	{
        ServiceResponse<List<Book>> GetBooks();
        ServiceResponse<List<Book>> GetBooks(long authorId);
        ServiceResponse<Book> GetBook(long id);
        ServiceResponse<Book> GetBook(string name);

        Task<ServiceResponse<string>> PutBook(Book book);

        ServiceResponse<string> DeleteBook(long id);

        ServiceResponse<List<Author>> GetAuthors();
        ServiceResponse<Author> GetAuthor(string bookName);
        ServiceResponse<Author> GetAuthor(long id);

        Task<ServiceResponse<string>> PutAuthor(Author author);
    }
}

