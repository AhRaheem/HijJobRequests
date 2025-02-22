using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdSeasonStatus
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FSeasonOrderStatus { get; set; }

    public string? FSeasonOrderDateFrom { get; set; }

    public string? FSeasonOrderDateTo { get; set; }

    public decimal FSeasonStatus { get; set; }
}
