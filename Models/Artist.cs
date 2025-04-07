using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Artist
{
    public int ArtistId { get; set; }

    public string Name { get; set; } = null!;

    public string? Bio { get; set; }

    public string? ApprovalStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();

    public virtual ICollection<MusicEvent> MusicEvents { get; set; } = new List<MusicEvent>();

    public virtual ICollection<SongArtist> SongArtists { get; set; } = new List<SongArtist>();
}
