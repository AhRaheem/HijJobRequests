using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Module
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string EnglishDescription { get; set; } = null!;

    public string ArabicDescription { get; set; } = null!;

    public int? ProjectId { get; set; }

    public int Sort { get; set; }

    public bool IsActive { get; set; }

    public string? Tag { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual Project? Project { get; set; }
}
