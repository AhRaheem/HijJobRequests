using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmp
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FEmpNo { get; set; }

    public string FEmpFirst { get; set; } = null!;

    public string? FEmpFather { get; set; }

    public string? FEmpGrandfather { get; set; }

    public string FEmpFamily { get; set; } = null!;

    public string FEmpFirstE { get; set; } = null!;

    public string? FEmpFatherE { get; set; }

    public string? FEmpGrandfatherE { get; set; }

    public string FEmpFamilyE { get; set; } = null!;

    public string FEmpName { get; set; } = null!;

    public string FEmpNameE { get; set; } = null!;

    public decimal FGender { get; set; }

    public string FBirthDate { get; set; } = null!;

    public decimal FAge { get; set; }

    public decimal FNatiNo { get; set; }

    public decimal FIdType { get; set; }

    public decimal FIdNo { get; set; }

    public string? FIdSaveNo { get; set; }

    public string FIdDateExpiry { get; set; } = null!;

    public decimal FBankNo { get; set; }

    public string? FBankIbanNo { get; set; }

    public decimal? FHomeCity { get; set; }

    public string FJawNo { get; set; } = null!;

    public string? FEmail { get; set; }

    public decimal FEmailActivation { get; set; }

    public string? FHomeAddress { get; set; }

    public decimal FQualiNo { get; set; }

    public decimal FMajorNo { get; set; }

    public decimal FEmpStatus { get; set; }
}
