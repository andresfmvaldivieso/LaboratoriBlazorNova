using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class WebPaginasmae
{
    public short CodMae { get; set; }

    public short NumPag { get; set; }

    public string NomPag { get; set; } = null!;

    public int? AncPag { get; set; }

    public short OrdPag { get; set; }

    public bool IndSta { get; set; }

    public string SecPag { get; set; } = null!;

    public virtual WebMaestrosgen CodMaeNavigation { get; set; } = null!;

    public virtual ICollection<WebLabelmaestro> WebLabelmaestros { get; set; } = new List<WebLabelmaestro>();

    public virtual ICollection<WebMaestro> WebMaestros { get; set; } = new List<WebMaestro>();
}
