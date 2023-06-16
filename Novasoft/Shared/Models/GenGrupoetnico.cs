using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenGrupoetnico
{
    /// <summary>
    /// Codigo Grupo Etnico
    /// </summary>
    public string CodGrupo { get; set; } = null!;

    /// <summary>
    /// Descripción Grupo Etnico
    /// </summary>
    public string? Descripcion { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
