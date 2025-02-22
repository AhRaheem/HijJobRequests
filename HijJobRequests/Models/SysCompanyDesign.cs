using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysCompanyDesign
{
    public decimal FCompanyId { get; set; }

    public decimal FDesignId { get; set; }

    public byte[]? FDesign { get; set; }

    public DateTime FLastUpdate { get; set; }
}
