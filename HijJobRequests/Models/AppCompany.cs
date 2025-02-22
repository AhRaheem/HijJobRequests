using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class AppCompany
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public string FCompanyName { get; set; } = null!;

    public decimal FUnifiedNo { get; set; }

    public decimal FIdNo { get; set; }

    public decimal FVatNo { get; set; }

    public string? FEmail { get; set; }

    public string? FJawNo { get; set; }

    public decimal FBankNo { get; set; }

    public string? FBankIban { get; set; }

    public string? FAddress { get; set; }

    public decimal FCityNo { get; set; }

    public decimal? FBuildingNo { get; set; }

    public decimal? FSecondaryNo { get; set; }

    public decimal? FPostalCode { get; set; }
}
