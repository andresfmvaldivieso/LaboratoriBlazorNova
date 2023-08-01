using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenMenuGral
{
    public string CodApl { get; set; } = null!;

    public string CodObj { get; set; } = null!;

    public string CodGru { get; set; } = null!;

    public string DesObj { get; set; } = null!;

    public string? TipObj { get; set; }

    public string? RefObj { get; set; }

    public string GruMenu { get; set; } = null!;

    public string SecObj { get; set; } = null!;

    public bool? IndEst { get; set; }

    public int OrdObj { get; set; }

    public virtual SisAplicacion CodAplNavigation { get; set; } = null!;

    
}
