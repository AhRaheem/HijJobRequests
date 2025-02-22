using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdMajor
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FMajorNo { get; set; }

    public string FMajorName { get; set; } = null!;

    public decimal FMajorStatus { get; set; }
}
