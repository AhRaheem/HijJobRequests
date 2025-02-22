using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmpBudgetSer
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FBudgetSerNo { get; set; }

    public decimal FBudgetNo { get; set; }

    public decimal FSerNo { get; set; }

    public decimal FOrderNo { get; set; }
}
