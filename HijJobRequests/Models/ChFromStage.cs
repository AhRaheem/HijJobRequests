using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChFromStage
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FRequestNo { get; set; }

    public decimal FSerNo { get; set; }

    public DateTime FTaskTime { get; set; }

    public decimal FTaskEmpInspector { get; set; }

    public decimal FTaskEmpSupervisior { get; set; }

    public string? FTaskNote { get; set; }

    public DateTime? FCloseTime { get; set; }

    public string? FCloseNote { get; set; }

    public decimal? FCloseEmpSupervisior { get; set; }

    public string? FCloseSupervisiorNote { get; set; }

    public DateTime? FDeadlineTime { get; set; }
}
