using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysPict
{
    public decimal FSerNo { get; set; }

    public decimal FPictNo { get; set; }

    public decimal FReferenceNo { get; set; }

    public byte[]? FPict { get; set; }

    public DateTime FLastUpdate { get; set; }
}
