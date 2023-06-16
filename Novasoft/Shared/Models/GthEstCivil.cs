using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GthEstCivil
{
    /// <summary>
    /// Estado Civil
    /// </summary>
    public int CodEst { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesEst { get; set; }

    /// <summary>
    /// Codigo Homologación para integraciones
    /// </summary>
    public string? CodEstExtr { get; set; }
}
