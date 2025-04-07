using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class NotificationType
{
    public int NotificationTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public int? NotificationId { get; set; }

    public virtual Notification? Notification { get; set; }
}
