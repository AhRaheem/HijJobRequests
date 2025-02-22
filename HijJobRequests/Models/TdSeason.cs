using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdSeason
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FSeasonNo { get; set; }

    public string FSeasonName { get; set; } = null!;

    public string FSeasonDateFromH { get; set; } = null!;

    public string FSeasonDateToH { get; set; } = null!;

    public string FSeasonDateFromM { get; set; } = null!;

    public string FSeasonDateToM { get; set; } = null!;

    public string? FHajDateFromH { get; set; }

    public string? FHajDateToH { get; set; }

    public string? FHajDateFromM { get; set; }

    public string? FHajDateToM { get; set; }

    public decimal FSeasonOrderStatus { get; set; }

    public string? FSeasonOrderDateFrom { get; set; }

    public string? FSeasonOrderDateTo { get; set; }

    public decimal FSeasonStatus { get; set; }
}
