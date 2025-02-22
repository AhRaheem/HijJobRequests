using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChOrganizersPer
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FOrganizerNo { get; set; }

    public decimal FPerNo { get; set; }

    public decimal FPerType { get; set; }

    public string FPerName { get; set; } = null!;

    public string FPerNameE { get; set; } = null!;

    public decimal? FNatiNo { get; set; }

    public string? FPassNo { get; set; }

    public string? FPassCity { get; set; }

    public string? FPassDateIssue { get; set; }

    public string? FPassDateExpiry { get; set; }

    public string? FBirthDate { get; set; }

    public string? FPerJaw { get; set; }

    public string? FPerEmail { get; set; }
}
