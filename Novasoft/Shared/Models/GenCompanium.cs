using System;
using System.Collections.Generic;

namespace Novasoft.Server.Data;

public partial class GenCompanium
{
    /// <summary>
    /// Código
    /// </summary>
    public string CodCia { get; set; } = null!;

    /// <summary>
    /// Nombre de la Compañía1
    /// </summary>
    public string? NomCia { get; set; }

    /// <summary>
    /// Nit
    /// </summary>
    public string? NitCia { get; set; }

    /// <summary>
    /// Digito verif. nit
    /// </summary>
    public string? DigVer { get; set; }

    /// <summary>
    /// Número patronal
    /// </summary>
    public string? NumPat { get; set; }

    /// <summary>
    /// Representante
    /// </summary>
    public string? RepLeg { get; set; }

    /// <summary>
    /// Dirección
    /// </summary>
    public string? DirCia { get; set; }

    /// <summary>
    /// Pais
    /// </summary>
    public string? CodPai { get; set; }

    /// <summary>
    /// Departamento
    /// </summary>
    public string? CodDep { get; set; }

    /// <summary>
    /// Ciudad
    /// </summary>
    public string? CodCiu { get; set; }

    /// <summary>
    /// Teléfono
    /// </summary>
    public string? TelCia { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? FaxCia { get; set; }

    /// <summary>
    /// Correo Electrónico
    /// </summary>
    public string? CorEle { get; set; }

    /// <summary>
    /// logo de la compañía
    /// </summary>
    public byte[]? LogoCia { get; set; }

    /// <summary>
    /// Firma Autorizada
    /// </summary>
    public byte[]? ImagenFirmaAut { get; set; }

    /// <summary>
    /// Responsable
    /// </summary>
    public string? ResponsableGh { get; set; }

    /// <summary>
    /// Nombre Pagador
    /// </summary>
    public string? NomPagador { get; set; }

    /// <summary>
    /// Director Recursos Humanos
    /// </summary>
    public string? DirectorRh { get; set; }

    /// <summary>
    /// Cargo Director Recursos Humanos
    /// </summary>
    public string? CargoDirectorRh { get; set; }

    /// <summary>
    /// Tipo de pagador de Pensiones
    /// </summary>
    public short TipPagpen { get; set; }

    /// <summary>
    /// Actividad Economica de la Empresa
    /// </summary>
    public string CodActEconomica { get; set; } = null!;

    /// <summary>
    /// Entidad Informante-DIAN
    /// </summary>
    public short EntInformante { get; set; }

    /// <summary>
    /// Identificación del fideicomiso o contrato-DIAN
    /// </summary>
    public string Identfc { get; set; } = null!;

    /// <summary>
    /// Tipo documento participante en contrato de colaboración-DIAN
    /// </summary>
    public string Tdocpcc { get; set; } = null!;

    /// <summary>
    /// Identificación participante en contrato colaboración-DIAN
    /// </summary>
    public string Nitpcc { get; set; } = null!;

    /// <summary>
    /// Codigo Organigrama
    /// </summary>
    public int CodOrganigrama { get; set; }

    /// <summary>
    /// Codigo Estructura Cargos
    /// </summary>
    public int CodEstrucCargo { get; set; }

    /// <summary>
    /// Campo llave de homologación para el sistema externo
    /// </summary>
    public string? CodCiaExtr { get; set; }

    /// <summary>
    /// Indicador Actualización Sistema Externo
    /// </summary>
    public bool? IndActExtr { get; set; }

    public virtual ICollection<RhhCargo> RhhCargos { get; set; } = new List<RhhCargo>();

    public virtual ICollection<RhhEmplea> RhhEmpleas { get; set; } = new List<RhhEmplea>();
}
