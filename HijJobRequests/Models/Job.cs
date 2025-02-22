using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Job
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string EnglishName { get; set; } = null!;

    public string ArabicName { get; set; } = null!;

    public int Sort { get; set; }

    public bool IsActive { get; set; }

    public string? Tag { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AppUser> Users { get; set; } = new List<AppUser>();
}
