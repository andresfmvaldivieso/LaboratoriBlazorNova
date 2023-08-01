using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbModLiq
{
    /// <summary>
    /// Código
    /// </summary>
    public string ModLiq { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesMod { get; set; }

    /// <summary>
    /// Indicador Contratista
    /// </summary>
    public bool IndCtt { get; set; }

    public virtual ICollection<RhhTipcon> RhhTipcons { get; set; } = new List<RhhTipcon>();
}
