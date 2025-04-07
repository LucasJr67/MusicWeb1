using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
