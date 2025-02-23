using System;

namespace HijJobRequests.Dtos.AppUser;

public class LoginAppUserDto
{
public decimal FIdNo { get; set; }

    public string FJawNo { get; set; } = null!;

    public string FEmail { get; set; } = null!;
    public string FUserPass { get; set; }
}
