using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbmedidaDian2280
{
    public string Concepto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
