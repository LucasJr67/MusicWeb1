using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class TargetType
{
    public int TargetTypeId { get; set; }

    public string TargetTypeName { get; set; } = null!;

    public virtual ICollection<ReportTargetType> ReportTargetTypes { get; set; } = new List<ReportTargetType>();
}
