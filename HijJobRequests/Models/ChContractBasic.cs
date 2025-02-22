using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChContractBasic
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FContractNo { get; set; }

    public decimal FRequestNo { get; set; }

    public decimal FOrganizerNo { get; set; }

    public decimal FPackageNo { get; set; }

    public decimal FContractAco { get; set; }

    public decimal FContractValue { get; set; }

    public decimal? FContractRate { get; set; }

    public decimal FContractVat { get; set; }

    public decimal FContractAmo { get; set; }

    public decimal FCenterNo { get; set; }

    public decimal FContractStatus { get; set; }
}
