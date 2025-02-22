using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdCountry
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCountryNo { get; set; }

    public string FCountryName { get; set; } = null!;

    public string FNatiName { get; set; } = null!;

    public decimal FCountryMinNo { get; set; }

    public decimal FCountryStatus { get; set; }
}
