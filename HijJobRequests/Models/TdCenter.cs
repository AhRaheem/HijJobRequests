using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdCenter
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FCenterNo { get; set; }

    public string FCenterName { get; set; } = null!;

    public string? FCenterType { get; set; }

    public string? FCenterEmail { get; set; }

    public string? FCenterJaw { get; set; }

    public decimal FSectionNo { get; set; }

    public string? FLatitudeMak { get; set; }

    public string? FLongitudeMak { get; set; }

    public string? FLatitudeArafat { get; set; }

    public string? FLongitudeArafat { get; set; }

    public string? FLatitudeMona { get; set; }

    public string? FLongitudeMona { get; set; }

    public decimal FCenterStatus { get; set; }
}
