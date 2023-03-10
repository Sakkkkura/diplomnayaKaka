using System;
using System.Collections.Generic;

namespace diplomnayarrrr.Entities;

public partial class Schedule
{
    public int Id { get; set; }

    public int LessonId { get; set; }

    public int GroupId { get; set; }

    public int CabinetId { get; set; }

    public int CallScheduleId { get; set; }

    public int ClassTypeId { get; set; }

    public DateTime Date { get; set; }

    public virtual Cabinet Cabinet { get; set; } = null!;

    public virtual CallSchedule CallSchedule { get; set; } = null!;

    public virtual ClassType ClassType { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;

    public virtual Lesson Lesson { get; set; } = null!;
}
