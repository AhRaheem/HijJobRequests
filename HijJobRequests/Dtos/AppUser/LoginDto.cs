using System;

namespace HijJobRequests.Dtos.AppUser;

public class LoginDto
{
    public string Identityfier { get; set; }
    public string Password { get; set; }
    public string Company { get; set; }
    public string Database { get; set; }
    public string ApiKey { get; set; }
    public string Otp { get; set; }
}
