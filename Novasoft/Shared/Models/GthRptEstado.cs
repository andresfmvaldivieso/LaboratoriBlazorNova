using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GthRptEstado
{
    /// <summary>
    /// Código Estado Hoja de Vida
    /// </summary>
    public string CodEst { get; set; } = null!;

    /// <summary>
    /// Estado Hoja de Vida
    /// </summary>
    public string? DescEst { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
