using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbsindicalizdo
{
    /// <summary>
    /// Tipo Sindicalización
    /// </summary>
    public string TipSindclzdo { get; set; } = null!;

    /// <summary>
    /// Descripcion
    /// </summary>
    public string Descripcion { get; set; } = null!;

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
