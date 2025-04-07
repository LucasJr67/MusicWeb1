using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? NotificationId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<MusicEvent> MusicEvents { get; set; } = new List<MusicEvent>();

    public virtual Notification? Notification { get; set; }
}
