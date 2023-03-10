using System;
using System.Collections.Generic;

namespace diplomnayarrrr.Entities;

public partial class Cabinet
{
    public int Id { get; set; }

    public int Number { get; set; }

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();
}
