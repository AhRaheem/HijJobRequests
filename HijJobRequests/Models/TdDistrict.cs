using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdDistrict
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FDistrictNo { get; set; }

    public string FDistrictName { get; set; } = null!;

    public decimal FCity { get; set; }

    public decimal FDistrictStatus { get; set; }
}
