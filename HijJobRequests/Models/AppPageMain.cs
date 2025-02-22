using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class AppPageMain
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FPageMainNo { get; set; }

    public string FPageMainName { get; set; } = null!;

    public decimal FPageMainSort { get; set; }

    public decimal FPageMainStatus { get; set; }
}
