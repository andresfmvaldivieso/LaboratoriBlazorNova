using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class WebMaestrosgen
{
    public short CodMae { get; set; }

    public string NomMae { get; set; } = null!;

    public string NomTab { get; set; } = null!;

    public string TipArc { get; set; } = null!;

    public string EmpSector { get; set; } = null!;

    public bool IndSta { get; set; }

    public string? FilDef { get; set; }

    /// <summary>
    /// Ind Ordenamiento de Llaves alfabeticamente.
    /// </summary>
    public bool IndOrdLlaves { get; set; }

    public virtual ICollection<WebMaestro> WebMaestros { get; set; } = new List<WebMaestro>();

    public virtual ICollection<WebPaginasmae> WebPaginasmaes { get; set; } = new List<WebPaginasmae>();
}
