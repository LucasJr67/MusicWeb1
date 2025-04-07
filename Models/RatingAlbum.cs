using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class RatingAlbum
{
    public int UserId { get; set; }

    public int AlbumId { get; set; }

    public int? Score { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Album Album { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
