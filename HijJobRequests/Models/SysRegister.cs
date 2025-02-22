using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysRegister
{
    public decimal FSerNo { get; set; }

    public string FFirstName { get; set; } = null!;

    public string FFatherName { get; set; } = null!;

    public string? FGrandfatherName { get; set; }

    public string FFamilyName { get; set; } = null!;

    public string FApplicantName { get; set; } = null!;

    public decimal FIdNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSectionNo { get; set; }

    public decimal FJobNo { get; set; }

    public string FJawNo { get; set; } = null!;

    public string FEmail { get; set; } = null!;

    public string FBirthDate { get; set; } = null!;

    public string? FIdDateExpiry { get; set; }

    public decimal FStatus { get; set; }

    public DateTime FLastUpdate { get; set; }

    public string? FLastUpdateNote { get; set; }

    public decimal FLastUpdateUser { get; set; }
}
