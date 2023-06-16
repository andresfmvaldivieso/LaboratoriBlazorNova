using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTipoliq
{
    /// <summary>
    /// Código
    /// </summary>
    public string CodTlq { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string NomTlq { get; set; } = null!;

    /// <summary>
    /// Días
    /// </summary>
    public int DiasTlq { get; set; }

    /// <summary>
    /// Indicador Periodo Comercial
    /// </summary>
    public bool IndPeriodoCom { get; set; }

    /// <summary>
    /// Código Homologación Nómina electrónica 
    /// </summary>
    public short CodNomElec { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
