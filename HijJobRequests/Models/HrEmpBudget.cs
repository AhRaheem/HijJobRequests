using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmpBudget
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FBudgetNo { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FManagerNo { get; set; }

    public decimal FSectionNo { get; set; }

    public decimal FDepNo { get; set; }

    public decimal FDepSerNo { get; set; }

    public decimal FJobNo { get; set; }

    public decimal FJobAco { get; set; }

    public decimal FDayAco { get; set; }

    public decimal FSalaryAmo { get; set; }

    public decimal FSalaryDaily { get; set; }

    public decimal FSalaryMonthly { get; set; }

    public decimal FBudgetContract { get; set; }

    public decimal FBudgetPayment { get; set; }

    public decimal FBudgetStatus { get; set; }
}
