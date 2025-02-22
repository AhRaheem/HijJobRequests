using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysOper
{
    public decimal FOperNo { get; set; }

    public string FOperName { get; set; } = null!;

    public DateTime FLastUpdate { get; set; }
}
