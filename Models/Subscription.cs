using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Subscription
{
    public int SubscriptionId { get; set; }

    public string? PlanType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsAutoRenew { get; set; }

    public virtual User User { get; set; } = null!;
}
