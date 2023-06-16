using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class RhhTbfondo
{
    /// <summary>
    /// Fondo
    /// </summary>
    public string CodFdo { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? NomFdo { get; set; }

    /// <summary>
    /// Nit fondo
    /// </summary>
    public string? NitTer { get; set; }

    /// <summary>
    /// Digito tercero
    /// </summary>
    public string? DvrTer { get; set; }

    /// <summary>
    /// Sector
    /// </summary>
    public decimal? SecFdo { get; set; }

    /// <summary>
    /// Tipo fondo
    /// </summary>
    public byte? TipFdo { get; set; }

    /// <summary>
    /// Cod iss
    /// </summary>
    public string? CodSgs { get; set; }

    /// <summary>
    /// Cta fondo
    /// </summary>
    public string? CtaFdo { get; set; }

    /// <summary>
    /// Cuenta débito
    /// </summary>
    public string? CtaDeb { get; set; }

    /// <summary>
    /// Ind ley 326
    /// </summary>
    public short? Ind326 { get; set; }

    /// <summary>
    /// Ind pago 30 días
    /// </summary>
    public bool IndD30 { get; set; }

    /// <summary>
    /// Descuento de Incapcidades Automático
    /// </summary>
    public bool IndDau { get; set; }

    /// <summary>
    /// Concepto
    /// </summary>
    public string CodCon { get; set; } = null!;

    /// <summary>
    /// Provisionar
    /// </summary>
    public bool IndProv { get; set; }

    /// <summary>
    /// Paga Incapacidades con doceavas
    /// </summary>
    public bool Ind12vaInc { get; set; }

    /// <summary>
    /// Cuenta Crédito FSP
    /// </summary>
    public string? CreFsp { get; set; }

    /// <summary>
    /// Cuenta Débito FSP
    /// </summary>
    public string? DebFsp { get; set; }

    /// <summary>
    /// Código SAP
    /// </summary>
    public string? CodSap { get; set; }

    /// <summary>
    /// Cuenta debito Niif.
    /// </summary>
    public string? NiifDeb { get; set; }

    /// <summary>
    /// Cuenta credito Niif.
    /// </summary>
    public string? NiifCre { get; set; }

    /// <summary>
    /// Cuenta debito fsp Niif
    /// </summary>
    public string? NiifDebfsp { get; set; }

    /// <summary>
    /// Cuenta credito fsp Niif.
    /// </summary>
    public string? NiifCrefsp { get; set; }

    /// <summary>
    /// Banco
    /// </summary>
    public string? CodBan { get; set; }

    /// <summary>
    /// No. Cuenta
    /// </summary>
    public string? CtaBanfdo { get; set; }

    /// <summary>
    /// Medio de pago
    /// </summary>
    public int? MedPag { get; set; }

    /// <summary>
    /// Tipo de cuenta
    /// </summary>
    public int? TipCtafdo { get; set; }

    /// <summary>
    /// Número de Rubro
    /// </summary>
    public string? Rubros { get; set; }

    /// <summary>
    /// Concepto Desc.
    /// </summary>
    public string? ConcDesc { get; set; }

    /// <summary>
    /// Tipo de Gasto
    /// </summary>
    public string? TipGasto { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleaCcfEmpNavigations { get; set; } = new List<RhhEmplea>();

    public virtual ICollection<RhhEmplea> RhhEmpleaFdoAteNavigations { get; set; } = new List<RhhEmplea>();

    public virtual ICollection<RhhEmplea> RhhEmpleaFdoCesNavigations { get; set; } = new List<RhhEmplea>();

    public virtual ICollection<RhhEmplea> RhhEmpleaFdoPenNavigations { get; set; } = new List<RhhEmplea>();

    public virtual ICollection<RhhEmplea> RhhEmpleaFdoSalNavigations { get; set; } = new List<RhhEmplea>();
}
