using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhRanVac
{
    /// <summary>
    /// Código Rango para Dias Adicionales en Vacaciones
    /// </summary>
    public string CodRanVac { get; set; } = null!;

    /// <summary>
    /// Descripción Rango para Dias Adicionales en Vacaciones
    /// </summary>
    public string? DesRanVac { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
