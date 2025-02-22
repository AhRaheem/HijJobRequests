using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmpExperience
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FEmpNo { get; set; }

    public decimal FSerNo { get; set; }

    public decimal FSeasonNo { get; set; }

    public string FJobSide { get; set; } = null!;

    public string FJobName { get; set; } = null!;

    public decimal FExperienceStatus { get; set; }
}
