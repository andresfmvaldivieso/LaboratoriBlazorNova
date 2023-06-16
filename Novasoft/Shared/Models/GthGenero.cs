using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GthGenero
{
    /// <summary>
    /// Género
    /// </summary>
    public int CodGen { get; set; }

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesGen { get; set; }

    /// <summary>
    /// Codigo Homologación para integraciones
    /// </summary>
    public string? CodGenExtr { get; set; }
}
