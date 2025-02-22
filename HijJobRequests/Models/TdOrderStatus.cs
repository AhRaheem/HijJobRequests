using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdOrderStatus
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FOrderStatusNo { get; set; }

    public string FOrderStatusName { get; set; } = null!;

    public decimal FOrderStatusStatus { get; set; }
}
