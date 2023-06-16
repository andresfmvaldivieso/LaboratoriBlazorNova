using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenCcosto
{
    /// <summary>
    /// Codigo
    /// </summary>
    public string CodCco { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomCco { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    public short EstCco { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodCcoExtr { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
