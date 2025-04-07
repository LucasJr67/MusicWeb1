using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicWeb1.Models;

public partial class ReportTargetType
{
    [Key]
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

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Description { get; set; }

    public virtual Feedback? Feedback { get; set; }

    public virtual User? Moderator { get; set; }

    public virtual TargetType TargetType { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    // Định nghĩa bảng trung gian cho quan hệ many-to-many
    [NotMapped]
    public virtual ICollection<User> Moderators { get; set; } = new List<User>();

    [NotMapped]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
