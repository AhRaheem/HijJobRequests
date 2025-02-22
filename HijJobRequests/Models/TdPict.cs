using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdPict
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FPictNo { get; set; }

    public string FPictName { get; set; } = null!;

    public decimal FPictOptional { get; set; }

    public decimal FPictGroup { get; set; }

    public string FPictTable { get; set; } = null!;

    public decimal FPictType { get; set; }

    public decimal FPictStaus { get; set; }
}
