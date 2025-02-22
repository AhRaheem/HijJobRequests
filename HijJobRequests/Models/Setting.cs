using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Setting
{
    public string Id { get; set; } = null!;

    public string? Value { get; set; }
}
