using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenFormapago
{
    /// <summary>
    /// Código
    /// </summary>
    public string CodPag { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomPag { get; set; }

    /// <summary>
    /// Ind. Pago 0 No Aplica 1 ACH 2 Cheque 3 Otros
    /// </summary>
    public byte TipPag { get; set; }
}
