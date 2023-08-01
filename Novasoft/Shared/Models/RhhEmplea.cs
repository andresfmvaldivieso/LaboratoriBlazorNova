using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Novasoft.Server.Data;

/// <summary>
/// Maestra de Empleados
/// </summary>
public partial class RhhEmplea
{
    /// <summary>
    /// Código empleado
    /// </summary>
    public string CodEmp { get; set; } = null!;

    /// <summary>
    /// Apellido1
    /// </summary>
    public string Ap1Emp { get; set; } = null!;

    /// <summary>
    /// Apellido2
    /// </summary>
    public string? Ap2Emp { get; set; }

    /// <summary>
    /// Nombres
    /// </summary>
    public string? NomEmp { get; set; }

    /// <summary>
    /// Tipo identificacion
    /// </summary>
    public string TipIde { get; set; } = null!;

    /// <summary>
    /// Pais expedicion
    /// </summary>
    public string? PaiExp { get; set; }

    /// <summary>
    /// Ciudad expedicion
    /// </summary>
    public string CiuExp { get; set; } = null!;

    /// <summary>
    /// Fec. nacim
    /// </summary>
    public DateTime FecNac { get; set; }

    /// <summary>
    /// Pais
    /// </summary>
    public string? CodPai { get; set; }

    /// <summary>
    /// Depto
    /// </summary>
    public string? CodDep { get; set; }

    /// <summary>
    /// Ciudad
    /// </summary>
    public string? CodCiu { get; set; }

    /// <summary>
    /// Género
    /// </summary>
    public int SexEmp { get; set; }

    /// <summary>
    /// Número libreta
    /// </summary>
    public string? NumLib { get; set; }

    /// <summary>
    /// Clase Libreta Militar
    /// </summary>
    public short? ClaLib { get; set; }

    /// <summary>
    /// Distrito militar
    /// </summary>
    public short? DimLib { get; set; }

    /// <summary>
    /// Grupo Sanguíneo
    /// </summary>
    public string? GruSan { get; set; }

    /// <summary>
    /// Factor Rh
    /// </summary>
    public string? FacRhh { get; set; }

    /// <summary>
    /// Estado civil
    /// </summary>
    public short? EstCiv { get; set; }

    /// <summary>
    /// Nacionalidad
    /// </summary>
    public short? NacEmp { get; set; }

    /// <summary>
    /// Dir. Residencia
    /// </summary>
    public string? DirRes { get; set; }

    /// <summary>
    /// Teléfono Fijo
    /// </summary>
    public string? TelRes { get; set; }

    /// <summary>
    /// Pais reside
    /// </summary>
    public string? PaiRes { get; set; }

    /// <summary>
    /// Depto reside
    /// </summary>
    public string? DptRes { get; set; }

    /// <summary>
    /// Ciudad reside
    /// </summary>
    public string? CiuRes { get; set; }

    /// <summary>
    /// Personas a cargo
    /// </summary>
    public short? PerCar { get; set; }

    /// <summary>
    /// Fecha ingreso
    /// </summary>
    public DateTime? FecIng { get; set; }

    /// <summary>
    /// Fecha de retiro
    /// </summary>
    public DateTime? FecEgr { get; set; }

    /// <summary>
    /// Compañia
    /// </summary>
    public string? CodCia { get; set; }

    /// <summary>
    /// Sucursal
    /// </summary>
    public string? CodSuc { get; set; }

    /// <summary>
    /// Centro de costo
    /// </summary>
    public string? CodCco { get; set; }

    /// <summary>
    /// Clasificacion 1
    /// </summary>
    public string? CodCl1 { get; set; }

    /// <summary>
    /// Clasificación 2
    /// </summary>
    public string? CodCl2 { get; set; }

    /// <summary>
    /// Clasificación 3
    /// </summary>
    public string? CodCl3 { get; set; }

    /// <summary>
    /// cod_cl4                  
    /// </summary>
    public string? CodCl4 { get; set; }

    /// <summary>
    /// cod_cl5                  
    /// </summary>
    public string? CodCl5 { get; set; }

    /// <summary>
    /// cod_cl6                  
    /// </summary>
    public string? CodCl6 { get; set; }

    /// <summary>
    /// cod_cl7                  
    /// </summary>
    public string? CodCl7 { get; set; }

    /// <summary>
    /// Codigo cargo
    /// </summary>
    public string? CodCar { get; set; }

    /// <summary>
    /// Tipo contrato
    /// </summary>
    public string? TipCon { get; set; }

    /// <summary>
    /// Tipo pago
    /// </summary>
    public short? TipPag { get; set; }

    /// <summary>
    /// Metodo retencion
    /// </summary>
    public short? MetRet { get; set; }

    /// <summary>
    /// % retención
    /// </summary>
    public decimal? PorRet { get; set; }

    /// <summary>
    /// Tipo deducible
    /// </summary>
    public short? TipDed { get; set; }

    /// <summary>
    /// Descuento
    /// </summary>
    public decimal? MtoDto { get; set; }

    /// <summary>
    /// Codigo banco
    /// </summary>
    public string? CodBan { get; set; }

    /// <summary>
    /// Cuenta corriente
    /// </summary>
    public string? CtaBan { get; set; }

    /// <summary>
    /// Regimen salarial
    /// </summary>
    public short? RegSal { get; set; }

    /// <summary>
    /// Tipo de liquidacion
    /// </summary>
    public string? CodTlq { get; set; }

    /// <summary>
    /// Clase salario
    /// </summary>
    public short? ClaSal { get; set; }

    /// <summary>
    /// Estado laboral
    /// </summary>
    public string? EstLab { get; set; }

    /// <summary>
    /// Emp. pensionado
    /// </summary>
    public short? PenEmp { get; set; }

    /// <summary>
    /// Entidad de pension
    /// </summary>
    public string? EmpPen { get; set; }

    /// <summary>
    /// Causa pension
    /// </summary>
    public string? CauPen { get; set; }

    /// <summary>
    /// Fondo atep
    /// </summary>
    public string? FdoAte { get; set; }

    /// <summary>
    /// % atep
    /// </summary>
    public decimal? PorAte { get; set; }

    /// <summary>
    /// Fondo pension
    /// </summary>
    public string FdoPen { get; set; } = null!;

    /// <summary>
    /// Fondo salud
    /// </summary>
    public string? FdoSal { get; set; }

    /// <summary>
    /// Fondo cesantia
    /// </summary>
    public string FdoCes { get; set; } = null!;

    /// <summary>
    /// Fecha ult aumento
    /// </summary>
    public DateTime? FecAum { get; set; }

    /// <summary>
    /// Salario básico
    /// </summary>
    public decimal SalBas { get; set; }

    /// <summary>
    /// Salario anterior
    /// </summary>
    public decimal? SalAnt { get; set; }

    /// <summary>
    /// Nivel
    /// </summary>
    public decimal? NivOcu { get; set; }

    /// <summary>
    /// Estatura
    /// </summary>
    public decimal? TamEmp { get; set; }

    /// <summary>
    /// Peso
    /// </summary>
    public decimal? PesEmp { get; set; }

    /// <summary>
    /// Estrato Social
    /// </summary>
    public decimal? EstSoc { get; set; }

    /// <summary>
    /// Gastos
    /// </summary>
    public decimal? GasMen { get; set; }

    /// <summary>
    /// Periodicidad Bebidas Alcoholicas
    /// </summary>
    public decimal? PerBeb { get; set; }

    /// <summary>
    /// Promedio Cigarrillos
    /// </summary>
    public decimal? ProFum { get; set; }

    /// <summary>
    /// Indicador vacaciones
    /// </summary>
    public short? IndVac { get; set; }

    /// <summary>
    /// Dias vacaciones
    /// </summary>
    public short? DiaVac { get; set; }

    /// <summary>
    /// % sueldo
    /// </summary>
    public decimal? PjeSue { get; set; }

    /// <summary>
    /// Avisar a
    /// </summary>
    public string? AviEmp { get; set; }

    /// <summary>
    /// Prima de Vacaciones
    /// </summary>
    public decimal? IndPva { get; set; }

    /// <summary>
    /// Indicador sabado
    /// </summary>
    public decimal? IndSab { get; set; }

    /// <summary>
    /// Indicador mes 31
    /// </summary>
    public decimal? IndM31 { get; set; }

    /// <summary>
    /// Categoria cargo
    /// </summary>
    public string? CatCar { get; set; }

    /// <summary>
    /// Fecha cargo
    /// </summary>
    public DateTime? FecCar { get; set; }

    /// <summary>
    /// Fecha bonificación
    /// </summary>
    public DateTime? FecBon { get; set; }

    /// <summary>
    /// Fondo caja compen.
    /// </summary>
    public string? CcfEmp { get; set; }

    /// <summary>
    /// Calif servicio1
    /// </summary>
    public decimal? CalSer { get; set; }

    /// <summary>
    /// met_tpt                  
    /// </summary>
    public short? MetTpt { get; set; }

    /// <summary>
    /// Calif servicio2
    /// </summary>
    public decimal? CalSv2 { get; set; }

    /// <summary>
    /// Calif servicio3
    /// </summary>
    public decimal? CalSv3 { get; set; }

    /// <summary>
    /// Calif servicio4
    /// </summary>
    public decimal? CalSv4 { get; set; }

    /// <summary>
    /// Nombre
    /// </summary>
    public bool NomRem { get; set; }

    /// <summary>
    /// Cargo - encargo
    /// </summary>
    public string? CarEnc { get; set; }

    /// <summary>
    /// Grupo contable
    /// </summary>
    public string? CtaGas { get; set; }

    /// <summary>
    /// Ind. pago de dias
    /// </summary>
    public bool IndPdias { get; set; }

    /// <summary>
    /// Sueldo variable
    /// </summary>
    public decimal? SueVar { get; set; }

    /// <summary>
    /// Ind salario variable
    /// </summary>
    public byte? IndSvar { get; set; }

    /// <summary>
    /// Tipo nómina
    /// </summary>
    public byte? TipNom { get; set; }

    /// <summary>
    /// Ded. horas
    /// </summary>
    public decimal? DedHoras { get; set; }

    /// <summary>
    /// Valor hora
    /// </summary>
    public decimal? ValHora { get; set; }

    /// <summary>
    /// Clasif. categoria
    /// </summary>
    public string? ClasifCat { get; set; }

    /// <summary>
    /// horas_mes                
    /// </summary>
    public decimal? HorasMes { get; set; }

    /// <summary>
    /// Ind  aporta pensión
    /// </summary>
    public bool? ApoPen { get; set; }

    /// <summary>
    /// Ind  aporta salud
    /// </summary>
    public bool? ApoSal { get; set; }

    /// <summary>
    /// Ind  aporta riesgos
    /// </summary>
    public bool? ApoRie { get; set; }

    /// <summary>
    /// Distribucion Ccosto
    /// </summary>
    public byte IndDiscco { get; set; }

    /// <summary>
    /// Ind. de Evaluador
    /// </summary>
    public short IndEvalua { get; set; }

    /// <summary>
    /// reg_pres                 
    /// </summary>
    public string? RegPres { get; set; }

    /// <summary>
    /// Correo Electrónico
    /// </summary>
    public string? EMail { get; set; }

    /// <summary>
    /// Teléfono Celular
    /// </summary>
    public string? TelCel { get; set; }

    /// <summary>
    /// cod_reloj                
    /// </summary>
    public string? CodReloj { get; set; }

    /// <summary>
    /// mod_liq                  
    /// </summary>
    public string? ModLiq { get; set; }

    /// <summary>
    /// Sucursal Banco
    /// </summary>
    public string? SucBan { get; set; }

    /// <summary>
    /// tot_hor                  
    /// </summary>
    public decimal? TotHor { get; set; }

    /// <summary>
    /// tip_cot                  
    /// </summary>
    public string TipCot { get; set; } = null!;

    /// <summary>
    /// Extranjero
    /// </summary>
    public bool IndExtjero { get; set; }

    /// <summary>
    /// Reside en el Extranjero
    /// </summary>
    public bool IndResiExtjero { get; set; }

    /// <summary>
    /// Sub tipo de Cotizante
    /// </summary>
    public string SubTipCot { get; set; } = null!;

    /// <summary>
    /// Promedio de Salud
    /// </summary>
    public decimal PrmSal { get; set; }

    /// <summary>
    /// Departamento Expedición Doc Id
    /// </summary>
    public string? DptExp { get; set; }

    /// <summary>
    /// Aspiración Salarial
    /// </summary>
    public decimal? AspSal { get; set; }

    /// <summary>
    /// Disponibilidad del Aspirante
    /// </summary>
    public string? DispAsp { get; set; }

    /// <summary>
    /// Presupuesto Mensual de Gastos
    /// </summary>
    public decimal? PtoGas { get; set; }

    /// <summary>
    /// Tiene Deudas
    /// </summary>
    public bool? Deudas { get; set; }

    /// <summary>
    /// Detalle de las Deudas
    /// </summary>
    public string? CptoDeudas { get; set; }

    /// <summary>
    /// Nivel Académico
    /// </summary>
    public string? NivAca { get; set; }

    /// <summary>
    /// Número de Identificación
    /// </summary>
    public string? NumIde { get; set; }

    /// <summary>
    /// Barrio Residencia
    /// </summary>
    public string? Barrio { get; set; }

    /// <summary>
    /// Foto Empleado
    /// </summary>
    /// 
    [JsonIgnore]
    public byte[]? FtoEmp { get; set; }

    /// <summary>
    /// Rango de vacaciones
    /// </summary>
    public string CodRanvac { get; set; } = null!;

    /// <summary>
    /// Tipo Sindicalización
    /// </summary>
    public string TipSindclzdo { get; set; } = null!;

    /// <summary>
    /// Ind Embarazo
    /// </summary>
    public bool IndEmbz { get; set; }

    /// <summary>
    /// Ind Incapacidad Permanente
    /// </summary>
    public bool IndIncPm { get; set; }

    /// <summary>
    /// Valor Deducible No Aplicado
    /// </summary>
    public decimal MtoDtoNa { get; set; }

    /// <summary>
    /// Primer Nombre
    /// </summary>
    public string Nom1Emp { get; set; } = null!;

    /// <summary>
    /// Segundo Nombre
    /// </summary>
    public string? Nom2Emp { get; set; }

    /// <summary>
    /// Tipo de Pensionado 
    /// </summary>
    public short TipPen { get; set; }

    /// <summary>
    /// Pensión Compartida
    /// </summary>
    public bool IndPencomp { get; set; }

    /// <summary>
    /// Indicado Pago Pension en Exterior
    /// </summary>
    public bool IndPenpagext { get; set; }

    /// <summary>
    /// Indicador Empleado Pensionado por la Empresa
    /// </summary>
    public bool IndEmpleapenEmp { get; set; }

    /// <summary>
    /// Indicador Declarante Renta
    /// </summary>
    public string? IndDecRenta { get; set; }

    /// <summary>
    /// Fecha Primer Ingreso - Certificados Laborales
    /// </summary>
    public DateTime? FecPriming { get; set; }

    public string? CodEst { get; set; }

    /// <summary>
    /// Correo Alterno
    /// </summary>
    public string? EMailAlt { get; set; }

    public string? LoginPortal { get; set; }

    public DateTime? FecUltAct { get; set; }

    public int? NumReq { get; set; }

    public byte AutDat { get; set; }

    public DateTime? FecAut { get; set; }

    /// <summary>
    /// Tipo Vinculacion DIAN
    /// </summary>
    public string TipVincDian { get; set; } = null!;

    /// <summary>
    /// Tipo Medidas Certificadas Formato 2280 DIAN
    /// </summary>
    public string ConceptoDian2280 { get; set; } = null!;

    /// <summary>
    /// Ecuador- Dias Trabajo anterior.
    /// </summary>
    public int? DiaTraAntEc { get; set; }

    /// <summary>
    /// Ecuador-Tipo de vivienda.
    /// </summary>
    public int? TipVivEc { get; set; }

    /// <summary>
    /// Ecuador-Salario Trabajo anterior.
    /// </summary>
    public decimal? SalTrabAntEc { get; set; }

    /// <summary>
    /// Ecuador-REtencion Trabajo anterior .
    /// </summary>
    public decimal? RetTrabAntEc { get; set; }

    /// <summary>
    /// Ecuador-Numer ode Calle.
    /// </summary>
    public string? NroCalleEc { get; set; }

    /// <summary>
    /// Ecuador-Region.
    /// </summary>
    public int? RegionEc { get; set; }

    /// <summary>
    /// Ecuador-deducibles trabajo anterior.
    /// </summary>
    public decimal? DedTrabAntEc { get; set; }

    /// <summary>
    /// Ecuador-Rebajas trabajo anterior.
    /// </summary>
    public decimal? RebTrabAntEc { get; set; }

    /// <summary>
    /// Ecuador-Deducible de Renta.
    /// </summary>
    public decimal? DedrentaEc { get; set; }

    /// <summary>
    /// Ecuador-exoneracion por tercera edad.
    /// </summary>
    public bool? ExoTeredadEc { get; set; }

    /// <summary>
    /// Ecuador-Exoneracion por discapacidad.
    /// </summary>
    public bool? IndExodiscEc { get; set; }

    /// <summary>
    /// Ecuador-Fondo de Reserva.
    /// </summary>
    public bool? IndPagFdrEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica Utilidades .
    /// </summary>
    public bool? IndInclUtilEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica Decimo Tercera .
    /// </summary>
    public bool? IndMesdecterEc { get; set; }

    /// <summary>
    /// Ecuador-Aplica Decimo Cuarta .
    /// </summary>
    public bool? IndMesdecuaEc { get; set; }

    /// <summary>
    /// Indicador Distibucion centro de costo Niif.
    /// </summary>
    public byte IndDiscconif { get; set; }

    /// <summary>
    /// Cuenta Gasto Niif.
    /// </summary>
    public string? CtaGasnif { get; set; }

    /// <summary>
    /// Estabilidad laboral Reforzada
    /// </summary>
    public bool IndEstlabref { get; set; }

    /// <summary>
    /// Codigo Pago Electronico
    /// </summary>
    public string CodPagelec { get; set; } = null!;

    /// <summary>
    /// Indicador de Extranjero
    /// </summary>
    public bool IndExtranjero { get; set; }

    /// <summary>
    /// Ecuador: Grado Discapacidad
    /// </summary>
    public string GradodiscEc { get; set; } = null!;

    /// <summary>
    /// Indicador Contratista
    /// </summary>
    public bool IndCtt { get; set; }

    public Guid IdUniq { get; set; }

    /// <summary>
    /// Líder GH/Portal?
    /// </summary>
    public bool? IndLider { get; set; }

    /// <summary>
    /// Fecha Expedicion Doc. Identidad
    /// </summary>
    public DateTime? FecExpdoc { get; set; }

    /// <summary>
    /// Codigo Localidad Empleado
    /// </summary>
    public string CodLocalidad { get; set; } = null!;

    /// <summary>
    /// Codigo Barrio Empleado
    /// </summary>
    public string CodBarrio { get; set; } = null!;

    /// <summary>
    /// Nro Pasaporte
    /// </summary>
    public string NroPsp { get; set; } = null!;

    /// <summary>
    /// Emisor Pasaporte
    /// </summary>
    public string CodPaiEmisorPsp { get; set; } = null!;

    /// <summary>
    /// Fecha Expedición Pasaporte
    /// </summary>
    public DateTime? FecExpPsp { get; set; }

    /// <summary>
    /// Fecha Vencimiento Pasaporte
    /// </summary>
    public DateTime? FecVencPsp { get; set; }

    /// <summary>
    /// Indicador actuaizaci�n Sistema externo
    /// </summary>
    public bool IndActExtr { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodEmpExtr { get; set; }

    /// <summary>
    /// Grupo Étnico
    /// </summary>
    public string? CodGrupo { get; set; }

    /// <summary>
    /// Indicador Prepensionado
    /// </summary>
    public bool? IndPrepens { get; set; }

    /// <summary>
    /// Indicador Cabeza de Familia
    /// </summary>
    public bool? IndCabFam { get; set; }

    /// <summary>
    /// Indicador Tiene Mascota
    /// </summary>
    public bool? IndMascota { get; set; }
    [JsonIgnore]
    public virtual RhhTbfondo? CcfEmpNavigation { get; set; }
    [JsonIgnore]
    public virtual GenCiudad? Cod { get; set; }
    [JsonIgnore]
    public virtual GenBanco? CodBanNavigation { get; set; }
    [JsonIgnore]
    public virtual RhhCargo? CodCarNavigation { get; set; }
    [JsonIgnore]
    public virtual GenCcosto? CodCcoNavigation { get; set; }
    [JsonIgnore]
    public virtual GenCompanium? CodCiaNavigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif1? CodCl1Navigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif2? CodCl2Navigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif3? CodCl3Navigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif4? CodCl4Navigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif5? CodCl5Navigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif6? CodCl6Navigation { get; set; }
    [JsonIgnore]
    public virtual GenClasif7? CodCl7Navigation { get; set; }
    [JsonIgnore]
    public virtual GthRptEstado? CodEstNavigation { get; set; }
    [JsonIgnore]
    public virtual GenGrupoetnico? CodGrupoNavigation { get; set; }
    
    public virtual RhhRanVac CodRanvacNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual GenSucursal? CodSucNavigation { get; set; }
    [JsonIgnore]
    public virtual RhhTipoliq? CodTlqNavigation { get; set; }
    
    public virtual RhhTbmedidaDian2280 ConceptoDian2280Navigation { get; set; } = null!;
    [JsonIgnore]
    public virtual RhhTbestlab? EstLabNavigation { get; set; }
    [JsonIgnore]
    public virtual RhhTbfondo? FdoAteNavigation { get; set; }
    
    public virtual RhhTbfondo FdoCesNavigation { get; set; } = null!;
    
    public virtual RhhTbfondo FdoPenNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual RhhTbfondo? FdoSalNavigation { get; set; }
    [JsonIgnore]
    public virtual GenBarrio? GenBarrio { get; set; }
    [JsonIgnore]
    public virtual GenCiudad? GenCiudad { get; set; }
    [JsonIgnore]
    public virtual GenCiudad? GenCiudadNavigation { get; set; }
    [JsonIgnore]
    public virtual RhhTbclaest? NivAcaNavigation { get; set; }
    [JsonIgnore]
    public virtual RhhTbemppen? PenEmpNavigation { get; set; }
    
    public virtual RhhTbSubTipCotiza SubTipCotNavigation { get; set; } = null!;

    [ForeignKey("TipIde")]
    public virtual GenTipide TipIdeNavigation { get; set; } = new();
    [JsonIgnore]
    public virtual RhhTbTipPag? TipPagNavigation { get; set; }
    
    public virtual RhhTbtippen TipPenNavigation { get; set; } = null!;
    
    public virtual RhhTbsindicalizdo TipSindclzdoNavigation { get; set; } = null!;
    
    public virtual RhhTbtipvinculacion TipVincDianNavigation { get; set; } = null!;
}
