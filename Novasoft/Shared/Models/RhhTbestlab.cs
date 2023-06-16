using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbestlab
{
    /// <summary>
    /// Estado
    /// </summary>
    public string EstLab { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string NomEst { get; set; } = null!;

    /// <summary>
    /// Ind. liquidación
    /// </summary>
    public bool IndLiq { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
