using Microsoft.AspNetCore.Mvc;

using BookshelfAPI.Models;
using BookshelfAPI.Services;
using BookshelfAPI.Validators;

namespace BookshelfAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BokshelfController : ControllerBase
{
    private readonly IBookshelfService _bookshelfService;

    private readonly IValidator<Book> _bookValidator;
    private readonly IValidator<Author> _authorValidator;

    public BokshelfController(IBookshelfService bookshelfService, IValidator<Book> bookValidator, IValidator<Author> authorValidator)
    {
        _bookshelfService = bookshelfService;

        _bookValidator = bookValidator;
        _authorValidator = authorValidator;
    }


    [HttpGet("getbooks")]
    [HttpGet("getbooks/{authorId?}")]
    public ActionResult<ServiceResponse<List<Book>>> GetBooks(long authorId = 0)
    {
        var result = authorId == 0 ? _bookshelfService.GetBooks() : _bookshelfService.GetBooks(authorId);

        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

    [HttpGet("getbook/{bookId:long}")]
    [HttpGet("getbook/{name:alpha}")]
    public ActionResult<ServiceResponse<Book>> GetBook(long bookId = 0, string name = "")
    {
        ServiceResponse<Book> result;
        if (bookId != 0)
            result = _bookshelfService.GetBook(bookId);
        else if (name != "")
            result = _bookshelfService.GetBook(name);
        else return StatusCode(400, $"Wrong data provided");

        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

    [HttpGet("getauthors")]
    public ActionResult<ServiceResponse<List<Author>>> GetAuthors()
    {
        var result = _bookshelfService.GetAuthors();

        if (result.Success)
            return Ok(result);
        else
            return StatusCode(400, $"Bad request: Provided faulty data");
    }

    [HttpGet("getauthor/{authorId:long}")]
    [HttpGet("getauthor/{bookName:alpha}")]
    public ActionResult<ServiceResponse<Author>> GetAuthor(long authorId = 0, string bookName = "")
    {
        ServiceResponse<Author> result;
        if (authorId != 0)
            result = _bookshelfService.GetAuthor(authorId);
        else if (bookName != "")
            result = _bookshelfService.GetAuthor(bookName);
        else return StatusCode(400, $"Wrong data provided");

        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

    [HttpPost("putbook")]
    public ActionResult<ServiceResponse<string>> PutBook([FromBody] Book book)
    {
        if(!_bookValidator.validate(book))
            return StatusCode(400, $"Wrong data provided");

        var result = _bookshelfService.PutBook(book);
        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

    [HttpPost("putAuthor")]
    public ActionResult<ServiceResponse<string>> PutAuthor([FromBody] Author author)
    {
        if (!_authorValidator.validate(author))
            return StatusCode(400, $"Wrong data provided");

        var result = _bookshelfService.PutAuthor(author);
        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

    [HttpDelete("deletebook")]
    public ActionResult<ServiceResponse<string>> DeleteBook(long bookId)
    {
        var result = _bookshelfService.DeleteBook(bookId);
        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

}

