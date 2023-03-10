using System;
using System.Collections.Generic;

namespace diplomnayarrrr.Entities;

public partial class Lesson
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int TeacherId { get; set; }

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    public virtual Teacher Teacher { get; set; } = null!;
}
