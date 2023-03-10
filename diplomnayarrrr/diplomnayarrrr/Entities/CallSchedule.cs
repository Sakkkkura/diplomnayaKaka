using System;
using System.Collections.Generic;

namespace diplomnayarrrr.Entities;

public partial class CallSchedule
{
    public int Id { get; set; }

    public int Time { get; set; }

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();
}
