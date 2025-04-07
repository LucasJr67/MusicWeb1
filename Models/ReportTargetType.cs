using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class ReportTargetType
{
    public int ReportTargetTypeId { get; set; }

    public int TargetTypeId { get; set; }

    public int UserId { get; set; }

    public string? Content { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public int? ModeratorId { get; set; }

    public int? FeedbackId { get; set; }

    public virtual Feedback? Feedback { get; set; }

    public virtual User? Moderator { get; set; }

    public virtual TargetType TargetType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
