using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmpOrderCare
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FOrderNo { get; set; }

    public decimal FSerNo { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FSectionNo { get; set; }

    public decimal FCareType { get; set; }

    public decimal FCareNo { get; set; }

    public string FCareDate { get; set; } = null!;

    public DateTime FCareTime { get; set; }

    public string? FCareNote { get; set; }

    public string? FReturnDate { get; set; }

    public DateTime? FReturnTime { get; set; }

    public string? FReturnNote { get; set; }

    public decimal FCareStatus { get; set; }
}
