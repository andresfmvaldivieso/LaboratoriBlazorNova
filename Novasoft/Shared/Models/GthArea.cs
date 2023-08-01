using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

/// <summary>
/// Areas de una Organización
/// </summary>
public partial class GthArea
{
    /// <summary>
    /// Compañía
    /// </summary>
    public string CodCia { get; set; } = null!;

    /// <summary>
    /// Área
    /// </summary>
    public string CodArea { get; set; } = null!;

    /// <summary>
    /// Código de quien depende
    /// </summary>
    public string? CodDep { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesArea { get; set; }

    /// <summary>
    /// Código en el Organigrama
    /// </summary>
    public string? CodOrg { get; set; }

    /// <summary>
    /// Código Compañia Sistema Externo
    /// </summary>
    public string? CodCiaExtr { get; set; }

    /// <summary>
    /// Código Area Sistema Externo
    /// </summary>
    public string? CodAreaExtr { get; set; }

    /// <summary>
    /// Indicador Actualización Sistema Externo
    /// </summary>
    public bool? IndActExtr { get; set; }

    /// <summary>
    /// Código Organigrama Sistema Externo
    /// </summary>
    public int? CodOrganigrama { get; set; }

    public virtual GenCompanium CodCiaNavigation { get; set; } = null!;
}
