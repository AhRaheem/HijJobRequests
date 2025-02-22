using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class TdHouseLicense
{
    public DateTime FLastUpdate { get; set; }

    public decimal FLastUpdateUser { get; set; }

    public decimal FLastUpdateSum { get; set; }

    public decimal FLastUpdateOper { get; set; }

    public decimal FLastUpdateOperNo { get; set; }

    public decimal FHouseNo { get; set; }

    public decimal FHouseType { get; set; }

    public decimal FHouseCity { get; set; }

    public string? FLicenseNo { get; set; }

    public string? FLicenseDateFrom { get; set; }

    public string? FLicenseDateTo { get; set; }

    public decimal FHouseStep { get; set; }

    public string FHouseClass { get; set; } = null!;

    public decimal FHouseAco { get; set; }

    public string? FHouseName { get; set; }

    public string? FHomeAddress { get; set; }

    public decimal FDistrictNo { get; set; }

    public string? FStreet { get; set; }

    public decimal? FBuildingNo { get; set; }

    public decimal? FScondaryNo { get; set; }

    public decimal? FPostalCode { get; set; }

    public string? FMapLatitude { get; set; }

    public string? FMapLongitude { get; set; }

    public decimal? FLoorAco { get; set; }

    public decimal? FRoomAco { get; set; }

    public decimal? FRoomArea { get; set; }

    public decimal? FKitchenAco { get; set; }

    public decimal? FToiletAco { get; set; }

    public decimal? FLelevatorAco { get; set; }

    public string? FElectricityNo { get; set; }

    public decimal? FHaramSpace { get; set; }

    public string? FPerName { get; set; }

    public decimal? FPerNatiNo { get; set; }

    public string? FPerId { get; set; }

    public decimal? FPerIdCity { get; set; }

    public string? FPerJaw { get; set; }

    public string? FPerTel { get; set; }

    public string? FPerEmail { get; set; }

    public string? FAgentName { get; set; }

    public decimal? FAgentNatiNo { get; set; }

    public string? FAgentPerId { get; set; }

    public decimal? FAgentPerIdCity { get; set; }

    public string? FAgentPerJaw { get; set; }

    public string? FAgentPerTel { get; set; }

    public string? FAgentPerEmail { get; set; }

    public decimal FHouseStatus { get; set; }
}
