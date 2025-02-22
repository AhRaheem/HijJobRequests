using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChContractFood
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FContractNo { get; set; }

    public string FContractDate { get; set; } = null!;

    public decimal FContractLocation { get; set; }

    public string FContractDateFrom { get; set; } = null!;

    public string FContractDateTo { get; set; } = null!;

    public decimal FContractAco { get; set; }

    public decimal FContractValue { get; set; }

    public decimal FContractRate { get; set; }

    public decimal FContractVat { get; set; }

    public decimal FContractAmo { get; set; }

    public decimal FDelegateType { get; set; }

    public decimal FDelegateNo { get; set; }

    public decimal FSupplierNo { get; set; }

    public decimal FMealTypeNo { get; set; }

    public decimal FContractStatus { get; set; }
}
