using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class WebGridmaestro
{
    /// <summary>
    /// Código del maestro
    /// </summary>
    public short CodMae { get; set; }

    /// <summary>
    /// Número de la página
    /// </summary>
    public short NumPag { get; set; }

    /// <summary>
    /// Numero del grid asociado en web_maestros
    /// </summary>
    public string NumGrd { get; set; } = null!;

    /// <summary>
    /// Nombre del campo
    /// </summary>
    public string NomCmp { get; set; } = null!;

    /// <summary>
    /// Titulo del campo
    /// </summary>
    public string TitCmp { get; set; } = null!;

    /// <summary>
    /// formato del campo
    /// </summary>
    public string? ForCmp { get; set; }

    /// <summary>
    /// Indicador de requerido
    /// </summary>
    public bool ReqCmp { get; set; }

    /// <summary>
    /// codigo de validacion del campo (en javascript)
    /// </summary>
    public string? ValidCmp { get; set; }

    public string? WhenCmp { get; set; }

    public string? TabHlp { get; set; }

    public string? KeyHlp { get; set; }

    public string? NomHlp { get; set; }

    public string? FilHlp { get; set; }

    public bool IndLec { get; set; }

    public short OrdCmp { get; set; }

    public short NivSeg { get; set; }

    public string? JoinHlp { get; set; }

    public bool IndAud { get; set; }

    public virtual WebMaestro WebMaestro { get; set; } = null!;
}
