using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Playlist
{
    public int PlaylistId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Description { get; set; }

    public string? Visibility { get; set; }

    public bool? SystemGenerated { get; set; }

    public string? CoverImage { get; set; }

    public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();

    public virtual ICollection<RatingPlaylist> RatingPlaylists { get; set; } = new List<RatingPlaylist>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
