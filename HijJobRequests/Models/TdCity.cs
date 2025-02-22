using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdCity
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCityNo { get; set; }

    public string FCityName { get; set; } = null!;

    public decimal FCityMinNo { get; set; }

    public decimal FCountryNo { get; set; }

    public decimal FCityStatus { get; set; }
}
