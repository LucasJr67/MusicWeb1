using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public decimal Amount { get; set; }

    public int? UserId { get; set; }

    public int? PaymentMethodId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual ICollection<TransactionStatus> TransactionStatuses { get; set; } = new List<TransactionStatus>();

    public virtual User? User { get; set; }
}
