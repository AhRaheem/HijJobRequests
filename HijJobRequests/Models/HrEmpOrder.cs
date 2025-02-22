using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmpOrder
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FOrderNo { get; set; }

    public decimal FSeasonNo { get; set; }

    public string FOrderDate { get; set; } = null!;

    public decimal FEmpNo { get; set; }

    public decimal FBudgetSerNo { get; set; }

    public string? FNominationDate { get; set; }

    public string? FContractDateFrom { get; set; }

    public string? FContractDateTo { get; set; }

    public decimal FJobOfferOk { get; set; }

    public decimal FContractOk { get; set; }

    public decimal FCardOk { get; set; }

    public decimal? FAbsenceAco { get; set; }

    public decimal? FPenaltyAco { get; set; }

    public decimal? FNominationActive { get; set; }

    public string? FNominationNote { get; set; }

    public decimal FReceiptTypeNo { get; set; }

    public decimal FOrderStatus { get; set; }
}
