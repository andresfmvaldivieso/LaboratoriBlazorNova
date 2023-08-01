using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenTipide
{
    /// <summary>
    /// Código
    /// </summary>
    public string CodTip { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesTip { get; set; }

    /// <summary>
    /// Tipo
    /// </summary>
    public string? TipTip { get; set; }

    /// <summary>
    /// Código Dian
    /// </summary>
    public string? CodDian { get; set; }

    /// <summary>
    /// Código Superintendencia de Vigilancia
    /// </summary>
    public string? CodSpv { get; set; }

    
}
