using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbclaest
{
    /// <summary>
    /// Tipo
    /// </summary>
    public string TipEst { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string DesEst { get; set; } = null!;

    /// <summary>
    /// Es un Curso?
    /// </summary>
    public bool IndCurso { get; set; }

    /// <summary>
    /// Orden de Tipo de Estudio
    /// </summary>
    public string? OrdEst { get; set; }

    /// <summary>
    /// Nivel Estudio Homologación
    /// </summary>
    public string? NivEstHom { get; set; }

    /// <summary>
    /// Codigo DIAN para Nivel Academico
    /// </summary>
    public string? CodDian { get; set; }

    /// <summary>
    /// Codigo Homologación para integraciones
    /// </summary>
    public string? TipEstExtr { get; set; }

    public virtual ICollection<RhhCargo> RhhCargos { get; set; } = new List<RhhCargo>();

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
