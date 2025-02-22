using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysDateMonth
{
    public decimal FMonthNo { get; set; }

    public string FMonthNameA { get; set; } = null!;

    public string FMonthNameE { get; set; } = null!;

    public DateTime FLastUpdate { get; set; }
}
