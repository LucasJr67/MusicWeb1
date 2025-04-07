using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public string? Content { get; set; }

    public int UserId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsRead { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<NotificationType> NotificationTypes { get; set; } = new List<NotificationType>();

    public virtual User User { get; set; } = null!;
}
