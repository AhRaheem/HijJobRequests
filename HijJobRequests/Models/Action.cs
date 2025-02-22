using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Action
{
    public decimal Id { get; set; }

    public string? Code { get; set; }

    public string EnglishDescription { get; set; } = null!;

    public string? ArabicDescription { get; set; }

    public string? Url { get; set; }

    public int? ModuleId { get; set; }

    public decimal? ParentId { get; set; }

    public bool IsActive { get; set; }

    public bool? IsMenu { get; set; }

    public int? Sort { get; set; }

    public string? Tag { get; set; }

    public string? Fx { get; set; }

    public virtual ICollection<Action> InverseParent { get; set; } = new List<Action>();

    public virtual Module? Module { get; set; }

    public virtual Action? Parent { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
