using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Pattern
{
    public int Id { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? ProjectId { get; set; }

    public string? MasterTableName { get; set; }

    public string? MasterTableIdcolumnName { get; set; }

    public string? MasterTableCodeColumnName { get; set; }

    public string? MasterTableCondition { get; set; }

    public string? AutoUrl { get; set; }

    public string? Tag { get; set; }

    public virtual ICollection<PatternStep> PatternSteps { get; set; } = new List<PatternStep>();

    public virtual Project? Project { get; set; }

}
