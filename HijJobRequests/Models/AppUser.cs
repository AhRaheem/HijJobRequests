using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class AppUser
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FUserId { get; set; }

    public decimal FUserType { get; set; }

    public string FUserCode { get; set; } = null!;

    public string FUserPass { get; set; } = null!;

    public string FUserName { get; set; } = null!;

    public decimal FIdNo { get; set; }

    public string FJawNo { get; set; } = null!;

    public string FEmail { get; set; } = null!;

    public decimal FVerificatOption { get; set; }

    public decimal FSectionNo { get; set; }

    public decimal FUserStatus { get; set; }
}
