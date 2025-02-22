using System;

namespace HijJobRequests.Vars;

public static class SharedVars
{
    public static HashSet<(string, string, DateTime)> AppUsersOtps = new();
}
