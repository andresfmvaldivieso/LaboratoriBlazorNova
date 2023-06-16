using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenClasif4
{
    /// <summary>
    /// Código
    /// </summary>
    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Estado
    /// </summary>
    public short Estado { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
