using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChFromElement
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FRequestNo { get; set; }

    public decimal FFormNo { get; set; }

    public decimal FFormSerNo { get; set; }

    public decimal FMeasurementNo { get; set; }

    public decimal FMeasurementSerNo { get; set; }

    public string FMeasurementName { get; set; } = null!;

    public decimal FMeasurementDegree { get; set; }
}
