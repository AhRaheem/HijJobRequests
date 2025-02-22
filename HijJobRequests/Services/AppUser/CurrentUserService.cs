using System;
using System.Security.Claims;

namespace HijJobRequests.Services.AppUser;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetUserId() => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
    public string? GetUserCompany() => _httpContextAccessor.HttpContext?.User?.FindFirst("Company")?.Value ?? string.Empty;
    public string? GetUserEmail() => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
    public string? GetUserPhone() => _httpContextAccessor.HttpContext?.User?.FindFirst("Phone")?.Value ?? string.Empty;
    public string? GetUserIdentity() => _httpContextAccessor.HttpContext?.User?.FindFirst("Identity")?.Value ?? string.Empty;
    public bool IsAuthenticated() => _httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false;
}
