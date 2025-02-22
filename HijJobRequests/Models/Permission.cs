using System;
using System.Collections.Generic;

namespace HijJobRequests.Models;

public partial class Permission
{
    public int Id { get; set; }

    public string EnglishDescription { get; set; } = null!;

    public string? ArabicDescription { get; set; }

    public decimal? ActionId { get; set; }

    public int ActionTypeId { get; set; }

    public virtual Action? Action { get; set; }

    public virtual ActionType ActionType { get; set; } = null!;


}
