using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplomnayarrrr.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
    
}
