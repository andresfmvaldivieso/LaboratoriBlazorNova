using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbSubTipCotiza
{
    /// <summary>
    /// Subtipo Cotizante
    /// </summary>
    public string SubTipCot { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesSubTip { get; set; }

    /// <summary>
    /// Código en la Planilla
    /// </summary>
    public string CodPlasub { get; set; } = null!;

    /// <summary>
    /// Codigo Dian
    /// </summary>
    public string CodDian { get; set; } = null!;

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
