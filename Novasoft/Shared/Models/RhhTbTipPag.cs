using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbTipPag
{
    /// <summary>
    /// Tipo de Pago
    /// </summary>
    public short TipPag { get; set; }

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomPag { get; set; }

    /// <summary>
    /// Forma de Pago Transferencia, Cheque, Otros
    /// </summary>
    public byte ForPag { get; set; }

    /// <summary>
    /// Tipo de Cuenta: Ahorros, Corriente, Otros
    /// </summary>
    public byte TipCta { get; set; }

    /// <summary>
    /// Código Homologación Nómina electrónica 
    /// </summary>
    public string CodNomElec { get; set; } = null!;

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
