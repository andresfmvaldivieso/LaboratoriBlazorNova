using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenPaise
{
    /// <summary>
    /// Codigo
    /// </summary>
    public string CodPai { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string NomPai { get; set; } = null!;

    /// <summary>
    /// Indicativo Telefónico
    /// </summary>
    public string? IndTel { get; set; }

    /// <summary>
    /// Código DIAN
    /// </summary>
    public string? CodDian { get; set; }

    /// <summary>
    /// Código País ISO
    /// </summary>
    public string? CodIso { get; set; }

    /// <summary>
    /// Idioma País
    /// </summary>
    public string? CodIdioma { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodPaiExtr { get; set; }

    /// <summary>
    /// Indicador Actualización Sistema Externo
    /// </summary>
    public bool IndActExtr { get; set; }

    public virtual ICollection<GenCiudad> GenCiudads { get; set; } = new List<GenCiudad>();

    public virtual ICollection<GenDepto> GenDeptos { get; set; } = new List<GenDepto>();
}
