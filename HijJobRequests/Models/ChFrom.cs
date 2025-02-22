using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChFrom
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FRequestNo { get; set; }

    public string FRequestDate { get; set; } = null!;

    public DateTime FRequestTime { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FFormNo { get; set; }

    public decimal FHouseNo { get; set; }

    public decimal FContractAco { get; set; }

    public decimal FRequestStstus { get; set; }
}
