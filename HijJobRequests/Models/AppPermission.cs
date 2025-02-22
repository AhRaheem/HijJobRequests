using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class AppPermission
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FPermNo { get; set; }

    public string FPermName { get; set; } = null!;

    public decimal FPermStatus { get; set; }
}
