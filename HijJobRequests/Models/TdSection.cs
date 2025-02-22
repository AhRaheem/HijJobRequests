using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdSection
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FSectionNo { get; set; }

    public string FSectionName { get; set; } = null!;

    public decimal FSectionType { get; set; }

    public string FSectionNameShort { get; set; } = null!;

    public string? FSectionEmail { get; set; }

    public string? FSectionJaw { get; set; }

    public decimal FSectionStatus { get; set; }
}
