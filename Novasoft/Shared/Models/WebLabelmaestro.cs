using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class WebLabelmaestro
{
    public short CodMae { get; set; }

    public short NumPag { get; set; }

    public string NomCmp { get; set; } = null!;

    public int PosxLbl { get; set; }

    public int PosyLbl { get; set; }

    public string? TxtLbl { get; set; }

    public string? FntLbl { get; set; }

    public int? SizeLbl { get; set; }

    public string? ColorLbl { get; set; }

    public bool? BoldLbl { get; set; }

    public bool? ItalicLbl { get; set; }

    public int? AncCmp { get; set; }

    public int? AltCmp { get; set; }

    public bool? EncCmp { get; set; }

    public virtual WebPaginasmae WebPaginasmae { get; set; } = null!;
}
