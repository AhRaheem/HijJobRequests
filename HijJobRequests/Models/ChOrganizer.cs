using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChOrganizer
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FOrganizerNo { get; set; }

    public decimal FOrganizerSys { get; set; }

    public decimal FOrganizerSysEst { get; set; }

    public string FOrganizerNameA { get; set; } = null!;

    public string FOrganizerNameE { get; set; } = null!;

    public decimal FCountryNo { get; set; }

    public string? FLicenseNo { get; set; }

    public string? FDateIssue { get; set; }

    public string? FDateExpiry { get; set; }

    public string? FOrganizerTel { get; set; }

    public string? FOrganizerFax { get; set; }

    public string? FOrganizerEmail { get; set; }

    public string? FOrganizerWeb { get; set; }

    public decimal FOrganizerStaus { get; set; }
}
