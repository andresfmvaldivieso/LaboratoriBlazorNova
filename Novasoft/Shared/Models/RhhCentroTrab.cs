using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhCentroTrab
{
    /// <summary>
    /// Código Centro de Trabajo
    /// </summary>
    public int CodCt { get; set; }

    /// <summary>
    /// Descripción 
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Porcentaje
    /// </summary>
    public decimal Porcentaje { get; set; }

    /// <summary>
    /// Actividad Alto Riesgo
    /// </summary>
    public bool IndAltoriesgo { get; set; }

    /// <summary>
    /// Clase De Riesgo
    /// </summary>
    public short ClaseRiesgo { get; set; }

    /// <summary>
    /// Indicador tarifa especial pensiones para alto riesgo 0.Tarifa normal,1. Actividades de alto riesgo.2. Senadores.3. CTI.4. Aviadores.
    /// </summary>
    public short TarEspecPens { get; set; }

    /// <summary>
    /// Código Compañía
    /// </summary>
    public string CodCia { get; set; } = null!;

    /// <summary>
    /// Centro de Trabajo Planilla
    /// </summary>
    public string CodCtPlanilla { get; set; } = null!;
}
