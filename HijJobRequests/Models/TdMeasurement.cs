using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdMeasurement
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FMeasurementNo { get; set; }

    public string FMeasurementName { get; set; } = null!;

    public decimal FMeasurementAco { get; set; }

    public string FMeasurementName1 { get; set; } = null!;

    public decimal FMeasurementDegree1 { get; set; }

    public string FMeasurementName2 { get; set; } = null!;

    public decimal FMeasurementDegree2 { get; set; }

    public string FMeasurementName3 { get; set; } = null!;

    public decimal FMeasurementDegree3 { get; set; }

    public string FMeasurementName4 { get; set; } = null!;

    public decimal FMeasurementDegree4 { get; set; }

    public string FMeasurementName5 { get; set; } = null!;

    public decimal FMeasurementDegree5 { get; set; }

    public decimal FMeasurementStatus { get; set; }
}
