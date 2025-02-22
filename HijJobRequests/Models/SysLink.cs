using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class SysLink
{
    public decimal FLinkNo { get; set; }

    public string FLinkName { get; set; } = null!;

    public string FLinkPage { get; set; } = null!;

    public decimal FLinkGroup { get; set; }

    public decimal FShow { get; set; }

    public decimal FInsert { get; set; }

    public decimal FUpdate { get; set; }

    public decimal FDeleted { get; set; }

    public decimal FPrint { get; set; }

    public decimal FExport { get; set; }

    public decimal FRole01 { get; set; }

    public decimal FRole02 { get; set; }

    public decimal FRole03 { get; set; }

    public decimal FRole04 { get; set; }

    public decimal FRole05 { get; set; }

    public decimal FRole06 { get; set; }

    public decimal FRole07 { get; set; }

    public decimal FRole08 { get; set; }

    public decimal FRole09 { get; set; }

    public string? FRoleName01 { get; set; }

    public string? FRoleName02 { get; set; }

    public string? FRoleName03 { get; set; }

    public string? FRoleName04 { get; set; }

    public string? FRoleName05 { get; set; }

    public string? FRoleName06 { get; set; }

    public string? FRoleName07 { get; set; }

    public string? FRoleName08 { get; set; }

    public string? FRoleName09 { get; set; }

    public decimal? FLinkStatus { get; set; }

    public DateTime? FLastUpdate { get; set; }
}
