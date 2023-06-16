using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenClasif6
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public short Estado { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
