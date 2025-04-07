using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Album
{
    public int AlbumId { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly? ReleaseDate { get; set; }

    public string? CoverImage { get; set; }

    public int ArtistId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual ICollection<RatingAlbum> RatingAlbums { get; set; } = new List<RatingAlbum>();
}
