using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookInventory.Api.Models;
using BookInventory.Api.Data;

[Route("api/[controller]")]
[ApiController]
public class GenresController : ControllerBase
{
    private readonly BookInventoryContext _context;
    public GenresController(BookInventoryContext context)
    {
        _context = context;
    }

    // GET: api/Genre
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Genre>>> GetGenre()
    {
        return await _context.Genres.ToListAsync();
    }

    // GET: api/Genre/5
    [HttpGet("{genreid}")]
    public async Task<ActionResult<Genre>> GetGenre(int genreid)
    {
        var genre = await _context.Genres.FindAsync(genreid);

        if (genre == null)
        {
            return NotFound();
        }

        return genre;
    }

    // PUT: api/Genre/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{genreid}")]
    public async Task<IActionResult> PutGenre(int? genreid, Genre genre)
    {
        if (genreid != genre.GenreId)
        {
            return BadRequest();
        }

        _context.Entry(genre).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!GenreExists(genreid))
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

    // POST: api/Genre
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Genre>> PostGenre(Genre genre)
    {
        _context.Genres.Add(genre);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetGenre", new { genreid = genre.GenreId }, genre);
    }

    // DELETE: api/Genre/5
    [HttpDelete("{genreid}")]
    public async Task<IActionResult> DeleteGenre(int? genreid)
    {
        var genre = await _context.Genres.FindAsync(genreid);
        if (genre == null)
        {
            return NotFound();
        }

        _context.Genres.Remove(genre);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool GenreExists(int? genreid)
    {
        return _context.Genres.Any(e => e.GenreId == genreid);
    }
}
