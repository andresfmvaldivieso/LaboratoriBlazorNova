using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenBanco
{
    /// <summary>
    /// Código
    /// </summary>
    public string CodBan { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string NomBan { get; set; } = null!;

    /// <summary>
    /// Código Transacción
    /// </summary>
    public string? CodTra { get; set; }

    /// <summary>
    /// Código Super Bancaria
    /// </summary>
    public string? CodSuper { get; set; }

    /// <summary>
    /// Nit Banco
    /// </summary>
    public string? NitBan { get; set; }

    /// <summary>
    /// Cod. Banco Unión
    /// </summary>
    public string? BanUnion { get; set; }

    /// <summary>
    /// Codigo Correspondencia Pago Elect.
    /// </summary>
    public string? BanEle { get; set; }

    /// <summary>
    /// Ecuador-codigo Banco Ecuador.
    /// </summary>
    public string? BanEc { get; set; }

    /// <summary>
    /// Código Banco GNB Sudameris
    /// </summary>
    public string BanNacha { get; set; } = null!;

    /// <summary>
    /// codigo_bancoach
    /// </summary>
    public string? CodBanach { get; set; }

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
