using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();
}
