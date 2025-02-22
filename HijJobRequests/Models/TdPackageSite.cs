using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdPackageSite
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FSiteNo { get; set; }

    public string FSiteName { get; set; } = null!;

    public decimal FSiteStatus { get; set; }
}
