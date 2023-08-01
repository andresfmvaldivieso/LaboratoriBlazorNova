using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

/// <summary>
/// Tipos de Trabajo
/// </summary>
public partial class RhhTbTipTrabajo
{
    /// <summary>
    /// Codigo Tipo Trabajo
    /// </summary>
    public byte TipTrabajo { get; set; }

    /// <summary>
    /// Descripcion Tipo Trabajo
    /// </summary>
    public string Descripcion { get; set; } = null!;
}
