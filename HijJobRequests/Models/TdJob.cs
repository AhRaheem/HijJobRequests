using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdJob
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal? FCompanyId { get; set; }

    public decimal FJobNo { get; set; }

    public string FJobName { get; set; } = null!;

    public decimal FJobType { get; set; }

    public decimal FJobLevel { get; set; }

    public decimal FJobStatus { get; set; }
}
