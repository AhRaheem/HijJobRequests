using System;

namespace HijJobRequests.Services.AppUser;

public interface ICurrentUserService
{
string GetUserId();
    string GetUserEmail();
    string GetUserCompany();
    string GetUserPhone();
    string GetUserIdentity();
    bool IsAuthenticated();
}
