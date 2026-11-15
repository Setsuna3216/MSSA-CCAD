using System;
using System.Collections.Generic;
using System.Text;

namespace BookInventory.Client.Models;

public class Book
{
    public int BookId { get; set; }
    public string? Isbn { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Author { get; set; }
    public DateOnly? PublicationDate { get; set; }
    public decimal? Price { get; set; }
    public int Quantity { get; set; }
    public int GenreId { get; set; }
}
