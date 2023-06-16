using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbtipvinculacion
{
    /// <summary>
    /// Tipo Vinculación 
    /// </summary>
    public string Tipo { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Codigo DIAN
    /// </summary>
    public string CodDian { get; set; } = null!;

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
