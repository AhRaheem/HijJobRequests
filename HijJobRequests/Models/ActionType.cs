using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ActionType
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
