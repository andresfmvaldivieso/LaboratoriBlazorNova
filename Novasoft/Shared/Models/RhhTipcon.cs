using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTipcon
{
    /// <summary>
    /// Tipo Contrato
    /// </summary>
    public string TipCon { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomCon { get; set; }

    /// <summary>
    /// Tipo Duración
    /// </summary>
    public byte TipDur { get; set; }

    /// <summary>
    /// Duración
    /// </summary>
    public bool DurCon { get; set; }

    /// <summary>
    /// Auxilio de Tansporte
    /// </summary>
    public byte AuxTra { get; set; }

    /// <summary>
    /// Método Liquidación
    /// </summary>
    public byte MetLiq { get; set; }

    /// <summary>
    /// Tipo Académico
    /// </summary>
    public byte MetAca { get; set; }

    /// <summary>
    /// Habilitar Seguridad Social
    /// </summary>
    public bool? AplSs { get; set; }

    /// <summary>
    /// Calcular Vacaciones
    /// </summary>
    public bool? LiqVac { get; set; }

    /// <summary>
    /// Calcular Prima
    /// </summary>
    public bool? LiqPri { get; set; }

    /// <summary>
    /// Calcular Cesantías
    /// </summary>
    public bool? LiqCes { get; set; }

    public byte PrvMes { get; set; }

    /// <summary>
    /// En caso de IBC inferior al mínimo
    /// </summary>
    public byte IbcMin { get; set; }

    /// <summary>
    /// Porcentaje de aporte del patrón del IBC si en inf al mínimo
    /// </summary>
    public decimal? IbcPor { get; set; }

    /// <summary>
    /// Pagar los días no cubiertos por la adminstradora
    /// </summary>
    public bool? AuxInc { get; set; }

    /// <summary>
    /// Porcentaje a cubrir en el auxilio
    /// </summary>
    public decimal AuxPor { get; set; }

    /// <summary>
    /// Completar días no cubiertos por la administradora
    /// </summary>
    public bool AuxCom { get; set; }

    /// <summary>
    /// Aportar salud en caso de LNR
    /// </summary>
    public bool? IndAp8sal { get; set; }

    /// <summary>
    /// Aportar Pensión en caso de LNR
    /// </summary>
    public bool? IndAppen { get; set; }

    /// <summary>
    /// IBC usado para los días de vacaciones
    /// </summary>
    public byte IbcVac { get; set; }

    /// <summary>
    /// Auxilio de transporte en vacaciones
    /// </summary>
    public byte TrnVac { get; set; }

    /// <summary>
    /// Número max de períodos a reconocer
    /// </summary>
    public byte PerVac { get; set; }

    /// <summary>
    /// Días para provisión Vacaciones
    /// </summary>
    public short ProVac { get; set; }

    /// <summary>
    /// Auxilio de Transporte para la Prima
    /// </summary>
    public byte TrnPri { get; set; }

    /// <summary>
    /// Mínimo número de días para reconocer la Prima
    /// </summary>
    public short DiaPri { get; set; }

    /// <summary>
    /// Días para Provisión Prima
    /// </summary>
    public short ProPri { get; set; }

    /// <summary>
    /// Auxilio de Transporte para las Cesantías
    /// </summary>
    public byte TrnCes { get; set; }

    /// <summary>
    /// Forma de promedio para las Bases
    /// </summary>
    public byte ProBas { get; set; }

    /// <summary>
    /// Días para realizar promedio
    /// </summary>
    public short ProCes { get; set; }

    /// <summary>
    /// Concepto para Honorarios
    /// </summary>
    public string ConHon { get; set; } = null!;

    public bool IndVarbas { get; set; }

    /// <summary>
    /// Aportar Salud
    /// </summary>
    public bool? ApoSal { get; set; }

    /// <summary>
    /// Aportar Pensión
    /// </summary>
    public bool? ApoPen { get; set; }

    /// <summary>
    /// Aportar Riesgos
    /// </summary>
    public bool? ApoRie { get; set; }

    /// <summary>
    /// Aportar Slaud 100% patrón
    /// </summary>
    public bool ApoSalp100 { get; set; }

    /// <summary>
    /// Calcular parafiscales
    /// </summary>
    public bool? IndPara { get; set; }

    /// <summary>
    /// Calcular Prima
    /// </summary>
    public byte PagPri { get; set; }

    /// <summary>
    /// Calcular Cesantías
    /// </summary>
    public byte PagCes { get; set; }

    /// <summary>
    /// Día 31 en incapacidades
    /// </summary>
    public bool IndInc31 { get; set; }

    /// <summary>
    /// Modo de liquidación
    /// </summary>
    public string ModLiq { get; set; } = null!;

    /// <summary>
    /// IBC para el pago de Incapacidades
    /// </summary>
    public bool IndIbcinc { get; set; }

    /// <summary>
    /// Aportar Pension al 100% patrón
    /// </summary>
    public bool ApoPenp100 { get; set; }

    /// <summary>
    /// Código de Autoliquidación
    /// </summary>
    public string CodAutol { get; set; } = null!;

    /// <summary>
    /// El empleado aporta pensión en LNR
    /// </summary>
    public bool? IndAppenEmp { get; set; }

    /// <summary>
    /// Pagar día 31 en LNR
    /// </summary>
    public bool IndLnr31 { get; set; }

    /// <summary>
    /// Calcular Incapacidad con el sueldo básico del mes anterior
    /// </summary>
    public bool? IndIncSbas { get; set; }

    /// <summary>
    /// Patrón asume FSP
    /// </summary>
    public bool ApoFspP { get; set; }

    /// <summary>
    /// Porcentaje a provisionar por cesantías
    /// </summary>
    public decimal ProvCesan { get; set; }

    /// <summary>
    /// Porcentaje a provisionar por intereses de cesantía
    /// </summary>
    public decimal ProvIntces { get; set; }

    /// <summary>
    /// Porcentaje a provisionar por Prima
    /// </summary>
    public decimal ProvPrima { get; set; }

    /// <summary>
    /// Porcentaje a provisionar por Vacaciones
    /// </summary>
    public decimal ProvVacac { get; set; }

    /// <summary>
    /// No pagar con poroporcionalidad a 360
    /// </summary>
    public bool Pprima { get; set; }

    /// <summary>
    /// Número de días del semestre para prima
    /// </summary>
    public short Diasprima { get; set; }

    /// <summary>
    /// Calcula Salud Empleado en Licencia No Remunerada?
    /// </summary>
    public bool IndApsalEmp { get; set; }

    /// <summary>
    /// Indicador No Aplica Beneficio Bonos Alimentación al calcular tope para AFP y APV
    /// </summary>
    public bool IndRetNoAplBenAlim { get; set; }

    /// <summary>
    /// Indicador Vacaciones Salario Variable
    /// </summary>
    public short IndVacSalVar { get; set; }

    /// <summary>
    /// Indicador Riesgos Profesionales Asumir 1 Día
    /// </summary>
    public bool IndIrpAsumido { get; set; }

    /// <summary>
    /// Indicador Pagar Auxilio
    /// </summary>
    public bool IndIrpAuxilio { get; set; }

    /// <summary>
    /// Indicador Restar LNR Y SANCIONES
    /// </summary>
    public bool IndPrmLnr { get; set; }

    /// <summary>
    /// Porcentaje para Cubrir el Auxilio de los dias cubiertos 
    /// </summary>
    public decimal AuxPorDiasAdmon { get; set; }

    /// <summary>
    /// Calcular Auxilio Incapacidad con el IBC del mes anterior
    /// </summary>
    public bool? IndIbcdiasAdmon { get; set; }

    /// <summary>
    /// Indicador para aplicar Auxilio a incapacidades mayores a 4 dias
    /// </summary>
    public bool IndAuxAdmon { get; set; }

    /// <summary>
    /// Meses Para Promedio IBC
    /// </summary>
    public int MesProm { get; set; }

    /// <summary>
    /// Prima Promerio Sueldo Mensual 
    /// </summary>
    public bool IndPrmPromSalMen { get; set; }

    /// <summary>
    /// Prima Promerio Sueldo Mensual 
    /// </summary>
    public bool IndCesPromSalMen { get; set; }

    /// <summary>
    /// Aportar SS al 100% Empleado
    /// </summary>
    public bool ApoSsemp100 { get; set; }

    /// <summary>
    /// Proporcionalidad Para Intereses de Cesantias
    /// </summary>
    public short ProIntCes { get; set; }

    /// <summary>
    /// IBC Del Mes para cálculo de proyección de Seguridad Social
    /// </summary>
    public bool? IbcProySs { get; set; }

    /// <summary>
    /// Indicador Vacaciones Liquidacion de Contrato Salario Variable
    /// </summary>
    public bool IndVacSalVarLc { get; set; }

    /// <summary>
    /// Mínimo número de días para reconocer la Prima
    /// </summary>
    public short DiaCes { get; set; }

    /// <summary>
    /// Indicador para Base Salario Empleados Variables
    /// </summary>
    public byte IndSueldoSvar { get; set; }

    /// <summary>
    /// Indicador Indemnizacion Termino Fijo No pagar menos de 15 dias
    /// </summary>
    public bool? IndIndemTf { get; set; }

    /// <summary>
    /// Indicador Indemnizacion Salario Variable
    /// </summary>
    public short IndIndemSalVar { get; set; }

    /// <summary>
    /// Indicador Indemnizacion Liquidacion de Contrato Salario Variable
    /// </summary>
    public short IndIndemSalVarLc { get; set; }

    /// <summary>
    /// Calcular Provision Prima Segun Indicador Pag_pri
    /// </summary>
    public bool ProvPagPri { get; set; }

    /// <summary>
    /// Calcular Provision Cesantias Segun Indicador Pag_ces
    /// </summary>
    public bool ProvPagCes { get; set; }

    /// <summary>
    /// Calcular Provision Vacaciones Segun Indicador ind_SueldoSvar
    /// </summary>
    public bool ProvSueldoSvar { get; set; }

    /// <summary>
    /// Calculo Base Salario Indemnizacion
    /// </summary>
    public byte PagIndemn { get; set; }

    /// <summary>
    /// Indicador LNR Int.Cesantias
    /// </summary>
    public bool IndIntCesLnr { get; set; }

    /// <summary>
    /// Calcular Auxilio Incapacidad ARL con el IBC del mes anterior
    /// </summary>
    public bool IndIbcdiasArl { get; set; }

    /// <summary>
    /// Ecuador-Pagar Vacac. con Ult Remuner.
    /// </summary>
    public bool? VacUlremEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica fdo Reserva.
    /// </summary>
    public bool? LiqFdoresEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica Utilidades.
    /// </summary>
    public bool? LiqUtilEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica Decimo Tercera.
    /// </summary>
    public bool LiqDecterEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica Decimo Cuarta.
    /// </summary>
    public bool? LiqDeccuaEc { get; set; }

    /// <summary>
    /// Ecuador-numero de  meses a Provisionar.
    /// </summary>
    public byte ProvAnualEc { get; set; }

    /// <summary>
    /// No pagar con proporcionalidad a los dias definidos
    /// </summary>
    public bool Pcesantia { get; set; }

    /// <summary>
    /// Nro de días para periodo de prueba
    /// </summary>
    public int NroDiasPrueba { get; set; }

    /// <summary>
    /// Indicador Contratista
    /// </summary>
    public bool IndCtt { get; set; }

    /// <summary>
    /// Calcular Licencia Maternidad/Paternidad IBC del mes anterior o con el Salario Basico
    /// </summary>
    public bool IndIbcdiasLma { get; set; }

    /// <summary>
    /// Base Indemnizacion Solo Año Actual-Desde Enero
    /// </summary>
    public bool ProIndemEnero { get; set; }

    /// <summary>
    /// No Contar Dia31 en Vacaciones, Cuando No se paga
    /// </summary>
    public bool IndVac31 { get; set; }

    /// <summary>
    /// Validar Pago Transporte (Ultimo Periodo) con lo Devengado 
    /// </summary>
    public bool IndAuxTra { get; set; }

    /// <summary>
    /// Dias LNR Afecta Calculo Dias Indemnizacion
    /// </summary>
    public bool? IndIndemLnr { get; set; }

    /// <summary>
    /// Código Homologación Nómina electrónica 
    /// </summary>
    public short CodNomElec { get; set; }

    /// <summary>
    /// Proyectar Base Salario-Transporte para Prima Hasta FecCorte Liq.Prestacion
    /// </summary>
    public bool ProyPriServ { get; set; }

    /// <summary>
    /// Afecta Ausentismos con Interrupción de contrato?
    /// </summary>
    public bool? IndAusentVac { get; set; }

    public virtual RhhTbModLiq ModLiqNavigation { get; set; } = null!;
}
