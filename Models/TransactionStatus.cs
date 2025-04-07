using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class TransactionStatus
{
    public int TransactionStatusId { get; set; }

    public int TransactionId { get; set; }

    public string Status { get; set; } = null!;

    public virtual Transaction Transaction { get; set; } = null!;
}
