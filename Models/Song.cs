using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Song
{
    public int SongId { get; set; }

    public string Title { get; set; } = null!;
    public string Artist { get; set; }
    public string Album { get; set; }

    public string? Lyrics { get; set; }

    public string? FilePath { get; set; }

    public int? GenreId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Duration { get; set; }

    public string? AudioUrl { get; set; }

    public virtual Genre? Genre { get; set; }

    public virtual ICollection<ListenHistory> ListenHistories { get; set; } = new List<ListenHistory>();

    public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();

    public virtual ICollection<RatingSong> RatingSongs { get; set; } = new List<RatingSong>();

    public virtual ICollection<SongArtist> SongArtists { get; set; } = new List<SongArtist>();

    public virtual ICollection<Status> Statuses { get; set; } = new List<Status>();
}
