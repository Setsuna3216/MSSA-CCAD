using System;
using System.Collections.Generic;

namespace Assignment_11._1.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Isbn { get; set; }

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public DateOnly? PublicationDate { get; set; }

    public decimal? Price { get; set; }

    public int Quantity { get; set; }

    public int GenreId { get; set; }

    public virtual Genre Genre { get; set; } = null!;
}
