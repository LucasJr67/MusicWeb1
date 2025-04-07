using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class MusicEvent
{
    public int MusicEventId { get; set; }

    public int ArtistId { get; set; }

    public int EventId { get; set; }

    public string? Title { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Location { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;
}
