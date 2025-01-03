using System;
using System.Collections.Generic;

namespace MyWebApp.Models;

public partial class Genre
{
    public int Genreid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
