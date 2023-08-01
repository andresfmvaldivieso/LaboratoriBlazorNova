using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenCiudad
{
    /// <summary>
    /// Pais
    /// </summary>
    public string CodPai { get; set; } = null!;

    /// <summary>
    /// Dpto
    /// </summary>
    public string CodDep { get; set; } = null!;

    /// <summary>
    /// Codigo
    /// </summary>
    public string CodCiu { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomCiu { get; set; }

    /// <summary>
    /// Num habitantes
    /// </summary>
    public int? NumHab { get; set; }

    /// <summary>
    /// Indicador telefono Ciudad
    /// </summary>
    public string? IndTel { get; set; }

    /// <summary>
    /// Ica
    /// </summary>
    public bool? IndIca { get; set; }

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

    /// <summary>
    /// Indicador Actualización Sistema Externo
    /// </summary>
    public bool IndActExtr { get; set; }

    public virtual gen_deptos Cod { get; set; } = null!;

    public virtual GenPaise CodPaiNavigation { get; set; } = null!;

    public virtual ICollection<GenSucursal> GenSucursals { get; set; } = new List<GenSucursal>();

    public virtual ICollection<RhhEmplea> RhhEmpleaCods { get; set; } = new List<RhhEmplea>();

    public virtual ICollection<RhhEmplea> RhhEmpleaGenCiudadNavigations { get; set; } = new List<RhhEmplea>();

    public virtual ICollection<RhhEmplea> RhhEmpleaGenCiudads { get; set; } = new List<RhhEmplea>();
}
