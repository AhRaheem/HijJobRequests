using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdForm
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FFormNo { get; set; }

    public string FFormName { get; set; } = null!;

    public decimal FFormAco { get; set; }

    public decimal FFormType { get; set; }

    public decimal FFormStatus { get; set; }
}
