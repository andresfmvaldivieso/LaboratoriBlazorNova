using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Novasoft.Server.Data;

public partial class BdlaboratorioContext : DbContext
{
    public BdlaboratorioContext()
    {
    }

    public BdlaboratorioContext(DbContextOptions<BdlaboratorioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GenBanco> GenBancos { get; set; }

    public virtual DbSet<GenBarrio> GenBarrios { get; set; }

    public virtual DbSet<GenCcosto> GenCcostos { get; set; }

    public virtual DbSet<GenCiudad> GenCiudads { get; set; }

    public virtual DbSet<GenClasif1> GenClasif1s { get; set; }

    public virtual DbSet<GenClasif2> GenClasif2s { get; set; }

    public virtual DbSet<GenClasif3> GenClasif3s { get; set; }

    public virtual DbSet<GenClasif4> GenClasif4s { get; set; }

    public virtual DbSet<GenClasif5> GenClasif5s { get; set; }

    public virtual DbSet<GenClasif6> GenClasif6s { get; set; }

    public virtual DbSet<GenClasif7> GenClasif7s { get; set; }

    public virtual DbSet<GenCompanium> GenCompania { get; set; }

    public virtual DbSet<GenDepto> GenDeptos { get; set; }

    public virtual DbSet<GenGrupoetnico> GenGrupoetnicos { get; set; }

    public virtual DbSet<GenMenuGral> GenMenuGrals { get; set; }

    public virtual DbSet<GenPaise> GenPaises { get; set; }

    public virtual DbSet<GenSucursal> GenSucursals { get; set; }

    public virtual DbSet<GenTipide> GenTipides { get; set; }

    public virtual DbSet<GthEstCivil> GthEstCivils { get; set; }

    public virtual DbSet<GthGenero> GthGeneros { get; set; }

    public virtual DbSet<GthRptEstado> GthRptEstados { get; set; }

    public virtual DbSet<RhhCargo> RhhCargos { get; set; }

    public virtual DbSet<RhhEmplea> RhhEmpleas { get; set; }

    public virtual DbSet<RhhRanVac> RhhRanVacs { get; set; }

    public virtual DbSet<RhhTbSubTipCotiza> RhhTbSubTipCotizas { get; set; }

    public virtual DbSet<RhhTbTipPag> RhhTbTipPags { get; set; }

    public virtual DbSet<RhhTbclaest> RhhTbclaests { get; set; }

    public virtual DbSet<RhhTbemppen> RhhTbemppens { get; set; }

    public virtual DbSet<RhhTbestlab> RhhTbestlabs { get; set; }

    public virtual DbSet<RhhTbfondo> RhhTbfondos { get; set; }

    public virtual DbSet<RhhTbmedidaDian2280> RhhTbmedidaDian2280s { get; set; }

    public virtual DbSet<RhhTbsindicalizdo> RhhTbsindicalizdos { get; set; }

    public virtual DbSet<RhhTbtippen> RhhTbtippens { get; set; }

    public virtual DbSet<RhhTbtipvinculacion> RhhTbtipvinculacions { get; set; }

    public virtual DbSet<RhhTipoliq> RhhTipoliqs { get; set; }

    public virtual DbSet<SisAplicacion> SisAplicacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=E-C5G2DS3;Initial Catalog=BDLaboratorio;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GenBanco>(entity =>
        {
            entity.HasKey(e => e.CodBan).IsClustered(false);

            entity.ToTable("gen_bancos", tb => tb.HasTrigger("tr_gen_bancos"));

            entity.Property(e => e.CodBan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("cod_ban");
            entity.Property(e => e.BanEc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Ecuador-codigo Banco Ecuador.")
                .HasColumnName("ban_ec");
            entity.Property(e => e.BanEle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo Correspondencia Pago Elect.")
                .HasColumnName("ban_ele");
            entity.Property(e => e.BanNacha)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Código Banco GNB Sudameris")
                .HasColumnName("ban_nacha");
            entity.Property(e => e.BanUnion)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cod. Banco Unión")
                .HasColumnName("ban_union");
            entity.Property(e => e.CodBanach)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasComment("codigo_bancoach")
                .HasColumnName("cod_banach");
            entity.Property(e => e.CodSuper)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Código Super Bancaria")
                .HasColumnName("cod_super");
            entity.Property(e => e.CodTra)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Transacción")
                .HasColumnName("cod_tra");
            entity.Property(e => e.NitBan)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Nit Banco")
                .HasColumnName("nit_ban");
            entity.Property(e => e.NomBan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_ban");
        });

        modelBuilder.Entity<GenBarrio>(entity =>
        {
            entity.HasKey(e => new { e.CodPai, e.CodDep, e.CodCiu, e.CodLocalidad, e.CodBarrio });

            entity.ToTable("gen_barrios");

            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Código País")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CodDep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Código Departamento")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodCiu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Código Ciudad")
                .HasColumnName("cod_ciu");
            entity.Property(e => e.CodLocalidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Consecutivo")
                .HasColumnName("cod_localidad");
            entity.Property(e => e.CodBarrio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Código Barrio")
                .HasColumnName("cod_barrio");
            entity.Property(e => e.CodBarrioExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_barrio_Extr");
            entity.Property(e => e.CodCiuExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_ciu_Extr");
            entity.Property(e => e.CodDepExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_dep_Extr");
            entity.Property(e => e.CodPaiExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_pai_Extr");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo Postal")
                .HasColumnName("cod_postal");
            entity.Property(e => e.IndActExtr)
                .HasComment(" Indicador Actualizacion Sistema Externo")
                .HasColumnName("ind_act_extr");
            entity.Property(e => e.NombreBarrio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre Barrio")
                .HasColumnName("nombre_barrio");
        });

        modelBuilder.Entity<GenCcosto>(entity =>
        {
            entity.HasKey(e => e.CodCco).IsClustered(false);

            entity.ToTable("gen_ccosto", tb => tb.HasTrigger("tr_gen_ccosto"));

            entity.Property(e => e.CodCco)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo")
                .HasColumnName("cod_cco");
            entity.Property(e => e.CodCcoExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_cco_Extr");
            entity.Property(e => e.EstCco)
                .HasDefaultValueSql("((1))")
                .HasComment("Estado")
                .HasColumnName("est_cco");
            entity.Property(e => e.NomCco)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre")
                .HasColumnName("nom_cco");
        });

        modelBuilder.Entity<GenCiudad>(entity =>
        {
            entity.HasKey(e => new { e.CodPai, e.CodDep, e.CodCiu }).IsClustered(false);

            entity.ToTable("gen_ciudad", tb =>
                {
                    tb.HasTrigger("sp_gen_ciudad_del");
                    tb.HasTrigger("tr_gen_ciudad");
                    tb.HasTrigger("tr_gen_ciudad_upd_replicadatos");
                    tb.HasTrigger("tr_rhh_gen_ciudad_localidad");
                });

            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CodDep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Dpto")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodCiu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo")
                .HasColumnName("cod_ciu");
            entity.Property(e => e.CodCiuExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_ciu_Extr");
            entity.Property(e => e.CodDepExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_dep_Extr");
            entity.Property(e => e.CodPaiExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_pai_Extr");
            entity.Property(e => e.IndActExtr)
                .HasComment("Indicador Actualización Sistema Externo")
                .HasColumnName("ind_act_Extr");
            entity.Property(e => e.IndIca)
                .HasDefaultValueSql("((0))")
                .HasComment("Ica")
                .HasColumnName("ind_ica");
            entity.Property(e => e.IndTel)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Indicador telefono Ciudad")
                .HasColumnName("ind_tel");
            entity.Property(e => e.NomCiu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_ciu");
            entity.Property(e => e.NumHab)
                .HasComment("Num habitantes")
                .HasColumnName("num_hab");

            entity.HasOne(d => d.CodPaiNavigation).WithMany(p => p.GenCiudads)
                .HasForeignKey(d => d.CodPai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gen_ciudad_gen_paises");

            entity.HasOne(d => d.Cod).WithMany(p => p.GenCiudads)
                .HasForeignKey(d => new { d.CodPai, d.CodDep })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gen_ciudad_gen_deptos");
        });

        modelBuilder.Entity<GenClasif1>(entity =>
        {
            entity.HasKey(e => e.Codigo).IsClustered(false);

            entity.ToTable("gen_clasif1", tb => tb.HasTrigger("tr_gen_clasif1"));

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Codigo")
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasComment("Estado")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<GenClasif2>(entity =>
        {
            entity.HasKey(e => e.Codigo).IsClustered(false);

            entity.ToTable("gen_clasif2", tb => tb.HasTrigger("tr_gen_clasif2"));

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Código")
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasComment("Estado")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<GenClasif3>(entity =>
        {
            entity.HasKey(e => e.Codigo).IsClustered(false);

            entity.ToTable("gen_clasif3", tb => tb.HasTrigger("tr_gen_clasif3"));

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Código")
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasComment("Estado")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<GenClasif4>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_GEN_CLASIF4")
                .IsClustered(false);

            entity.ToTable("gen_clasif4");

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Código")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasComment("Estado")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasComment("Nombre")
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<GenClasif5>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_GEN_CLASIF5")
                .IsClustered(false);

            entity.ToTable("gen_clasif5");

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<GenClasif6>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_GEN_CLASIF6")
                .IsClustered(false);

            entity.ToTable("gen_clasif6");

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<GenClasif7>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_GEN_CLASIF7")
                .IsClustered(false);

            entity.ToTable("gen_clasif7");

            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<GenCompanium>(entity =>
        {
            entity.HasKey(e => e.CodCia).HasName("cod_cia");

            entity.ToTable("gen_compania", tb => tb.HasTrigger("tr_gen_compania_EstrucCargo"));

            entity.Property(e => e.CodCia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("cod_cia");
            entity.Property(e => e.CargoDirectorRh)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Cargo Director Recursos Humanos")
                .HasColumnName("Cargo_Director_RH");
            entity.Property(e => e.CodActEconomica)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasComment("Actividad Economica de la Empresa")
                .HasColumnName("Cod_Act_Economica");
            entity.Property(e => e.CodCiaExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_cia_Extr");
            entity.Property(e => e.CodCiu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Ciudad")
                .HasColumnName("cod_ciu");
            entity.Property(e => e.CodDep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Departamento")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodEstrucCargo)
                .HasComment("Codigo Estructura Cargos")
                .HasColumnName("cod_estrucCargo");
            entity.Property(e => e.CodOrganigrama)
                .ValueGeneratedOnAdd()
                .HasComment("Codigo Organigrama")
                .HasColumnName("cod_organigrama");
            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CorEle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Correo Electrónico")
                .HasColumnName("cor_ele");
            entity.Property(e => e.DigVer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Digito verif. nit")
                .HasColumnName("dig_ver");
            entity.Property(e => e.DirCia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Dirección")
                .HasColumnName("dir_cia");
            entity.Property(e => e.DirectorRh)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Director Recursos Humanos")
                .HasColumnName("Director_RH");
            entity.Property(e => e.EntInformante)
                .HasDefaultValueSql("((1))")
                .HasComment("Entidad Informante-DIAN");
            entity.Property(e => e.FaxCia)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Fax")
                .HasColumnName("fax_cia");
            entity.Property(e => e.Identfc)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Identificación del fideicomiso o contrato-DIAN")
                .HasColumnName("identfc");
            entity.Property(e => e.ImagenFirmaAut)
                .HasComment("Firma Autorizada")
                .HasColumnName("imagen_firma_aut");
            entity.Property(e => e.IndActExtr)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador Actualización Sistema Externo")
                .HasColumnName("ind_act_Extr");
            entity.Property(e => e.LogoCia)
                .HasComment("logo de la compañía")
                .HasColumnName("logo_cia");
            entity.Property(e => e.NitCia)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nit")
                .HasColumnName("nit_cia");
            entity.Property(e => e.Nitpcc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Identificación participante en contrato colaboración-DIAN")
                .HasColumnName("nitpcc");
            entity.Property(e => e.NomCia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Nombre de la Compañía1")
                .HasColumnName("nom_cia");
            entity.Property(e => e.NomPagador)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Nombre Pagador")
                .HasColumnName("Nom_Pagador");
            entity.Property(e => e.NumPat)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Número patronal")
                .HasColumnName("num_pat");
            entity.Property(e => e.RepLeg)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Representante")
                .HasColumnName("rep_leg");
            entity.Property(e => e.ResponsableGh)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Responsable")
                .HasColumnName("Responsable_GH");
            entity.Property(e => e.Tdocpcc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Tipo documento participante en contrato de colaboración-DIAN")
                .HasColumnName("tdocpcc");
            entity.Property(e => e.TelCia)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Teléfono")
                .HasColumnName("tel_cia");
            entity.Property(e => e.TipPagpen)
                .HasDefaultValueSql("((3))")
                .HasComment("Tipo de pagador de Pensiones")
                .HasColumnName("tip_pagpen");
        });

        modelBuilder.Entity<GenDepto>(entity =>
        {
            entity.HasKey(e => new { e.CodPai, e.CodDep }).IsClustered(false);

            entity.ToTable("gen_deptos", tb =>
                {
                    tb.HasTrigger("tr_gen_deptos");
                    tb.HasTrigger("tr_gen_deptos_upd_replicadatos");
                });

            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CodDep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Departamento")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodDepExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_dep_Extr");
            entity.Property(e => e.CodPaiExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_pai_Extr");
            entity.Property(e => e.IndActExtr)
                .HasComment("Indicador Actualización Sistema Externo")
                .HasColumnName("ind_act_Extr");
            entity.Property(e => e.IndPol)
                .HasComment("Ind politico")
                .HasColumnName("ind_pol");
            entity.Property(e => e.NomDep)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_dep");
            entity.Property(e => e.SiglaDep)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Sigla ACH")
                .HasColumnName("sigla_dep");

            entity.HasOne(d => d.CodPaiNavigation).WithMany(p => p.GenDeptos)
                .HasForeignKey(d => d.CodPai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gen_deptos_gen_paises");
        });

        modelBuilder.Entity<GenGrupoetnico>(entity =>
        {
            entity.HasKey(e => e.CodGrupo);

            entity.ToTable("gen_grupoetnico");

            entity.Property(e => e.CodGrupo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo Grupo Etnico")
                .HasColumnName("cod_grupo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasComment("Descripción Grupo Etnico")
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<GenMenuGral>(entity =>
        {
            entity.HasKey(e => new { e.CodApl, e.CodObj, e.CodGru, e.GruMenu, e.SecObj });

            entity.ToTable("gen_menu_gral");

            entity.Property(e => e.CodApl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_apl");
            entity.Property(e => e.CodObj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_obj");
            entity.Property(e => e.CodGru)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_gru");
            entity.Property(e => e.GruMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NOVASOFT')")
                .HasColumnName("gru_menu");
            entity.Property(e => e.SecObj)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('M')")
                .IsFixedLength()
                .HasColumnName("sec_obj");
            entity.Property(e => e.DesObj)
                .HasMaxLength(200)
                .HasColumnName("des_obj");
            entity.Property(e => e.IndEst)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ind_est");
            entity.Property(e => e.OrdObj).HasColumnName("ord_obj");
            entity.Property(e => e.RefObj)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ref_obj");
            entity.Property(e => e.TipObj)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tip_obj");

            entity.HasOne(d => d.CodAplNavigation).WithMany(p => p.GenMenuGrals)
                .HasForeignKey(d => d.CodApl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gen_menu_gral_sis_aplicacion");
        });

        modelBuilder.Entity<GenPaise>(entity =>
        {
            entity.HasKey(e => e.CodPai).IsClustered(false);

            entity.ToTable("gen_paises", tb =>
                {
                    tb.HasTrigger("tr_gen_paises");
                    tb.HasTrigger("tr_gen_paises_upd_replicadatos");
                });

            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CodDian)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código DIAN")
                .HasColumnName("cod_dian");
            entity.Property(e => e.CodIdioma)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Idioma País")
                .HasColumnName("cod_idioma");
            entity.Property(e => e.CodIso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código País ISO")
                .HasColumnName("cod_iso");
            entity.Property(e => e.CodPaiExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_pai_Extr");
            entity.Property(e => e.IndActExtr)
                .HasComment("Indicador Actualización Sistema Externo")
                .HasColumnName("ind_act_Extr");
            entity.Property(e => e.IndTel)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Indicativo Telefónico")
                .HasColumnName("ind_tel");
            entity.Property(e => e.NomPai)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_pai");
        });

        modelBuilder.Entity<GenSucursal>(entity =>
        {
            entity.HasKey(e => e.CodSuc).HasName("PK_gen_sucursal_1__21");

            entity.ToTable("gen_sucursal", tb => tb.HasTrigger("tr_gen_sucursal"));

            entity.Property(e => e.CodSuc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código sucursal")
                .HasColumnName("cod_suc");
            entity.Property(e => e.BodFact)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Bodega por Defecto de la Sucursal")
                .HasColumnName("bod_fact");
            entity.Property(e => e.CodBarrio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Codigo Barrio Sucursal")
                .HasColumnName("cod_barrio");
            entity.Property(e => e.CodCiu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código ciudad")
                .HasColumnName("cod_ciu");
            entity.Property(e => e.CodDep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código depto")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodIca)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Código de ICA")
                .HasColumnName("cod_ica");
            entity.Property(e => e.CodLocalidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Codigo Localidad Sucursal")
                .HasColumnName("cod_localidad");
            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código país")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CodSucExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_suc_Extr");
            entity.Property(e => e.DirSuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Dirección sucursal")
                .HasColumnName("dir_suc");
            entity.Property(e => e.EncSuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Encargado sucursal")
                .HasColumnName("enc_suc");
            entity.Property(e => e.EstSuc)
                .HasDefaultValueSql("((1))")
                .HasComment("Estado")
                .HasColumnName("est_suc");
            entity.Property(e => e.IndActExtr)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador Actualización sistema externo")
                .HasColumnName("ind_act_extr");
            entity.Property(e => e.IndExciva)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasComment("Indicador de Exención de IVA")
                .HasColumnName("ind_exciva");
            entity.Property(e => e.NomSuc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre sucursal")
                .HasColumnName("nom_suc");
            entity.Property(e => e.TarIca)
                .HasComment("% ICA Actividad Principal de la Ciudad de la Sucursal")
                .HasColumnType("money")
                .HasColumnName("tar_ica");
            entity.Property(e => e.TelSuc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Teléfono sucursal")
                .HasColumnName("tel_suc");

            entity.HasOne(d => d.Cod).WithMany(p => p.GenSucursals)
                .HasForeignKey(d => new { d.CodPai, d.CodDep, d.CodCiu })
                .HasConstraintName("FK_gen_sucursal_gen_ciudad");

            entity.HasOne(d => d.CodNavigation).WithMany(p => p.GenSucursals)
                .HasForeignKey(d => new { d.CodPai, d.CodDep, d.CodCiu, d.CodLocalidad, d.CodBarrio })
                .HasConstraintName("FK_gen_sucursal_gen_barrios");
        });

        modelBuilder.Entity<GenTipide>(entity =>
        {
            entity.HasKey(e => e.CodTip);

            entity.ToTable("gen_tipide");

            entity.Property(e => e.CodTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("cod_tip");
            entity.Property(e => e.CodDian)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Dian")
                .HasColumnName("cod_dian");
            entity.Property(e => e.CodSpv)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Superintendencia de Vigilancia")
                .HasColumnName("cod_spv");
            entity.Property(e => e.DesTip)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Descripción")
                .HasColumnName("des_tip");
            entity.Property(e => e.TipTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo")
                .HasColumnName("tip_tip");
        });

        modelBuilder.Entity<GthEstCivil>(entity =>
        {
            entity.HasKey(e => e.CodEst);

            entity.ToTable("GTH_EstCivil");

            entity.Property(e => e.CodEst)
                .ValueGeneratedNever()
                .HasComment("Estado Civil")
                .HasColumnName("cod_est");
            entity.Property(e => e.CodEstExtr)
                .HasMaxLength(20)
                .HasComment("Codigo Homologación para integraciones")
                .HasColumnName("cod_est_Extr");
            entity.Property(e => e.DesEst)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Descripción")
                .HasColumnName("des_est");
        });

        modelBuilder.Entity<GthGenero>(entity =>
        {
            entity.HasKey(e => e.CodGen);

            entity.ToTable("GTH_Genero");

            entity.Property(e => e.CodGen)
                .ValueGeneratedNever()
                .HasComment("Género")
                .HasColumnName("cod_gen");
            entity.Property(e => e.CodGenExtr)
                .HasMaxLength(20)
                .HasComment("Codigo Homologación para integraciones")
                .HasColumnName("cod_gen_Extr");
            entity.Property(e => e.DesGen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Descripción")
                .HasColumnName("des_gen");
        });

        modelBuilder.Entity<GthRptEstado>(entity =>
        {
            entity.HasKey(e => e.CodEst);

            entity.ToTable("GTH_RptEstado");

            entity.Property(e => e.CodEst)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Estado Hoja de Vida")
                .HasColumnName("cod_est");
            entity.Property(e => e.DescEst)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Estado Hoja de Vida")
                .HasColumnName("desc_est");
        });

        modelBuilder.Entity<RhhCargo>(entity =>
        {
            entity.HasKey(e => e.CodCar)
                .HasName("PK_rhh_cargos_1__14")
                .IsClustered(false);

            entity.ToTable("rhh_cargos", tb =>
                {
                    tb.HasTrigger("tr_rhh_Cargos_Competencias");
                    tb.HasTrigger("tr_rhh_Cargos_Ins_Up_Del");
                    tb.HasTrigger("tr_rhh_cargos_Hcm");
                    tb.HasTrigger("tr_rhh_cargos_ins_empleo");
                    tb.HasTrigger("trg_rhh_ReplicaCargoAut");
                });

            entity.Property(e => e.CodCar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo")
                .HasColumnName("cod_car");
            entity.Property(e => e.Atrib)
                .HasComment("atrib")
                .HasColumnName("atrib");
            entity.Property(e => e.CarCia)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Cargo de la entidad")
                .HasColumnName("car_cia");
            entity.Property(e => e.CarCop)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Cargo Copiado")
                .HasColumnName("car_cop");
            entity.Property(e => e.CarSup)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cargo Superior")
                .HasColumnName("car_sup");
            entity.Property(e => e.CnoDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('00')")
                .IsFixedLength()
                .HasComment("CNO Detallado")
                .HasColumnName("CNO_Det");
            entity.Property(e => e.CodActSecEc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Ecuador-Actividad Sectorial .")
                .HasColumnName("Cod_ActSec_ec");
            entity.Property(e => e.CodAreaCno)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('00')")
                .IsFixedLength()
                .HasComment("Area Desempeño CNO")
                .HasColumnName("cod_areaCNO");
            entity.Property(e => e.CodCarExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_car_Extr");
            entity.Property(e => e.CodCatCar)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Categoría de Cargo")
                .HasColumnName("cod_cat_car");
            entity.Property(e => e.CodCia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Cod Compañia")
                .HasColumnName("cod_cia");
            entity.Property(e => e.CodCiaExtr)
                .HasMaxLength(20)
                .HasComment("Codigo Compañía Cliente Externo")
                .HasColumnName("cod_cia_Extr");
            entity.Property(e => e.CodCiuo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('00')")
                .IsFixedLength()
                .HasComment("Código CIUO")
                .HasColumnName("Cod_CIUO");
            entity.Property(e => e.CodCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasColumnName("cod_cli");
            entity.Property(e => e.CodConv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasComment("Cod Convenio")
                .HasColumnName("cod_conv");
            entity.Property(e => e.CodCritico)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Crítico")
                .HasColumnName("cod_critico");
            entity.Property(e => e.CodEmpleo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasColumnName("Cod_empleo");
            entity.Property(e => e.CodEstrucCargo)
                .HasComment("Codigo Estructura de Cargo Cliente Externo")
                .HasColumnName("cod_estrucCargo");
            entity.Property(e => e.CodGra)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Grado")
                .HasColumnName("cod_gra");
            entity.Property(e => e.CodGruCiuo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('00')")
                .IsFixedLength()
                .HasComment("Grupo CIUO")
                .HasColumnName("cod_gru_CIUO");
            entity.Property(e => e.CodIessEc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Ecuador-Codigo IESS Actividad Sectorial")
                .HasColumnName("Cod_Iess_ec");
            entity.Property(e => e.CodNivelCno)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Nivel Preparación CNO")
                .HasColumnName("cod_nivelCNO");
            entity.Property(e => e.DesCar)
                .IsUnicode(false)
                .HasComment("Descripción")
                .HasColumnName("des_car");
            entity.Property(e => e.FuncCar)
                .HasComment("Funciones del Cargo")
                .HasColumnName("func_car");
            entity.Property(e => e.IndActExtr)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador Actualización Sistema Externo")
                .HasColumnName("ind_act_Extr");
            entity.Property(e => e.NivAca)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nivel Académico")
                .HasColumnName("niv_aca");
            entity.Property(e => e.NivCar)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Nivel del cargo")
                .HasColumnName("niv_car");
            entity.Property(e => e.NomCar)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Nombre")
                .HasColumnName("nom_car");
            entity.Property(e => e.ObjCar)
                .HasComment("Objetivos Cargo")
                .HasColumnName("obj_car");
            entity.Property(e => e.RamaActsecEc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Ecuador-Actividad Sectorial")
                .HasColumnName("Rama_actsec_EC");
            entity.Property(e => e.RespCar)
                .HasComment("Responsabilidades del Cargo")
                .HasColumnName("resp_car");
            entity.Property(e => e.SalBas)
                .HasComment("Salario")
                .HasColumnType("money")
                .HasColumnName("sal_bas");

            entity.HasOne(d => d.CarSupNavigation).WithMany(p => p.InverseCarSupNavigation)
                .HasForeignKey(d => d.CarSup)
                .HasConstraintName("FK_rhh_cargos_rhh_cargos");

            entity.HasOne(d => d.CodCiaNavigation).WithMany(p => p.RhhCargos)
                .HasForeignKey(d => d.CodCia)
                .HasConstraintName("FK_rhh_cargos_gen_compania");

            entity.HasOne(d => d.NivAcaNavigation).WithMany(p => p.RhhCargos)
                .HasForeignKey(d => d.NivAca)
                .HasConstraintName("FK_rhh_cargos_rhh_tbclaest");
        });

        modelBuilder.Entity<RhhEmplea>(entity =>
        {
            entity.HasKey(e => e.CodEmp).HasName("COD_EMP");

            entity.ToTable("rhh_emplea", tb =>
                {
                    tb.HasComment("Maestra de Empleados");
                    tb.HasTrigger("TR_RHH_EMPLEA");
                    tb.HasTrigger("TR_RHH_EMPLEA_GTH");
                    tb.HasTrigger("TR_RHH_EMP_HISFON_EC");
                    tb.HasTrigger("TR_RHH_EMP_PORTAL");
                });

            entity.HasIndex(e => e.IdUniq, "UQ__rhh_empl__D01F3DE5707EE47C").IsUnique();

            entity.HasIndex(e => e.CodEmp, "_Nova_index_rhh_emplea_cod_emp");

            entity.HasIndex(e => e.CiuExp, "ciu_exp").HasFillFactor(90);

            entity.HasIndex(e => e.CiuRes, "ciu_res").HasFillFactor(90);

            entity.HasIndex(e => e.CodBan, "cod_ban").HasFillFactor(90);

            entity.HasIndex(e => e.CodCar, "cod_car").HasFillFactor(90);

            entity.HasIndex(e => e.CodCco, "cod_cco").HasFillFactor(90);

            entity.HasIndex(e => e.CodSuc, "cod_cia").HasFillFactor(90);

            entity.HasIndex(e => e.CodCiu, "cod_ciu").HasFillFactor(90);

            entity.HasIndex(e => e.CodDep, "cod_dep").HasFillFactor(90);

            entity.HasIndex(e => e.CodCl1, "cod_des").HasFillFactor(90);

            entity.HasIndex(e => e.CodPai, "cod_pai").HasFillFactor(90);

            entity.HasIndex(e => e.CodTlq, "cod_tlq").HasFillFactor(90);

            entity.HasIndex(e => e.DptRes, "dpt_res").HasFillFactor(90);

            entity.HasIndex(e => e.PaiExp, "pai_exp").HasFillFactor(90);

            entity.Property(e => e.CodEmp)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código empleado")
                .HasColumnName("cod_emp");
            entity.Property(e => e.Ap1Emp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Apellido1")
                .HasColumnName("ap1_emp");
            entity.Property(e => e.Ap2Emp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasComment("Apellido2")
                .HasColumnName("ap2_emp");
            entity.Property(e => e.ApoPen)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Ind  aporta pensión")
                .HasColumnName("apo_pen");
            entity.Property(e => e.ApoRie)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Ind  aporta riesgos")
                .HasColumnName("apo_rie");
            entity.Property(e => e.ApoSal)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Ind  aporta salud")
                .HasColumnName("apo_sal");
            entity.Property(e => e.AspSal)
                .HasComment("Aspiración Salarial")
                .HasColumnType("money")
                .HasColumnName("asp_sal");
            entity.Property(e => e.AutDat)
                .HasDefaultValueSql("((3))")
                .HasColumnName("Aut_Dat");
            entity.Property(e => e.AviEmp)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Avisar a")
                .HasColumnName("avi_emp");
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Barrio Residencia")
                .HasColumnName("barrio");
            entity.Property(e => e.CalSer)
                .HasDefaultValueSql("((0))")
                .HasComment("Calif servicio1")
                .HasColumnType("money")
                .HasColumnName("cal_ser");
            entity.Property(e => e.CalSv2)
                .HasComment("Calif servicio2")
                .HasColumnType("money")
                .HasColumnName("cal_sv2");
            entity.Property(e => e.CalSv3)
                .HasComment("Calif servicio3")
                .HasColumnType("money")
                .HasColumnName("cal_sv3");
            entity.Property(e => e.CalSv4)
                .HasComment("Calif servicio4")
                .HasColumnType("money")
                .HasColumnName("cal_sv4");
            entity.Property(e => e.CarEnc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasComment("Cargo - encargo")
                .HasColumnName("car_enc");
            entity.Property(e => e.CatCar)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Categoria cargo")
                .HasColumnName("cat_car");
            entity.Property(e => e.CauPen)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Causa pension")
                .HasColumnName("cau_pen");
            entity.Property(e => e.CcfEmp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Fondo caja compen.")
                .HasColumnName("ccf_emp");
            entity.Property(e => e.CiuExp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Ciudad expedicion")
                .HasColumnName("ciu_exp");
            entity.Property(e => e.CiuRes)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Ciudad reside")
                .HasColumnName("ciu_res");
            entity.Property(e => e.ClaLib)
                .HasComment("Clase Libreta Militar")
                .HasColumnName("cla_lib");
            entity.Property(e => e.ClaSal)
                .HasComment("Clase salario")
                .HasColumnName("cla_sal");
            entity.Property(e => e.ClasifCat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Clasif. categoria")
                .HasColumnName("clasif_cat");
            entity.Property(e => e.CodBan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo banco")
                .HasColumnName("cod_ban");
            entity.Property(e => e.CodBarrio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Codigo Barrio Empleado")
                .HasColumnName("cod_barrio");
            entity.Property(e => e.CodCar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo cargo")
                .HasColumnName("cod_car");
            entity.Property(e => e.CodCco)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Centro de costo")
                .HasColumnName("cod_cco");
            entity.Property(e => e.CodCia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Compañia")
                .HasColumnName("cod_cia");
            entity.Property(e => e.CodCiu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Ciudad")
                .HasColumnName("cod_ciu");
            entity.Property(e => e.CodCl1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("Clasificacion 1")
                .HasColumnName("cod_cl1");
            entity.Property(e => e.CodCl2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Clasificación 2")
                .HasColumnName("cod_cl2");
            entity.Property(e => e.CodCl3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Clasificación 3")
                .HasColumnName("cod_cl3");
            entity.Property(e => e.CodCl4)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("cod_cl4                  ")
                .HasColumnName("cod_cl4");
            entity.Property(e => e.CodCl5)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("cod_cl5                  ")
                .HasColumnName("cod_cl5");
            entity.Property(e => e.CodCl6)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("cod_cl6                  ")
                .HasColumnName("cod_cl6");
            entity.Property(e => e.CodCl7)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("cod_cl7                  ")
                .HasColumnName("cod_cl7");
            entity.Property(e => e.CodDep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Depto")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodEmpExtr)
                .HasMaxLength(20)
                .HasComment("Campo llave de homologación para el sistema externo")
                .HasColumnName("cod_emp_Extr");
            entity.Property(e => e.CodEst)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('04')")
                .IsFixedLength()
                .HasColumnName("cod_est");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('09')")
                .IsFixedLength()
                .HasComment("Grupo Étnico")
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodLocalidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Codigo Localidad Empleado")
                .HasColumnName("cod_localidad");
            entity.Property(e => e.CodPagelec)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Codigo Pago Electronico")
                .HasColumnName("cod_pagelec");
            entity.Property(e => e.CodPai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais")
                .HasColumnName("cod_pai");
            entity.Property(e => e.CodPaiEmisorPsp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("Emisor Pasaporte")
                .HasColumnName("cod_pai_emisor_psp");
            entity.Property(e => e.CodRanvac)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Rango de vacaciones")
                .HasColumnName("cod_ranvac");
            entity.Property(e => e.CodReloj)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("cod_reloj                ")
                .HasColumnName("cod_reloj");
            entity.Property(e => e.CodSuc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Sucursal")
                .HasColumnName("cod_suc");
            entity.Property(e => e.CodTlq)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo de liquidacion")
                .HasColumnName("cod_tlq");
            entity.Property(e => e.ConceptoDian2280)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasComment("Tipo Medidas Certificadas Formato 2280 DIAN")
                .HasColumnName("Concepto_DIAN2280");
            entity.Property(e => e.CptoDeudas)
                .HasComment("Detalle de las Deudas")
                .HasColumnName("cpto_Deudas");
            entity.Property(e => e.CtaBan)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cuenta corriente")
                .HasColumnName("cta_ban");
            entity.Property(e => e.CtaGas)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Grupo contable")
                .HasColumnName("cta_gas");
            entity.Property(e => e.CtaGasnif)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cuenta Gasto Niif.")
                .HasColumnName("cta_gasnif");
            entity.Property(e => e.DedHoras)
                .HasDefaultValueSql("((0))")
                .HasComment("Ded. horas")
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ded_horas");
            entity.Property(e => e.DedTrabAntEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-deducibles trabajo anterior.")
                .HasColumnType("money")
                .HasColumnName("ded_trab_ant_ec");
            entity.Property(e => e.DedrentaEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Deducible de Renta.")
                .HasColumnType("money")
                .HasColumnName("dedrenta_ec");
            entity.Property(e => e.Deudas)
                .HasDefaultValueSql("((0))")
                .HasComment("Tiene Deudas")
                .HasColumnName("deudas");
            entity.Property(e => e.DiaTraAntEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador- Dias Trabajo anterior.")
                .HasColumnName("Dia_Tra_Ant_ec");
            entity.Property(e => e.DiaVac)
                .HasDefaultValueSql("((0))")
                .HasComment("Dias vacaciones")
                .HasColumnName("dia_vac");
            entity.Property(e => e.DimLib)
                .HasComment("Distrito militar")
                .HasColumnName("dim_lib");
            entity.Property(e => e.DirRes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Dir. Residencia")
                .HasColumnName("dir_res");
            entity.Property(e => e.DispAsp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Disponibilidad del Aspirante")
                .HasColumnName("disp_asp");
            entity.Property(e => e.DptExp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Departamento Expedición Doc Id")
                .HasColumnName("dpt_exp");
            entity.Property(e => e.DptRes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Depto reside")
                .HasColumnName("dpt_res");
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Correo Electrónico")
                .HasColumnName("e_mail");
            entity.Property(e => e.EMailAlt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Correo Alterno")
                .HasColumnName("e_mail_alt");
            entity.Property(e => e.EmpPen)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Entidad de pension")
                .HasColumnName("emp_pen");
            entity.Property(e => e.EstCiv)
                .HasDefaultValueSql("((2))")
                .HasComment("Estado civil")
                .HasColumnName("est_civ");
            entity.Property(e => e.EstLab)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('00')")
                .IsFixedLength()
                .HasComment("Estado laboral")
                .HasColumnName("est_lab");
            entity.Property(e => e.EstSoc)
                .HasComment("Estrato Social")
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("est_soc");
            entity.Property(e => e.ExoTeredadEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-exoneracion por tercera edad.")
                .HasColumnName("Exo_teredad_ec");
            entity.Property(e => e.FacRhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('+')")
                .IsFixedLength()
                .HasComment("Factor Rh")
                .HasColumnName("fac_rhh");
            entity.Property(e => e.FdoAte)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Fondo atep")
                .HasColumnName("fdo_ate");
            entity.Property(e => e.FdoCes)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Fondo cesantia")
                .HasColumnName("fdo_ces");
            entity.Property(e => e.FdoPen)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Fondo pension")
                .HasColumnName("fdo_pen");
            entity.Property(e => e.FdoSal)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Fondo salud")
                .HasColumnName("fdo_sal");
            entity.Property(e => e.FecAum)
                .HasComment("Fecha ult aumento")
                .HasColumnType("datetime")
                .HasColumnName("fec_aum");
            entity.Property(e => e.FecAut)
                .HasColumnType("datetime")
                .HasColumnName("Fec_Aut");
            entity.Property(e => e.FecBon)
                .HasComment("Fecha bonificación")
                .HasColumnType("datetime")
                .HasColumnName("fec_bon");
            entity.Property(e => e.FecCar)
                .HasComment("Fecha cargo")
                .HasColumnType("datetime")
                .HasColumnName("fec_car");
            entity.Property(e => e.FecEgr)
                .HasComment("Fecha de retiro")
                .HasColumnType("datetime")
                .HasColumnName("fec_egr");
            entity.Property(e => e.FecExpPsp)
                .HasComment("Fecha Expedición Pasaporte")
                .HasColumnType("datetime")
                .HasColumnName("fec_exp_psp");
            entity.Property(e => e.FecExpdoc)
                .HasComment("Fecha Expedicion Doc. Identidad")
                .HasColumnType("datetime")
                .HasColumnName("fec_expdoc");
            entity.Property(e => e.FecIng)
                .HasComment("Fecha ingreso")
                .HasColumnType("datetime")
                .HasColumnName("fec_ing");
            entity.Property(e => e.FecNac)
                .HasComment("Fec. nacim")
                .HasColumnType("datetime")
                .HasColumnName("fec_nac");
            entity.Property(e => e.FecPriming)
                .HasComment("Fecha Primer Ingreso - Certificados Laborales")
                .HasColumnType("datetime")
                .HasColumnName("fec_priming");
            entity.Property(e => e.FecUltAct)
                .HasColumnType("datetime")
                .HasColumnName("fec_ult_act");
            entity.Property(e => e.FecVencPsp)
                .HasComment("Fecha Vencimiento Pasaporte")
                .HasColumnType("datetime")
                .HasColumnName("fec_venc_psp");
            entity.Property(e => e.FtoEmp)
                .HasComment("Foto Empleado")
                .HasColumnName("fto_emp");
            entity.Property(e => e.GasMen)
                .HasDefaultValueSql("((0))")
                .HasComment("Gastos")
                .HasColumnType("money")
                .HasColumnName("gas_men");
            entity.Property(e => e.GradodiscEc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Ecuador: Grado Discapacidad")
                .HasColumnName("gradodisc_ec");
            entity.Property(e => e.GruSan)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Grupo Sanguíneo")
                .HasColumnName("gru_san");
            entity.Property(e => e.HorasMes)
                .HasComment("horas_mes                ")
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("horas_mes");
            entity.Property(e => e.IdUniq)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_uniq");
            entity.Property(e => e.IndActExtr)
                .HasComment("Indicador actuaizaci�n Sistema externo")
                .HasColumnName("ind_act_Extr");
            entity.Property(e => e.IndCabFam)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador Cabeza de Familia")
                .HasColumnName("ind_cab_fam");
            entity.Property(e => e.IndCtt)
                .HasComment("Indicador Contratista")
                .HasColumnName("ind_ctt");
            entity.Property(e => e.IndDecRenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Indicador Declarante Renta")
                .HasColumnName("ind_DecRenta");
            entity.Property(e => e.IndDiscco)
                .HasComment("Distribucion Ccosto")
                .HasColumnName("ind_discco");
            entity.Property(e => e.IndDiscconif)
                .HasComment("Indicador Distibucion centro de costo Niif.")
                .HasColumnName("ind_discconif");
            entity.Property(e => e.IndEmbz)
                .HasComment("Ind Embarazo")
                .HasColumnName("ind_Embz");
            entity.Property(e => e.IndEmpleapenEmp)
                .HasComment("Indicador Empleado Pensionado por la Empresa")
                .HasColumnName("ind_EmpleapenEmp");
            entity.Property(e => e.IndEstlabref)
                .HasComment("Estabilidad laboral Reforzada")
                .HasColumnName("ind_estlabref");
            entity.Property(e => e.IndEvalua)
                .HasComment("Ind. de Evaluador")
                .HasColumnName("ind_evalua");
            entity.Property(e => e.IndExodiscEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Exoneracion por discapacidad.")
                .HasColumnName("ind_exodisc_ec");
            entity.Property(e => e.IndExtjero)
                .HasComment("Extranjero")
                .HasColumnName("ind_extjero");
            entity.Property(e => e.IndExtranjero)
                .HasComment("Indicador de Extranjero")
                .HasColumnName("ind_extranjero");
            entity.Property(e => e.IndIncPm)
                .HasComment("Ind Incapacidad Permanente")
                .HasColumnName("ind_IncPm");
            entity.Property(e => e.IndInclUtilEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Aplica Utilidades .")
                .HasColumnName("ind_incl_util_ec");
            entity.Property(e => e.IndLider)
                .HasDefaultValueSql("((0))")
                .HasComment("Líder GH/Portal?")
                .HasColumnName("ind_lider");
            entity.Property(e => e.IndM31)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador mes 31")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("ind_m31");
            entity.Property(e => e.IndMascota)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador Tiene Mascota")
                .HasColumnName("ind_mascota");
            entity.Property(e => e.IndMesdecterEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Aplica Decimo Tercera .")
                .HasColumnName("ind_mesdecter_ec");
            entity.Property(e => e.IndMesdecuaEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Aplica Decimo Cuarta .")
                .HasColumnName("ind_mesdecua_ec");
            entity.Property(e => e.IndPagFdrEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Fondo de Reserva.")
                .HasColumnName("ind_pag_fdr_ec");
            entity.Property(e => e.IndPdias)
                .HasComment("Ind. pago de dias")
                .HasColumnName("ind_pdias");
            entity.Property(e => e.IndPencomp)
                .HasComment("Pensión Compartida")
                .HasColumnName("ind_pencomp");
            entity.Property(e => e.IndPenpagext)
                .HasComment("Indicado Pago Pension en Exterior")
                .HasColumnName("ind_penpagext");
            entity.Property(e => e.IndPrepens)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador Prepensionado")
                .HasColumnName("ind_prepens");
            entity.Property(e => e.IndPva)
                .HasDefaultValueSql("((1))")
                .HasComment("Prima de Vacaciones")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("ind_pva");
            entity.Property(e => e.IndResiExtjero)
                .HasComment("Reside en el Extranjero")
                .HasColumnName("ind_resi_extjero");
            entity.Property(e => e.IndSab)
                .HasDefaultValueSql("((0))")
                .HasComment("Indicador sabado")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("ind_sab");
            entity.Property(e => e.IndSvar)
                .HasDefaultValueSql("((0))")
                .HasComment("Ind salario variable")
                .HasColumnName("ind_svar");
            entity.Property(e => e.IndVac)
                .HasComment("Indicador vacaciones")
                .HasColumnName("ind_vac");
            entity.Property(e => e.LoginPortal)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("login_portal");
            entity.Property(e => e.MetRet)
                .HasComment("Metodo retencion")
                .HasColumnName("met_ret");
            entity.Property(e => e.MetTpt)
                .HasComment("met_tpt                  ")
                .HasColumnName("met_tpt");
            entity.Property(e => e.ModLiq)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("mod_liq                  ")
                .HasColumnName("mod_liq");
            entity.Property(e => e.MtoDto)
                .HasDefaultValueSql("((0))")
                .HasComment("Descuento")
                .HasColumnType("money")
                .HasColumnName("mto_dto");
            entity.Property(e => e.MtoDtoNa)
                .HasComment("Valor Deducible No Aplicado")
                .HasColumnType("money")
                .HasColumnName("mto_dtoNA");
            entity.Property(e => e.NacEmp)
                .HasDefaultValueSql("((1))")
                .HasComment("Nacionalidad")
                .HasColumnName("nac_emp");
            entity.Property(e => e.NivAca)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Nivel Académico")
                .HasColumnName("Niv_aca");
            entity.Property(e => e.NivOcu)
                .HasComment("Nivel")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("niv_ocu");
            entity.Property(e => e.Nom1Emp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("Primer Nombre")
                .HasColumnName("nom1_emp");
            entity.Property(e => e.Nom2Emp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("Segundo Nombre")
                .HasColumnName("nom2_emp");
            entity.Property(e => e.NomEmp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombres")
                .HasColumnName("nom_emp");
            entity.Property(e => e.NomRem)
                .HasComment("Nombre")
                .HasColumnName("nom_rem");
            entity.Property(e => e.NroCalleEc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Ecuador-Numer ode Calle.")
                .HasColumnName("Nro_Calle_ec");
            entity.Property(e => e.NroPsp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("Nro Pasaporte")
                .HasColumnName("nro_psp");
            entity.Property(e => e.NumIde)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("Número de Identificación")
                .HasColumnName("num_ide");
            entity.Property(e => e.NumLib)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Número libreta")
                .HasColumnName("num_lib");
            entity.Property(e => e.NumReq).HasColumnName("num_req");
            entity.Property(e => e.PaiExp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais expedicion")
                .HasColumnName("pai_exp");
            entity.Property(e => e.PaiRes)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais reside")
                .HasColumnName("pai_res");
            entity.Property(e => e.PenEmp)
                .HasDefaultValueSql("((0))")
                .HasComment("Emp. pensionado")
                .HasColumnName("pen_emp");
            entity.Property(e => e.PerBeb)
                .HasComment("Periodicidad Bebidas Alcoholicas")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("per_beb");
            entity.Property(e => e.PerCar)
                .HasDefaultValueSql("((0))")
                .HasComment("Personas a cargo")
                .HasColumnName("per_car");
            entity.Property(e => e.PesEmp)
                .HasComment("Peso")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("pes_emp");
            entity.Property(e => e.PjeSue)
                .HasDefaultValueSql("((0))")
                .HasComment("% sueldo")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("pje_sue");
            entity.Property(e => e.PorAte)
                .HasComment("% atep")
                .HasColumnType("numeric(9, 4)")
                .HasColumnName("por_ate");
            entity.Property(e => e.PorRet)
                .HasDefaultValueSql("((0))")
                .HasComment("% retención")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("por_ret");
            entity.Property(e => e.PrmSal)
                .HasComment("Promedio de Salud")
                .HasColumnType("money")
                .HasColumnName("prm_sal");
            entity.Property(e => e.ProFum)
                .HasComment("Promedio Cigarrillos")
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("pro_fum");
            entity.Property(e => e.PtoGas)
                .HasDefaultValueSql("((0))")
                .HasComment("Presupuesto Mensual de Gastos")
                .HasColumnType("money")
                .HasColumnName("pto_gas");
            entity.Property(e => e.RebTrabAntEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Rebajas trabajo anterior.")
                .HasColumnType("money")
                .HasColumnName("reb_trab_ant_ec");
            entity.Property(e => e.RegPres)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("reg_pres                 ")
                .HasColumnName("reg_pres");
            entity.Property(e => e.RegSal)
                .HasComment("Regimen salarial")
                .HasColumnName("reg_sal");
            entity.Property(e => e.RegionEc)
                .HasDefaultValueSql("('')")
                .HasComment("Ecuador-Region.")
                .HasColumnName("region_ec");
            entity.Property(e => e.RetTrabAntEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-REtencion Trabajo anterior .")
                .HasColumnType("money")
                .HasColumnName("ret_trab_ant_ec");
            entity.Property(e => e.SalAnt)
                .HasDefaultValueSql("((0))")
                .HasComment("Salario anterior")
                .HasColumnType("money")
                .HasColumnName("sal_ant");
            entity.Property(e => e.SalBas)
                .HasComment("Salario básico")
                .HasColumnType("money")
                .HasColumnName("sal_bas");
            entity.Property(e => e.SalTrabAntEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Salario Trabajo anterior.")
                .HasColumnType("money")
                .HasColumnName("sal_trab_ant_ec");
            entity.Property(e => e.SexEmp)
                .HasDefaultValueSql("((1))")
                .HasComment("Género")
                .HasColumnName("sex_emp");
            entity.Property(e => e.SubTipCot)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Sub tipo de Cotizante")
                .HasColumnName("SubTip_Cot");
            entity.Property(e => e.SucBan)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Sucursal Banco")
                .HasColumnName("suc_ban");
            entity.Property(e => e.SueVar)
                .HasDefaultValueSql("((0))")
                .HasComment("Sueldo variable")
                .HasColumnType("money")
                .HasColumnName("sue_var");
            entity.Property(e => e.TamEmp)
                .HasComment("Estatura")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("tam_emp");
            entity.Property(e => e.TelCel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Teléfono Celular")
                .HasColumnName("tel_cel");
            entity.Property(e => e.TelRes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Teléfono Fijo")
                .HasColumnName("tel_res");
            entity.Property(e => e.TipCon)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo contrato")
                .HasColumnName("tip_con");
            entity.Property(e => e.TipCot)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('01')")
                .IsFixedLength()
                .HasComment("tip_cot                  ")
                .HasColumnName("tip_cot");
            entity.Property(e => e.TipDed)
                .HasDefaultValueSql("((0))")
                .HasComment("Tipo deducible")
                .HasColumnName("tip_ded");
            entity.Property(e => e.TipIde)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('01')")
                .IsFixedLength()
                .HasComment("Tipo identificacion")
                .HasColumnName("tip_ide");
            entity.Property(e => e.TipNom)
                .HasDefaultValueSql("((0))")
                .HasComment("Tipo nómina")
                .HasColumnName("tip_nom");
            entity.Property(e => e.TipPag)
                .HasComment("Tipo pago")
                .HasColumnName("tip_pag");
            entity.Property(e => e.TipPen)
                .HasComment("Tipo de Pensionado ")
                .HasColumnName("tip_pen");
            entity.Property(e => e.TipSindclzdo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Tipo Sindicalización")
                .HasColumnName("Tip_sindclzdo");
            entity.Property(e => e.TipVincDian)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('01')")
                .IsFixedLength()
                .HasComment("Tipo Vinculacion DIAN")
                .HasColumnName("Tip_VincDian");
            entity.Property(e => e.TipVivEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Tipo de vivienda.")
                .HasColumnName("tip_viv_ec");
            entity.Property(e => e.TotHor)
                .HasComment("tot_hor                  ")
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("tot_hor");
            entity.Property(e => e.ValHora)
                .HasDefaultValueSql("((0))")
                .HasComment("Valor hora")
                .HasColumnType("money")
                .HasColumnName("val_hora");

            entity.HasOne(d => d.CcfEmpNavigation).WithMany(p => p.RhhEmpleaCcfEmpNavigations)
                .HasForeignKey(d => d.CcfEmp)
                .HasConstraintName("FK_rhh_emplea_rhh_tbfondos4");

            entity.HasOne(d => d.CodBanNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodBan)
                .HasConstraintName("FK_rhh_emplea_gen_bancos");

            entity.HasOne(d => d.CodCarNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCar)
                .HasConstraintName("FK_rhh_emplea_rhh_cargos");

            entity.HasOne(d => d.CodCcoNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCco)
                .HasConstraintName("FK_rhh_emplea_gen_ccosto");

            entity.HasOne(d => d.CodCiaNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCia)
                .HasConstraintName("FK_rhh_emplea_gen_compania");

            entity.HasOne(d => d.CodCl1Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl1)
                .HasConstraintName("FK_rhh_emplea_gen_clasif1");

            entity.HasOne(d => d.CodCl2Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl2)
                .HasConstraintName("FK_rhh_emplea_gen_clasif2");

            entity.HasOne(d => d.CodCl3Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl3)
                .HasConstraintName("FK_rhh_emplea_gen_clasif3");

            entity.HasOne(d => d.CodCl4Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl4)
                .HasConstraintName("FK_rhh_emplea_gen_clasif4");

            entity.HasOne(d => d.CodCl5Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl5)
                .HasConstraintName("FK_rhh_emplea_gen_clasif5");

            entity.HasOne(d => d.CodCl6Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl6)
                .HasConstraintName("FK_rhh_emplea_gen_clasif6");

            entity.HasOne(d => d.CodCl7Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodCl7)
                .HasConstraintName("FK_rhh_emplea_gen_clasif7");

            entity.HasOne(d => d.CodEstNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodEst)
                .HasConstraintName("FK_rhh_emplea_GTH_RptEstado");

            entity.HasOne(d => d.CodGrupoNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodGrupo)
                .HasConstraintName("FK_rhh_emplea_gen_grupoetnico");

            entity.HasOne(d => d.CodRanvacNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodRanvac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_Rhh_RanVac");

            entity.HasOne(d => d.CodSucNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodSuc)
                .HasConstraintName("FK_rhh_emplea_gen_sucursal");

            entity.HasOne(d => d.CodTlqNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.CodTlq)
                .HasConstraintName("FK_rhh_emplea_rhh_tipoliq");

            entity.HasOne(d => d.ConceptoDian2280Navigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.ConceptoDian2280)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_rhh_tbmedidaDian2280");

            entity.HasOne(d => d.EstLabNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.EstLab)
                .HasConstraintName("FK_rhh_emplea_rhh_tbestlab");

            entity.HasOne(d => d.FdoAteNavigation).WithMany(p => p.RhhEmpleaFdoAteNavigations)
                .HasForeignKey(d => d.FdoAte)
                .HasConstraintName("FK_rhh_emplea_rhh_tbfondos1");

            entity.HasOne(d => d.FdoCesNavigation).WithMany(p => p.RhhEmpleaFdoCesNavigations)
                .HasForeignKey(d => d.FdoCes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_rhh_tbfondos3");

            entity.HasOne(d => d.FdoPenNavigation).WithMany(p => p.RhhEmpleaFdoPenNavigations)
                .HasForeignKey(d => d.FdoPen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_rhh_tbfondos");

            entity.HasOne(d => d.FdoSalNavigation).WithMany(p => p.RhhEmpleaFdoSalNavigations)
                .HasForeignKey(d => d.FdoSal)
                .HasConstraintName("FK_rhh_emplea_rhh_tbfondos2");

            entity.HasOne(d => d.NivAcaNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.NivAca)
                .HasConstraintName("FK_rhh_emplea_rhh_tbclaest");

            entity.HasOne(d => d.PenEmpNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.PenEmp)
                .HasConstraintName("FK_rhh_emplea_rhh_tbemppen");

            entity.HasOne(d => d.SubTipCotNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.SubTipCot)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_Rhh_TbSubTipCotiza");

            entity.HasOne(d => d.TipIdeNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.TipIde)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_gen_tipide");

            entity.HasOne(d => d.TipPagNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.TipPag)
                .HasConstraintName("FK_rhh_emplea_rhh_tbTipPag");

            entity.HasOne(d => d.TipPenNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.TipPen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_rhh_tbtippen");

            entity.HasOne(d => d.TipSindclzdoNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.TipSindclzdo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_rhh_tbsindicalizdo");

            entity.HasOne(d => d.TipVincDianNavigation).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => d.TipVincDian)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_emplea_rhh_tbtipvinculacion");

            entity.HasOne(d => d.Cod).WithMany(p => p.RhhEmpleaCods)
                .HasForeignKey(d => new { d.CodPai, d.CodDep, d.CodCiu })
                .HasConstraintName("FK_rhh_emplea_gen_ciudad_Nac");

            entity.HasOne(d => d.GenCiudad).WithMany(p => p.RhhEmpleaGenCiudads)
                .HasForeignKey(d => new { d.PaiExp, d.DptExp, d.CiuExp })
                .HasConstraintName("FK_rhh_emplea_gen_ciudad_Iden");

            entity.HasOne(d => d.GenCiudadNavigation).WithMany(p => p.RhhEmpleaGenCiudadNavigations)
                .HasForeignKey(d => new { d.PaiRes, d.DptRes, d.CiuRes })
                .HasConstraintName("FK_rhh_emplea_gen_ciudad_Res");

            entity.HasOne(d => d.GenBarrio).WithMany(p => p.RhhEmpleas)
                .HasForeignKey(d => new { d.PaiRes, d.DptRes, d.CiuRes, d.CodLocalidad, d.CodBarrio })
                .HasConstraintName("FK_rhh_emplea_gen_barrios");
        });

        modelBuilder.Entity<RhhRanVac>(entity =>
        {
            entity.HasKey(e => e.CodRanVac);

            entity.ToTable("Rhh_RanVac");

            entity.Property(e => e.CodRanVac)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código Rango para Dias Adicionales en Vacaciones")
                .HasColumnName("Cod_RanVac");
            entity.Property(e => e.DesRanVac)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("Descripción Rango para Dias Adicionales en Vacaciones")
                .HasColumnName("Des_RanVac");
        });

        modelBuilder.Entity<RhhTbSubTipCotiza>(entity =>
        {
            entity.HasKey(e => e.SubTipCot);

            entity.ToTable("Rhh_TbSubTipCotiza");

            entity.Property(e => e.SubTipCot)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Subtipo Cotizante")
                .HasColumnName("SubTip_Cot");
            entity.Property(e => e.CodDian)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Codigo Dian")
                .HasColumnName("cod_Dian");
            entity.Property(e => e.CodPlasub)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código en la Planilla")
                .HasColumnName("cod_plasub");
            entity.Property(e => e.DesSubTip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripción")
                .HasColumnName("Des_SubTip");
        });

        modelBuilder.Entity<RhhTbTipPag>(entity =>
        {
            entity.HasKey(e => e.TipPag);

            entity.ToTable("rhh_tbTipPag");

            entity.Property(e => e.TipPag)
                .ValueGeneratedNever()
                .HasComment("Tipo de Pago")
                .HasColumnName("tip_pag");
            entity.Property(e => e.CodNomElec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Código Homologación Nómina electrónica ")
                .HasColumnName("Cod_NomElec");
            entity.Property(e => e.ForPag)
                .HasDefaultValueSql("((1))")
                .HasComment("Forma de Pago Transferencia, Cheque, Otros")
                .HasColumnName("for_pag");
            entity.Property(e => e.NomPag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre")
                .HasColumnName("nom_pag");
            entity.Property(e => e.TipCta)
                .HasDefaultValueSql("((1))")
                .HasComment("Tipo de Cuenta: Ahorros, Corriente, Otros")
                .HasColumnName("tip_cta");
        });

        modelBuilder.Entity<RhhTbclaest>(entity =>
        {
            entity.HasKey(e => e.TipEst).IsClustered(false);

            entity.ToTable("rhh_tbclaest");

            entity.Property(e => e.TipEst)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo")
                .HasColumnName("tip_est");
            entity.Property(e => e.CodDian)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("Codigo DIAN para Nivel Academico")
                .HasColumnName("CodDIAN");
            entity.Property(e => e.DesEst)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("des_est");
            entity.Property(e => e.IndCurso)
                .HasComment("Es un Curso?")
                .HasColumnName("ind_curso");
            entity.Property(e => e.NivEstHom)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nivel Estudio Homologación")
                .HasColumnName("niv_est_hom");
            entity.Property(e => e.OrdEst)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Orden de Tipo de Estudio")
                .HasColumnName("ord_est");
            entity.Property(e => e.TipEstExtr)
                .HasMaxLength(20)
                .HasComment("Codigo Homologación para integraciones")
                .HasColumnName("tip_est_Extr");
        });

        modelBuilder.Entity<RhhTbemppen>(entity =>
        {
            entity.HasKey(e => e.TipPen);

            entity.ToTable("rhh_tbemppen");

            entity.Property(e => e.TipPen)
                .ValueGeneratedNever()
                .HasColumnName("tip_pen");
            entity.Property(e => e.DesTipPen)
                .HasMaxLength(100)
                .HasColumnName("Des_tipPen");
        });

        modelBuilder.Entity<RhhTbestlab>(entity =>
        {
            entity.HasKey(e => e.EstLab).IsClustered(false);

            entity.ToTable("rhh_tbestlab");

            entity.Property(e => e.EstLab)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Estado")
                .HasColumnName("est_lab");
            entity.Property(e => e.IndLiq)
                .HasComment("Ind. liquidación")
                .HasColumnName("ind_liq");
            entity.Property(e => e.NomEst)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_est");
        });

        modelBuilder.Entity<RhhTbfondo>(entity =>
        {
            entity.HasKey(e => e.CodFdo).HasName("COD_FDO");

            entity.ToTable("rhh_tbfondos", tb =>
                {
                    tb.HasTrigger("TR_rhh_tbfondos");
                    tb.HasTrigger("TR_rhh_tbfondos_CNT");
                });

            entity.HasIndex(e => e.NitTer, "num_nit").HasFillFactor(90);

            entity.Property(e => e.CodFdo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Fondo")
                .HasColumnName("cod_fdo");
            entity.Property(e => e.CodBan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Banco")
                .HasColumnName("cod_ban");
            entity.Property(e => e.CodCon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Concepto")
                .HasColumnName("cod_con");
            entity.Property(e => e.CodSap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("Código SAP")
                .HasColumnName("cod_SAP");
            entity.Property(e => e.CodSgs)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cod iss")
                .HasColumnName("cod_sgs");
            entity.Property(e => e.ConcDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Concepto Desc.");
            entity.Property(e => e.CreFsp)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cuenta Crédito FSP")
                .HasColumnName("cre_fsp");
            entity.Property(e => e.CtaBanfdo)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("No. Cuenta")
                .HasColumnName("cta_banfdo");
            entity.Property(e => e.CtaDeb)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cuenta débito")
                .HasColumnName("cta_deb");
            entity.Property(e => e.CtaFdo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cta fondo")
                .HasColumnName("cta_fdo");
            entity.Property(e => e.DebFsp)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Cuenta Débito FSP")
                .HasColumnName("deb_fsp");
            entity.Property(e => e.DvrTer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Digito tercero")
                .HasColumnName("dvr_ter");
            entity.Property(e => e.Ind12vaInc)
                .HasComment("Paga Incapacidades con doceavas")
                .HasColumnName("ind_12va_inc");
            entity.Property(e => e.Ind326)
                .HasComment("Ind ley 326")
                .HasColumnName("ind_326");
            entity.Property(e => e.IndD30)
                .HasComment("Ind pago 30 días")
                .HasColumnName("ind_d30");
            entity.Property(e => e.IndDau)
                .HasComment("Descuento de Incapcidades Automático")
                .HasColumnName("ind_dau");
            entity.Property(e => e.IndProv)
                .HasComment("Provisionar")
                .HasColumnName("ind_prov");
            entity.Property(e => e.MedPag)
                .HasComment("Medio de pago")
                .HasColumnName("med_pag");
            entity.Property(e => e.NiifCre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasComment("Cuenta credito Niif.")
                .HasColumnName("niif_cre");
            entity.Property(e => e.NiifCrefsp)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasComment("Cuenta credito fsp Niif.")
                .HasColumnName("niif_crefsp");
            entity.Property(e => e.NiifDeb)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Cuenta debito Niif.")
                .HasColumnName("niif_deb");
            entity.Property(e => e.NiifDebfsp)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Cuenta debito fsp Niif")
                .HasColumnName("niif_debfsp");
            entity.Property(e => e.NitTer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nit fondo")
                .HasColumnName("nit_ter");
            entity.Property(e => e.NomFdo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("Nombre")
                .HasColumnName("nom_fdo");
            entity.Property(e => e.Rubros)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Número de Rubro");
            entity.Property(e => e.SecFdo)
                .HasComment("Sector")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("sec_fdo");
            entity.Property(e => e.TipCtafdo)
                .HasComment("Tipo de cuenta")
                .HasColumnName("tip_ctafdo");
            entity.Property(e => e.TipFdo)
                .HasComment("Tipo fondo")
                .HasColumnName("tip_fdo");
            entity.Property(e => e.TipGasto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("Tipo de Gasto")
                .HasColumnName("tip_gasto");
        });

        modelBuilder.Entity<RhhTbmedidaDian2280>(entity =>
        {
            entity.HasKey(e => e.Concepto);

            entity.ToTable("rhh_tbmedidaDian2280");

            entity.Property(e => e.Concepto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RhhTbsindicalizdo>(entity =>
        {
            entity.HasKey(e => e.TipSindclzdo);

            entity.ToTable("rhh_tbsindicalizdo");

            entity.Property(e => e.TipSindclzdo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo Sindicalización")
                .HasColumnName("Tip_sindclzdo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Descripcion");
        });

        modelBuilder.Entity<RhhTbtippen>(entity =>
        {
            entity.HasKey(e => e.TipPen);

            entity.ToTable("rhh_tbtippen");

            entity.Property(e => e.TipPen)
                .ValueGeneratedNever()
                .HasColumnName("tip_pen");
            entity.Property(e => e.DesTipPen)
                .HasMaxLength(200)
                .HasColumnName("Des_tipPen");
        });

        modelBuilder.Entity<RhhTbtipvinculacion>(entity =>
        {
            entity.HasKey(e => e.Tipo);

            entity.ToTable("rhh_tbtipvinculacion");

            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo Vinculación ")
                .HasColumnName("tipo");
            entity.Property(e => e.CodDian)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Codigo DIAN")
                .HasColumnName("cod_dian");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Descripción");
        });

        modelBuilder.Entity<RhhTipoliq>(entity =>
        {
            entity.HasKey(e => e.CodTlq).HasName("cod_tlq");

            entity.ToTable("rhh_tipoliq");

            entity.Property(e => e.CodTlq)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("cod_tlq");
            entity.Property(e => e.CodNomElec)
                .HasDefaultValueSql("('0')")
                .HasComment("Código Homologación Nómina electrónica ")
                .HasColumnName("Cod_NomElec");
            entity.Property(e => e.DiasTlq)
                .HasComment("Días")
                .HasColumnName("dias_tlq");
            entity.Property(e => e.IndPeriodoCom)
                .HasComment("Indicador Periodo Comercial")
                .HasColumnName("ind_periodo_com");
            entity.Property(e => e.NomTlq)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_tlq");
        });

        modelBuilder.Entity<SisAplicacion>(entity =>
        {
            entity.HasKey(e => e.CodApl).HasName("PK_sis_aplicacion_1");

            entity.ToTable("sis_aplicacion");

            entity.Property(e => e.CodApl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("cod_apl");
            entity.Property(e => e.CodEnc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Clave")
                .HasColumnName("cod_enc");
            entity.Property(e => e.EmpApl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("emp_apl");
            entity.Property(e => e.IndCom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ind_com");
            entity.Property(e => e.IndIns)
                .HasComment("Ind instalacióndo")
                .HasColumnName("ind_ins");
            entity.Property(e => e.NomMod)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_mod");
            entity.Property(e => e.NumLic)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Número licencias")
                .HasColumnName("num_lic");
            entity.Property(e => e.Orden)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Orden")
                .HasColumnName("orden");
            entity.Property(e => e.VerApl)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ver_apl");
            entity.Property(e => e.VerAplEnc)
                .HasMaxLength(128)
                .HasColumnName("ver_apl_enc");
        });
        modelBuilder.HasSequence<int>("Consecutivo_SCC");
        modelBuilder.HasSequence("SCC_Felicitacion");
        modelBuilder.HasSequence("SCC_Peticion");
        modelBuilder.HasSequence("SCC_Queja");
        modelBuilder.HasSequence("SCC_Reclamo");
        modelBuilder.HasSequence("SCC_RedesSoc");
        modelBuilder.HasSequence("SCC_Sugerencia");
        modelBuilder.HasSequence<int>("seq_rhh_ausentismo").HasMin(1L);
        modelBuilder.HasSequence("seq_rhh_Novedades");
        modelBuilder.HasSequence("SVT_ConsecSVT");
        modelBuilder.HasSequence<int>("SVT_ConsecutivoPpal");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
