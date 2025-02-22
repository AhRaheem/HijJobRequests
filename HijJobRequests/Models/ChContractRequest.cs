using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ChContractRequest
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSeasonNo { get; set; }

    public decimal FRequestNo { get; set; }

    public DateTime FRequestDate { get; set; }

    public decimal FOrganizerNo { get; set; }

    public decimal FPilgrimsAco { get; set; }

    public decimal FCampsAmo { get; set; }

    public decimal FBasicAmo { get; set; }

    public decimal FServicesAmo { get; set; }

    public decimal FHousingAmo { get; set; }

    public decimal FFoodAmo { get; set; }

    public decimal FRequestAmo { get; set; }

    public DateTime FRequestDateEnd { get; set; }
}
