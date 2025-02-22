using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdLanguage
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FLanguageNo { get; set; }

    public string FLanguageName { get; set; } = null!;

    public decimal FLanguageStatus { get; set; }
}
