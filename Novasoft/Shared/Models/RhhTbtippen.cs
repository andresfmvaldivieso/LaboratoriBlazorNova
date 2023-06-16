using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbtippen
{
    public short TipPen { get; set; }

    public string? DesTipPen { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
