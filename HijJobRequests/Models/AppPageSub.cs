using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class AppPageSub
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FPageSubNo { get; set; }

    public string FPageSubName { get; set; } = null!;

    public decimal FPageSubSort { get; set; }

    public decimal FPageMainNo { get; set; }

    public decimal FPageSubStatus { get; set; }
}
