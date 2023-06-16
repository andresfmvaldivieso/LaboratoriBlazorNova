using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenDepto
{
    /// <summary>
    /// Pais
    /// </summary>
    public string CodPai { get; set; } = null!;

    /// <summary>
    /// Departamento
    /// </summary>
    public string CodDep { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string NomDep { get; set; } = null!;

    /// <summary>
    /// Ind politico
    /// </summary>
    public bool IndPol { get; set; }

    /// <summary>
    /// Sigla ACH
    /// </summary>
    public string? SiglaDep { get; set; }

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

    public virtual GenPaise CodPaiNavigation { get; set; } = null!;

    public virtual ICollection<GenCiudad> GenCiudads { get; set; } = new List<GenCiudad>();
}
