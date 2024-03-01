using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class ReaderController : ControllerBase
{
    private List<Reader> _readers;

    public ReaderController()
    {
        _readers = new List<Reader>();
    }

    // GET /Readers
    [HttpGet]
    public IActionResult GetAllReaders()
    {
        return Ok("Lists All Readers");
    }

    // POST /Readers
    [HttpPost]
    public IActionResult AddReader()
    {
        return Ok("Adds a New Reader");
    }

    // GET /Readers/{readerId}
    [HttpGet("{readerId}")]
    public IActionResult GetReaderById(int readerId)
    {
        return Ok($"Retrieves a Specific Reader's Details by using its ID {readerId}");
    }

    // PUT /Readers/{readerId}
    [HttpPut("{readerId}")]
    public IActionResult UpdateReader(int readerId)
    {
        return Ok($"Updates a Specific Reader's Details by using its ID {readerId}");
    }

    // DELETE /Readers/{readerId}
    [HttpDelete("{readerId}")]
    public IActionResult DeleteReader(int readerId)
    {
        return Ok($"Deletes a Specific Reader by using its ID {readerId}");
    }
}
