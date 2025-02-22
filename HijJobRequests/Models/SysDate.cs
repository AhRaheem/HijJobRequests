using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysDate
{
    public string FDateM { get; set; } = null!;

    public string FDateH { get; set; } = null!;

    public decimal FWeekNo { get; set; }

    public decimal FYearMonthH { get; set; }

    public decimal FYearH { get; set; }

    public decimal FMonthH { get; set; }

    public decimal FDayH { get; set; }

    public decimal FYearMonthM { get; set; }

    public decimal FYearM { get; set; }

    public decimal FMonthM { get; set; }

    public decimal FDayM { get; set; }

    public DateTime FLastUpdate { get; set; }
}
