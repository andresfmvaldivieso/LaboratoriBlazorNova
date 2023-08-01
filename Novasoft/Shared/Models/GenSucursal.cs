using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenSucursal
{
    /// <summary>
    /// Código sucursal
    /// </summary>
    public string CodSuc { get; set; } = null!;

    /// <summary>
    /// Nombre sucursal
    /// </summary>
    public string? NomSuc { get; set; }

    /// <summary>
    /// Dirección sucursal
    /// </summary>
    public string? DirSuc { get; set; }

    /// <summary>
    /// Código país
    /// </summary>
    public string? CodPai { get; set; }

    /// <summary>
    /// Código depto
    /// </summary>
    public string? CodDep { get; set; }

    /// <summary>
    /// Código ciudad
    /// </summary>
    public string? CodCiu { get; set; }

    /// <summary>
    /// Teléfono sucursal
    /// </summary>
    public string? TelSuc { get; set; }

    /// <summary>
    /// Encargado sucursal
    /// </summary>
    public string? EncSuc { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    public short EstSuc { get; set; }

    /// <summary>
    /// % ICA Actividad Principal de la Ciudad de la Sucursal
    /// </summary>
    public decimal TarIca { get; set; }

    /// <summary>
    /// Bodega por Defecto de la Sucursal
    /// </summary>
    public string? BodFact { get; set; }

    /// <summary>
    /// Código de ICA
    /// </summary>
    public string CodIca { get; set; } = null!;

    /// <summary>
    /// Indicador de Exención de IVA
    /// </summary>
    public bool? ind_exciva { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodSucExtr { get; set; }

    /// <summary>
    /// Codigo Localidad Sucursal
    /// </summary>
    public string CodLocalidad { get; set; } = null!;

    /// <summary>
    /// Codigo Barrio Sucursal
    /// </summary>
    public string CodBarrio { get; set; } = null!;

    /// <summary>
    /// Indicador Actualización sistema externo
    /// </summary>
    public bool? IndActExtr { get; set; }

    public virtual GenCiudad? Cod { get; set; }

    public virtual GenBarrio? CodNavigation { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
