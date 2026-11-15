using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookInventory.Api.Models;
using BookInventory.Api.Data;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly BookInventoryContext _context;
    public BooksController(BookInventoryContext context)
    {
        _context = context;
    }

    // GET: api/Book
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBook()
    {
        return await _context.Books.ToListAsync();
    }

    // GET: api/Book/5
    [HttpGet("{bookid}")]
    public async Task<ActionResult<Book>> GetBook(int bookid)
    {
        var book = await _context.Books.FindAsync(bookid);

        if (book == null)
        {
            return NotFound();
        }

        return book;
    }

    // PUT: api/Book/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{bookid}")]
    public async Task<IActionResult> PutBook(int? bookid, Book book)
    {
        if (bookid != book.BookId)
        {
            return BadRequest();
        }

        _context.Entry(book).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BookExists(bookid))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Book
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Book>> PostBook(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetBook", new { bookid = book.BookId }, book);
    }

    // DELETE: api/Book/5
    [HttpDelete("{bookid}")]
    public async Task<IActionResult> DeleteBook(int? bookid)
    {
        var book = await _context.Books.FindAsync(bookid);
        if (book == null)
        {
            return NotFound();
        }

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool BookExists(int? bookid)
    {
        return _context.Books.Any(e => e.BookId == bookid);
    }
}
