using System;
using System.Collections.Generic;

namespace crud.Models;

public partial class Usuario
{
    public int UserId { get; set; }

    public string? Login { get; set; }

    public string? Nombre { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }
}
