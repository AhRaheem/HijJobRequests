using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class HrEmpCourse
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FCompanyId { get; set; }

    public decimal FEmpNo { get; set; }

    public decimal FSerNo { get; set; }

    public decimal FCourseNo { get; set; }

    public string FCourseName { get; set; } = null!;

    public decimal FCourseType { get; set; }

    public string? FCourseLocation { get; set; }

    public decimal FCourseSeason { get; set; }

    public string? FCourseDateFrom { get; set; }

    public string? FCourseDateTo { get; set; }

    public decimal FCourseStatus { get; set; }
}
