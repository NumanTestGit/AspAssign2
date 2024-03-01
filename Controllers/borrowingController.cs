using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class BorrowingController : ControllerBase
{
    private List<Borrowing> _borrowings;

    public BorrowingController()
    {
        _borrowings = new List<Borrowing>();
    }

    // GET /Borrowings
    [HttpGet]
    public IActionResult GetAllBorrowings()
    {
        return Ok("Lists All Borrowings");
    }

    // POST /Borrowings
    [HttpPost]
    public IActionResult AddBorrowing()
    {
        return Ok("Creates a New Borrowing Record");
    }

    // GET /Borrowings/{borrowingId}
    [HttpGet("{borrowingId}")]
    public IActionResult GetBorrowingById(int borrowingId)
    {
        return Ok($"Retrieves a Specific Borrowing Record by using its ID {borrowingId}");
    }

    // PUT /Borrowings/{borrowingId}
    [HttpPut("{borrowingId}")]
    public IActionResult UpdateBorrowing(int borrowingId)
    {
        return Ok($"Updates a Specific Borrowing Record by using its ID {borrowingId}");
    }

    // DELETE /Borrowings/{borrowingId}
    [HttpDelete("{borrowingId}")]
    public IActionResult DeleteBorrowing(int borrowingId)
    {
        return Ok($"Deletes a Specific Borrowing Record by using its ID {borrowingId}");
    }
}
