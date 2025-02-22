using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public string? Tag { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public string? ProjectId { get; set; }

    public virtual ICollection<PatternStep> PatternSteps { get; set; } = new List<PatternStep>();

    public virtual ICollection<RoleClaim> RoleClaims { get; set; } = new List<RoleClaim>();

    public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();

}
