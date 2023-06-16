using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhCargo
{
    /// <summary>
    /// Codigo
    /// </summary>
    public string CodCar { get; set; } = null!;

    /// <summary>
    /// Grado
    /// </summary>
    public string? CodGra { get; set; }

    /// <summary>
    /// Nombre
    /// </summary>
    public string NomCar { get; set; } = null!;

    /// <summary>
    /// Salario
    /// </summary>
    public decimal SalBas { get; set; }

    /// <summary>
    /// Nivel del cargo
    /// </summary>
    public string NivCar { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string? DesCar { get; set; }

    /// <summary>
    /// Cargo de la entidad
    /// </summary>
    public bool? CarCia { get; set; }

    /// <summary>
    /// atrib
    /// </summary>
    public short? Atrib { get; set; }

    /// <summary>
    /// Cargo Superior
    /// </summary>
    public string? CarSup { get; set; }

    /// <summary>
    /// Responsabilidades del Cargo
    /// </summary>
    public string? RespCar { get; set; }

    /// <summary>
    /// Funciones del Cargo
    /// </summary>
    public string? FuncCar { get; set; }

    /// <summary>
    /// Nivel Académico
    /// </summary>
    public string? NivAca { get; set; }

    /// <summary>
    /// Area Desempeño CNO
    /// </summary>
    public string? CodAreaCno { get; set; }

    /// <summary>
    /// Nivel Preparación CNO
    /// </summary>
    public string? CodNivelCno { get; set; }

    /// <summary>
    /// Cod Convenio
    /// </summary>
    public string? CodConv { get; set; }

    /// <summary>
    /// Cod Compañia
    /// </summary>
    public string? CodCia { get; set; }

    public string? CodCli { get; set; }

    /// <summary>
    /// Grupo CIUO
    /// </summary>
    public string? CodGruCiuo { get; set; }

    /// <summary>
    /// Código CIUO
    /// </summary>
    public string? CodCiuo { get; set; }

    /// <summary>
    /// CNO Detallado
    /// </summary>
    public string? CnoDet { get; set; }

    /// <summary>
    /// Ecuador-Actividad Sectorial .
    /// </summary>
    public string CodActSecEc { get; set; } = null!;

    /// <summary>
    /// Objetivos Cargo
    /// </summary>
    public string? ObjCar { get; set; }

    /// <summary>
    /// Ecuador-Actividad Sectorial
    /// </summary>
    public string RamaActsecEc { get; set; } = null!;

    /// <summary>
    /// Ecuador-Codigo IESS Actividad Sectorial
    /// </summary>
    public string CodIessEc { get; set; } = null!;

    /// <summary>
    /// Código Crítico
    /// </summary>
    public string? CodCritico { get; set; }

    /// <summary>
    /// Código Categoría de Cargo
    /// </summary>
    public string? CodCatCar { get; set; }

    /// <summary>
    /// Código Cargo Copiado
    /// </summary>
    public string? CarCop { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodCarExtr { get; set; }

    public string CodEmpleo { get; set; } = null!;

    /// <summary>
    /// Indicador Actualización Sistema Externo
    /// </summary>
    public bool? IndActExtr { get; set; }

    /// <summary>
    /// Codigo Estructura de Cargo Cliente Externo
    /// </summary>
    public int CodEstrucCargo { get; set; }

    /// <summary>
    /// Codigo Compañía Cliente Externo
    /// </summary>
    public string? CodCiaExtr { get; set; }

    public virtual RhhCargo? CarSupNavigation { get; set; }

    public virtual GenCompanium? CodCiaNavigation { get; set; }

    public virtual ICollection<RhhCargo> InverseCarSupNavigation { get; set; } = new List<RhhCargo>();

    public virtual RhhTbclaest? NivAcaNavigation { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
