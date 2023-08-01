using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class WebMaestro
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
    /// Nombre del campo
    /// </summary>
    public string NomCmp { get; set; } = null!;

    /// <summary>
    /// Posicion X del campo
    /// </summary>
    public int PosxCmp { get; set; }

    /// <summary>
    /// Posicion Y del campo
    /// </summary>
    public int PosyCmp { get; set; }

    /// <summary>
    /// Tipo de objeto
    /// </summary>
    public string TipCmp { get; set; } = null!;

    /// <summary>
    /// Indicador de requerido
    /// </summary>
    public bool? ReqCmp { get; set; }

    /// <summary>
    /// Formato del campo
    /// </summary>
    public string? ForCmp { get; set; }

    /// <summary>
    /// Opciones del campo
    /// </summary>
    public string? OpcCmp { get; set; }

    /// <summary>
    /// valores de la opcion(values)
    /// </summary>
    public string? ValOpc { get; set; }

    /// <summary>
    /// Tabla de ayuda
    /// </summary>
    public string? TabHlp { get; set; }

    /// <summary>
    /// Llave de la tabla de ayuda
    /// </summary>
    public string? KeyHlp { get; set; }

    /// <summary>
    /// Nombre de la ayuda
    /// </summary>
    public string? NomHlp { get; set; }

    /// <summary>
    /// Ancho del campo
    /// </summary>
    public int? AncCmp { get; set; }

    /// <summary>
    /// Alto del campo
    /// </summary>
    public int? AltCmp { get; set; }

    /// <summary>
    /// Indicador de busqueda
    /// </summary>
    public bool? IndBus { get; set; }

    /// <summary>
    /// indicador de lectura
    /// </summary>
    public bool? IndLec { get; set; }

    /// <summary>
    /// orden de tabulacion del campo
    /// </summary>
    public int? OrdTab { get; set; }

    public string? ValidCmp { get; set; }

    public string? WhenCmp { get; set; }

    public bool? EncCmp { get; set; }

    /// <summary>
    /// Indicador de Auditoria
    /// </summary>
    public bool IndAud { get; set; }

    public bool? IndVal { get; set; }

    public short NivSeg { get; set; }

    public virtual WebMaestrosgen CodMaeNavigation { get; set; } = null!;

    //public virtual WebPaginasmae WebPaginasmae { get; set; } = null!;
}
