using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class Status
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();
}
