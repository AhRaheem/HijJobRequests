using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class PatternStep
{
    public int Id { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int PatternId { get; set; }

    public bool IsFirstStep { get; set; }

    public bool IsPreview { get; set; }

    public bool IncludeAttachements { get; set; }

    public bool IncludeComment { get; set; }

    public bool AllowEdit { get; set; }

    public int? DataSensitivityLevel { get; set; }

    public int? Sort { get; set; }

    public bool? IsMainStep { get; set; }

    public int RoleId { get; set; }

    public virtual Pattern Pattern { get; set; } = null!;

    public virtual ICollection<PatternStepAction> PatternStepActions { get; set; } = new List<PatternStepAction>();

    public virtual Role Role { get; set; } = null!;
}
