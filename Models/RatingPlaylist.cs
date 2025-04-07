using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class RatingPlaylist
{
    public int UserId { get; set; }

    public int PlaylistId { get; set; }

    public int? Score { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Playlist Playlist { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
