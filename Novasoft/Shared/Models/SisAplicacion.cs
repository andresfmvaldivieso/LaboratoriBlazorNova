using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class SisAplicacion
{
    /// <summary>
    /// Código
    /// </summary>
    public string CodApl { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomMod { get; set; }

    /// <summary>
    /// Orden
    /// </summary>
    public string Orden { get; set; } = null!;

    /// <summary>
    /// Clave
    /// </summary>
    public string? CodEnc { get; set; }

    /// <summary>
    /// Ind instalacióndo
    /// </summary>
    public bool IndIns { get; set; }

    /// <summary>
    /// Número licencias
    /// </summary>
    public string? NumLic { get; set; }

    public string? VerApl { get; set; }

    public string? EmpApl { get; set; }

    public string? IndCom { get; set; }

    public string? VerAplEnc { get; set; }

    public virtual ICollection<GenMenuGral> GenMenuGrals { get; set; } = new List<GenMenuGral>();
}
