using System;
using System.Collections.Generic;

namespace diplomnayarrrr.Entities;

public partial class Group
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();
}
