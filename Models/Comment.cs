using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public string? Content { get; set; }

    public int UserId { get; set; }

    public int FeedbackId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Feedback Feedback { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
