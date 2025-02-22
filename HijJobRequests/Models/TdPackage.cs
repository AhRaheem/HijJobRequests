using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdPackage
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FPackageNo { get; set; }

    public string FPackageName { get; set; } = null!;

    public decimal FPackageStatus { get; set; }
}
