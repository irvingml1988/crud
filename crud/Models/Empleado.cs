using System;
using System.Collections.Generic;

namespace crud.Models;

public partial class Empleado
{
    public int? UserId { get; set; }

    public decimal? Sueldo { get; set; }

    public DateTime? FechaIngreso { get; set; }
}
