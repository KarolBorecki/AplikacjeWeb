using System;
using BookshelfAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookshelfAPI.Services 
{
	public class BookshelfService : IBookshelfService
    {
        private readonly DataContext _dataContext;

        public BookshelfService(DataContext context)
        {
            _dataContext = context;
        }

        public ServiceResponse<List<Book>> GetBooks()
        {
            var books = _dataContext.books.ToArray();
            try
            {
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = books.ToList(),
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<List<Book>>()
                {
                    Data = null,
                    Message = "Could not return data",
                    Success = false
                };
            }
        }

        public ServiceResponse<List<Book>> GetBooks(long authorId)
        {
            try
            {
                var books = _dataContext.books;
                if (!books.Any(book => book.authorId == authorId))
                    throw new Exception("Could not find any books with given author ID!");
                var gotBooks = books.Where(book => book.authorId == authorId).ToList();
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = gotBooks,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e) 
            {
                return new ServiceResponse<List<Book>>()
                {
                    Data = null,
                    Message = e.ToString(),
                    Success = false
                };
            }
        }

        public ServiceResponse<Book> GetBook(long id)
        {
            try
            {
                var books = _dataContext.books;
                if (!books.Any(book => book.id == id))
                    throw new Exception("Could not find any book with given ID!");
                var book = books.Where(book => book.id == id).First();
                var response = new ServiceResponse<Book>()
                {
                    Data = book,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = e.ToString(),
                    Success = false
                };
            }
        }

        public ServiceResponse<Book> GetBook(string name)
        {
            try
            {
                var books = _dataContext.books;
                if (books.Any(book => book.name == name))
                    throw new Exception("Could not find any book with given name!");
                var book = books.Where(book => book.name == name).First();
                var response = new ServiceResponse<Book>()
                {
                    Data = book,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = e.ToString(),
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<string>> PutBook(Book book)
        {
            try
            {
                var addedBook = new Book { authorId =  book.authorId, name = book.name, publishDate = book.publishDate };
                _dataContext.books.Add(addedBook);
                await _dataContext.SaveChangesAsync();

                var response = new ServiceResponse<string>()
                {
                    Data = "Book added",
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<string>()
                {
                    Data = "",
                    Message = e.ToString(),
                    Success = false
                };
            }
        }

        public ServiceResponse<string> DeleteBook(long bookId)
        {
            try
            {
                var book = new Book() { id = bookId };
                _dataContext.books.Attach(book);
                _dataContext.books.Remove(book);

                var response = new ServiceResponse<string>()
                {
                    Data = "Book deleted",
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<string>()
                {
                    Data = e.ToString(),
                    Message = "Could not delete any data",
                    Success = false
                };
            }
        }

        public ServiceResponse<List<Author>> GetAuthors()
        {
            try
            {
                var authors = _dataContext.authors;
                var response = new ServiceResponse<List<Author>>()
                {
                    Data = authors.ToList(),
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<List<Author>>()
                {
                    Data = null,
                    Message = "Could not find any data",
                    Success = false
                };
            }
        }

        public ServiceResponse<Author> GetAuthor(string bookName)
        {
            try
            {
                var books = _dataContext.books;
                if (!books.Any(b => b.name == bookName))
                    throw new Exception("Could not find book with given name!");
                var book = books.Where(b => b.name == bookName).First();

                var authors = _dataContext.authors;
                if (!authors.Any(a => a.id == book.authorId))
                    throw new Exception("Could not find the book's author!");
                var author = authors.Where(a => a.id == book.authorId).First();
                var response = new ServiceResponse<Author>()
                {
                    Data = author,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<Author>()
                {
                    Data = null,
                    Message = e.ToString(),
                    Success = false
                };
            }
        }

        public ServiceResponse<Author> GetAuthor(long id)
        {
            try
            {
                var authors = _dataContext.authors;
                if (!authors.Any(a => a.id == id))
                    throw new Exception("Could not find author with given ID!");
                var author = authors.Where(a => a.id == id).First();
                var response = new ServiceResponse<Author>()
                {
                    Data = author,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<Author>()
                {
                    Data = null,
                    Message = e.ToString(),
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<string>> PutAuthor(Author author)
        {
            try
            {
                var addedAuthor = new Author { name = author.name };
                _dataContext.authors.Add(addedAuthor);
                await _dataContext.SaveChangesAsync();
                var response = new ServiceResponse<string>()
                {
                    Data = "Author added",
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception e)
            {
                return new ServiceResponse<string>()
                {
                    Data = "",
                    Message = e.ToString(),
                    Success = false
                };
            }
        }
    }
}

