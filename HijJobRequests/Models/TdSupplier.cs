using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdSupplier
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FSupplieNo { get; set; }

    public string FSupplieName { get; set; } = null!;

    public decimal FVatType { get; set; }

    public decimal FVatNo { get; set; }

    public decimal FUnifiedNo { get; set; }

    public decimal FSpecialNo { get; set; }

    public decimal FIdNo { get; set; }

    public string? FIdDateIssue { get; set; }

    public string? FIdDateExpiry { get; set; }

    public string? FAddress { get; set; }

    public decimal FCityNo { get; set; }

    public decimal FDistrictNo { get; set; }

    public string? FStreet { get; set; }

    public decimal? FBuildingNo { get; set; }

    public decimal? FScondaryNo { get; set; }

    public decimal? FPostalCode { get; set; }

    public string? FMapLatitude { get; set; }

    public string? FMapLongitude { get; set; }

    public string? FJawNo { get; set; }

    public string? FTelNo { get; set; }

    public string? FFaxNo { get; set; }

    public string? FEmail { get; set; }

    public decimal FBankNo { get; set; }

    public string? FBankIbanNo { get; set; }

    public decimal FSupplieStatus { get; set; }
}
