using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class SongArtist
{
    public int SongId { get; set; }

    public int ArtistId { get; set; }

    public string? Role { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual Song Song { get; set; } = null!;
}
