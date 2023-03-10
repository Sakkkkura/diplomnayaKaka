using System;
using System.Collections.Generic;

namespace diplomnayarrrr.Entities;

public partial class Teacher
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();
}
