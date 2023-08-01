using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbTipCotiza
{
    /// <summary>
    /// Tipo Cotizante
    /// </summary>
    public string TipCot { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesCot { get; set; }

    /// <summary>
    /// Código en Planilla
    /// </summary>
    public string? CodPlanilla { get; set; }

    /// <summary>
    /// Codigo Dian
    /// </summary>
    public string CodDian { get; set; } = null!;

    /// <summary>
    /// Indicador Contratista
    /// </summary>
    public bool IndCtt { get; set; }
}
