using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private List<Book> _books;

    public BookController()
    {
        _books = new List<Book>();
    }

    // GET /Books
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        return Ok("Lists All The Books In The System");
    }

    // POST /Books
    [HttpPost]
    public IActionResult AddBook()
    {
        return Ok("Adds A New Book");
    }

    // GET /Books/{bookId}
    [HttpGet("{bookId}")]
    public IActionResult GetBookById(int bookId)
    {
        return Ok($"Returns Details For Book With ID {bookId}");
    }

    // PUT /Books/{bookId}
    [HttpPut("{bookId}")]
    public IActionResult UpdateBook(int bookId)
    {
        return Ok($"Updates Details For Book With ID {bookId}");
    }

    // DELETE /Books/{bookId}
    [HttpDelete("{bookId}")]
    public IActionResult DeleteBook(int bookId)
    {
        return Ok($"Deletes Book With ID {bookId}");
    }
}
