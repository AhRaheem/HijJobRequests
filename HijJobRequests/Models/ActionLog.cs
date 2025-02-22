using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class ActionLog
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string Controller { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string? Parameters { get; set; }

    public string? UserName { get; set; }

    public string? UserId { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime Timestamp { get; set; }

    public string? RequestPath { get; set; }

    public int? StatusCode { get; set; }

    public string? ErrorMessage { get; set; }

    public double ExecutionTime { get; set; }
}
