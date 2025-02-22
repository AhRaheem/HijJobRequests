using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdQuali
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FQualiNo { get; set; }

    public string FQualiName { get; set; } = null!;

    public decimal FQualiStatus { get; set; }
}
