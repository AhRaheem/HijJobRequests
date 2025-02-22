using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysDateWeek
{
    public decimal FWeekNo { get; set; }

    public string FWeekNameA { get; set; } = null!;

    public string FWeekNameE { get; set; } = null!;

    public DateTime FLastUpdate { get; set; }
}
