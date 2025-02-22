using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class PatternStepAction
{
    public int Id { get; set; }

    public int PatternStepId { get; set; }

    public string EnglishDescription { get; set; } = null!;

    public string ArabicDescription { get; set; } = null!;

    public string? ButtonClass { get; set; }

    public int TargetStepId { get; set; }

    public string? RoleEnglishDescription { get; set; }

    public string? RoleArabicDescription { get; set; }

    public string? RequiredFx { get; set; }

    public bool? IsAutoRejection { get; set; }

    public bool? IsMandatoryFeedback { get; set; }

    public virtual PatternStep PatternStep { get; set; } = null!;

}
