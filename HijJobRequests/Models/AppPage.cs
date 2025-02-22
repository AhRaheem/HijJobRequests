using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class AppPage
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FPageNo { get; set; }

    public string FPageName { get; set; } = null!;

    public decimal FPageSort { get; set; }

    public decimal FPageSubNo { get; set; }

    public decimal FLinkNo { get; set; }

    public decimal FPageStatus { get; set; }
}
