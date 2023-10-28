using System;
using BookshelfAPI.Models;

namespace BookshelfAPI.Services 
{
	public class BookshelfService : IBookshelfService
    {
        private List<Book> _books;
        private List<Author> _authors;

        public BookshelfService()
        {
            _books = new List<Book>();
            _authors = new List<Author>();
        }

        public ServiceResponse<List<Book>> GetBooks()
        {
            try
            {
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = _books,
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
                if (!_books.Any(book => book.authorId == authorId))
                    throw new Exception("Could not find any books with given author ID!");
                var books = _books.Where(book => book.authorId == authorId).ToList();
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = books,
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
                if (!_books.Any(book => book.id == id))
                    throw new Exception("Could not find any book with given ID!");
                var book = _books.Where(book => book.id == id).First();
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
                if (_books.Any(book => book.name == name))
                    throw new Exception("Could not find any book with given name!");
                var book = _books.Where(book => book.name == name).First();
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

        public ServiceResponse<string> PutBook(Book book)
        {
            try
            {
                if (_books.Any(b => b.id == book.id))
                    throw new Exception("Book with given ID already exists!");

                _books.Add(book);
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

        public ServiceResponse<string> DeleteBook(long id)
        {
            try
            {
                if (!_books.Any(b => b.id == id))
                    throw new Exception("Book with given ID does not exists!");
                var book = _books.Where(b => b.id == id).First();
                _books.Remove(book);
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
                var response = new ServiceResponse<List<Author>>()
                {
                    Data = _authors,
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
                if (!_books.Any(b => b.name == bookName))
                    throw new Exception("Could not find book with given name!");
                var book = _books.Where(b => b.name == bookName).First();

                if (!_authors.Any(a => a.id == book.authorId))
                    throw new Exception("Could not find the book's author!");
                var author = _authors.Where(a => a.id == book.authorId).First();
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
                if (!_authors.Any(a => a.id == id))
                    throw new Exception("Could not find author with given ID!");
                var author = _authors.Where(a => a.id == id).First();
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

        public ServiceResponse<string> PutAuthor(Author author)
        {
            try
            {
                if (_authors.Any(a => a.id == author.id))
                    throw new Exception("Author with given ID already exists!");

                _authors.Add(author);
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

