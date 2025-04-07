using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class ListenHistory
{
    public int ListenId { get; set; }

    public int SongId { get; set; }

    public int UserId { get; set; }

    public DateTime? ListenDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Device { get; set; }

    public int? PlayedDuration { get; set; }

    public string? DeviceType { get; set; }

    public string? Ip { get; set; }

    public virtual Song Song { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
