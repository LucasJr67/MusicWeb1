using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<ReportTargetType> ReportTargetTypes { get; set; } = new List<ReportTargetType>();

    public virtual User User { get; set; } = null!;
}
