using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdMailType
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FMealTypeNo { get; set; }

    public string FMealTypeName { get; set; } = null!;

    public decimal FMealPrice { get; set; }

    public decimal FMealTypeStatus { get; set; }
}
