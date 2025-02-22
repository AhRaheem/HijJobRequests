using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdBank
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FBankNo { get; set; }

    public string FBankName { get; set; } = null!;

    public string FBankCode { get; set; } = null!;

    public decimal FCountryNo { get; set; }

    public decimal FBankStatus { get; set; }
}
