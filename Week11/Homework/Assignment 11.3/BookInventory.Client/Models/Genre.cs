using System;
using System.Collections.Generic;
using System.Text;

namespace BookInventory.Client.Models;

public class Genre
{
    public int GenreId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
