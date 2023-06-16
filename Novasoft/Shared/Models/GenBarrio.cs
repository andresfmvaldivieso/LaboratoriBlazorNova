using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenBarrio
{
    /// <summary>
    /// Código País
    /// </summary>
    public string CodPai { get; set; } = null!;

    /// <summary>
    /// Código Departamento
    /// </summary>
    public string CodDep { get; set; } = null!;

    /// <summary>
    /// Código Ciudad
    /// </summary>
    public string CodCiu { get; set; } = null!;

    /// <summary>
    /// Consecutivo
    /// </summary>
    public string CodLocalidad { get; set; } = null!;

    /// <summary>
    /// Código Barrio
    /// </summary>
    public string CodBarrio { get; set; } = null!;

    /// <summary>
    /// Nombre Barrio
    /// </summary>
    public string NombreBarrio { get; set; } = null!;

    /// <summary>
    /// Codigo Postal
    /// </summary>
    public string CodPostal { get; set; } = null!;

    /// <summary>
    ///  Indicador Actualizacion Sistema Externo
    /// </summary>
    public bool IndActExtr { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodBarrioExtr { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodCiuExtr { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodDepExtr { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodPaiExtr { get; set; }

    public virtual ICollection<GenSucursal> GenSucursals { get; set; } = new List<GenSucursal>();

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
