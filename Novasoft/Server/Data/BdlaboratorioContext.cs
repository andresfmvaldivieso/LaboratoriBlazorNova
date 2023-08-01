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

    public virtual DbSet<gen_deptos> GenDeptos { get; set; }

    public virtual DbSet<GenFormapago> GenFormapagos { get; set; }

    public virtual DbSet<GenGrupoetnico> GenGrupoetnicos { get; set; }

    public virtual DbSet<GenMenuGral> GenMenuGrals { get; set; }

    public virtual DbSet<GenPaise> GenPaises { get; set; }

    public virtual DbSet<GenSucursal> GenSucursals { get; set; }

    public virtual DbSet<GenTipide> GenTipides { get; set; }

    public virtual DbSet<GthArea> GthAreas { get; set; }

    public virtual DbSet<GthEstCivil> GthEstCivils { get; set; }

    public virtual DbSet<GthGenero> GthGeneros { get; set; }

    public virtual DbSet<GthRptEstado> GthRptEstados { get; set; }

    public virtual DbSet<RhhCargo> RhhCargos { get; set; }

    public virtual DbSet<RhhCentroTrab> RhhCentroTrabs { get; set; }

    public virtual DbSet<RhhEmplea> RhhEmpleas { get; set; }

    public virtual DbSet<RhhRanVac> RhhRanVacs { get; set; }

    public virtual DbSet<RhhSucursalSs> RhhSucursalSses { get; set; }

    public virtual DbSet<RhhTbCtaGa> RhhTbCtaGas { get; set; }

    public virtual DbSet<RhhTbModLiq> RhhTbModLiqs { get; set; }

    public virtual DbSet<RhhTbSubTipCotiza> RhhTbSubTipCotizas { get; set; }

    public virtual DbSet<RhhTbTipCotiza> RhhTbTipCotizas { get; set; }

    public virtual DbSet<RhhTbTipPag> RhhTbTipPags { get; set; }

    public virtual DbSet<RhhTbTipTrabajo> RhhTbTipTrabajos { get; set; }

    public virtual DbSet<RhhTbclaest> RhhTbclaests { get; set; }

    public virtual DbSet<RhhTbclasal> RhhTbclasals { get; set; }

    public virtual DbSet<RhhTbemppen> RhhTbemppens { get; set; }

    public virtual DbSet<RhhTbestlab> RhhTbestlabs { get; set; }

    public virtual DbSet<RhhTbfondo> RhhTbfondos { get; set; }

    public virtual DbSet<RhhTbmedidaDian2280> RhhTbmedidaDian2280s { get; set; }

    public virtual DbSet<RhhTbsindicalizdo> RhhTbsindicalizdos { get; set; }

    public virtual DbSet<RhhTbtippen> RhhTbtippens { get; set; }

    public virtual DbSet<RhhTbtipvinculacion> RhhTbtipvinculacions { get; set; }

    public virtual DbSet<RhhTipcon> RhhTipcons { get; set; }

    public virtual DbSet<RhhTipoliq> RhhTipoliqs { get; set; }

    public virtual DbSet<SisAplicacion> SisAplicacions { get; set; }

    public virtual DbSet<WebGridmaestro> WebGridmaestros { get; set; }

    public virtual DbSet<WebLabelmaestro> WebLabelmaestros { get; set; }

    public virtual DbSet<WebMaestro> WebMaestros { get; set; }

    public virtual DbSet<WebMaestrosgen> WebMaestrosgens { get; set; }

    public virtual DbSet<WebPaginasmae> WebPaginasmaes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=E-C5G2DS3;Initial Catalog=BDGHSecPublico1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

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

        modelBuilder.Entity<gen_deptos>(entity =>
        {
            entity.HasKey(e => new { e.cod_pai, e.cod_dep }).IsClustered(false);

            entity.ToTable("gen_deptos", tb =>
                {
                    tb.HasTrigger("tr_gen_deptos");
                    tb.HasTrigger("tr_gen_deptos_upd_replicadatos");
                });

            entity.Property(e => e.cod_pai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Pais")
                .HasColumnName("cod_pai");
            entity.Property(e => e.cod_dep)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Departamento")
                .HasColumnName("cod_dep");
            entity.Property(e => e.cod_dep_Extr)
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
            entity.Property(e => e.nom_dep)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_dep");
            entity.Property(e => e.sigla_dep)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Sigla ACH")
                .HasColumnName("sigla_dep");

            entity.HasOne(d => d.CodPaiNavigation).WithMany(p => p.GenDeptos)
                .HasForeignKey(d => d.cod_pai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gen_deptos_gen_paises");
        });

        modelBuilder.Entity<GenFormapago>(entity =>
        {
            entity.HasKey(e => e.CodPag);

            entity.ToTable("gen_formapago");

            entity.Property(e => e.CodPag)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("cod_pag");
            entity.Property(e => e.NomPag)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_pag");
            entity.Property(e => e.TipPag)
                .HasComment("Ind. Pago 0 No Aplica 1 ACH 2 Cheque 3 Otros")
                .HasColumnName("tip_pag");
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
            entity.Property(e => e.ind_exciva)
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

        modelBuilder.Entity<GthArea>(entity =>
        {
            entity.HasKey(e => new { e.CodCia, e.CodArea });

            entity.ToTable("GTH_Areas", tb =>
                {
                    tb.HasComment("Areas de una Organización");
                    tb.HasTrigger("tr_gth_areas_ins");
                    tb.HasTrigger("tr_rhh_gth_areas");
                });

            entity.Property(e => e.CodCia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Compañía")
                .HasColumnName("cod_cia");
            entity.Property(e => e.CodArea)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("Área")
                .HasColumnName("cod_area");
            entity.Property(e => e.CodAreaExtr)
                .HasMaxLength(20)
                .HasComment("Código Area Sistema Externo")
                .HasColumnName("cod_area_Extr");
            entity.Property(e => e.CodCiaExtr)
                .HasMaxLength(20)
                .HasComment("Código Compañia Sistema Externo")
                .HasColumnName("cod_cia_Extr");
            entity.Property(e => e.CodDep)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("Código de quien depende")
                .HasColumnName("cod_dep");
            entity.Property(e => e.CodOrg)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código en el Organigrama")
                .HasColumnName("cod_org");
            entity.Property(e => e.CodOrganigrama)
                .HasComment("Código Organigrama Sistema Externo")
                .HasColumnName("cod_organigrama");
            entity.Property(e => e.DesArea)
                .HasMaxLength(50)
                .HasComment("Descripción")
                .HasColumnName("des_area");
            entity.Property(e => e.IndActExtr)
                .HasComment("Indicador Actualización Sistema Externo")
                .HasColumnName("ind_act_Extr");

            entity.HasOne(d => d.CodCiaNavigation).WithMany(p => p.GthAreas)
                .HasForeignKey(d => d.CodCia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GTH_Areas_gen_compania");
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

            

            entity.HasOne(d => d.CodCiaNavigation).WithMany(p => p.RhhCargos)
                .HasForeignKey(d => d.CodCia)
                .HasConstraintName("FK_rhh_cargos_gen_compania");

            entity.HasOne(d => d.NivAcaNavigation).WithMany(p => p.RhhCargos)
                .HasForeignKey(d => d.NivAca)
                .HasConstraintName("FK_rhh_cargos_rhh_tbclaest");
        });

        modelBuilder.Entity<RhhCentroTrab>(entity =>
        {
            entity.HasKey(e => e.CodCt);

            entity.ToTable("rhh_CentroTrab");

            entity.Property(e => e.CodCt)
                .ValueGeneratedNever()
                .HasComment("Código Centro de Trabajo")
                .HasColumnName("cod_CT");
            entity.Property(e => e.ClaseRiesgo)
                .HasDefaultValueSql("((1))")
                .HasComment("Clase De Riesgo");
            entity.Property(e => e.CodCia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Código Compañía")
                .HasColumnName("cod_cia");
            entity.Property(e => e.CodCtPlanilla)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Centro de Trabajo Planilla")
                .HasColumnName("CodCT_Planilla");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Descripción ")
                .HasColumnName("descripcion");
            entity.Property(e => e.IndAltoriesgo)
                .HasComment("Actividad Alto Riesgo")
                .HasColumnName("Ind_Altoriesgo");
            entity.Property(e => e.Porcentaje)
                .HasComment("Porcentaje")
                .HasColumnType("decimal(6, 3)");
            entity.Property(e => e.TarEspecPens).HasComment("Indicador tarifa especial pensiones para alto riesgo 0.Tarifa normal,1. Actividades de alto riesgo.2. Senadores.3. CTI.4. Aviadores.");
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

        modelBuilder.Entity<RhhSucursalSs>(entity =>
        {
            entity.HasKey(e => e.SucSs);

            entity.ToTable("rhh_sucursalSS");

            entity.Property(e => e.SucSs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("suc_SS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("Descripción")
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<RhhTbCtaGa>(entity =>
        {
            entity.HasKey(e => e.PreCtaGas);

            entity.ToTable("rhh_tbCtaGas");

            entity.Property(e => e.PreCtaGas)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Prefijo Cuenta Gastos")
                .HasColumnName("Pre_CtaGas");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Descripcion Prefijo")
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<RhhTbModLiq>(entity =>
        {
            entity.HasKey(e => e.ModLiq);

            entity.ToTable("rhh_tbModLiq", tb => tb.HasTrigger("Trg_rhh_tbModLiq"));

            entity.Property(e => e.ModLiq)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código")
                .HasColumnName("mod_liq");
            entity.Property(e => e.DesMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Descripción")
                .HasColumnName("des_mod");
            entity.Property(e => e.IndCtt)
                .HasComment("Indicador Contratista")
                .HasColumnName("ind_ctt");
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

        modelBuilder.Entity<RhhTbTipCotiza>(entity =>
        {
            entity.HasKey(e => e.TipCot);

            entity.ToTable("rhh_TbTipCotiza");

            entity.Property(e => e.TipCot)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo Cotizante")
                .HasColumnName("tip_cot");
            entity.Property(e => e.CodDian)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasComment("Codigo Dian")
                .HasColumnName("cod_Dian");
            entity.Property(e => e.CodPlanilla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Código en Planilla")
                .HasColumnName("cod_planilla");
            entity.Property(e => e.DesCot)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Descripción")
                .HasColumnName("des_cot");
            entity.Property(e => e.IndCtt)
                .HasComment("Indicador Contratista")
                .HasColumnName("ind_ctt");
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

        modelBuilder.Entity<RhhTbTipTrabajo>(entity =>
        {
            entity.HasKey(e => e.TipTrabajo);

            entity.ToTable("rhh_tbTipTrabajo", tb => tb.HasComment("Tipos de Trabajo"));

            entity.Property(e => e.TipTrabajo).HasComment("Codigo Tipo Trabajo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Descripcion Tipo Trabajo");
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

        modelBuilder.Entity<RhhTbclasal>(entity =>
        {
            entity.HasKey(e => e.ClaSal);

            entity.ToTable("rhh_tbclasal");

            entity.Property(e => e.ClaSal)
                .ValueGeneratedNever()
                .HasComment("Clase salario")
                .HasColumnName("cla_sal");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("descripcion")
                .HasColumnName("descripcion");
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

        modelBuilder.Entity<RhhTipcon>(entity =>
        {
            entity.HasKey(e => e.TipCon)
                .HasName("PK_rhh_tipvin")
                .IsClustered(false);

            entity.ToTable("rhh_tipcon", tb =>
                {
                    tb.HasTrigger("Tr_rhh_tipcon");
                    tb.HasTrigger("Tr_rhh_tipcon_Valid_IndApo");
                });

            entity.Property(e => e.TipCon)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo Contrato")
                .HasColumnName("tip_con");
            entity.Property(e => e.AplSs)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Habilitar Seguridad Social")
                .HasColumnName("apl_ss");
            entity.Property(e => e.ApoFspP)
                .HasComment("Patrón asume FSP")
                .HasColumnName("apo_fspP");
            entity.Property(e => e.ApoPen)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Aportar Pensión")
                .HasColumnName("apo_pen");
            entity.Property(e => e.ApoPenp100)
                .HasComment("Aportar Pension al 100% patrón")
                .HasColumnName("apo_penp100");
            entity.Property(e => e.ApoRie)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Aportar Riesgos")
                .HasColumnName("apo_rie");
            entity.Property(e => e.ApoSal)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Aportar Salud")
                .HasColumnName("apo_sal");
            entity.Property(e => e.ApoSalp100)
                .HasComment("Aportar Slaud 100% patrón")
                .HasColumnName("apo_salp100");
            entity.Property(e => e.ApoSsemp100)
                .HasComment("Aportar SS al 100% Empleado")
                .HasColumnName("apo_SSEmp100");
            entity.Property(e => e.AuxCom)
                .HasComment("Completar días no cubiertos por la administradora")
                .HasColumnName("Aux_com");
            entity.Property(e => e.AuxInc)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Pagar los días no cubiertos por la adminstradora")
                .HasColumnName("Aux_inc");
            entity.Property(e => e.AuxPor)
                .HasDefaultValueSql("((100))")
                .HasComment("Porcentaje a cubrir en el auxilio")
                .HasColumnType("numeric(7, 4)")
                .HasColumnName("Aux_por");
            entity.Property(e => e.AuxPorDiasAdmon)
                .HasComment("Porcentaje para Cubrir el Auxilio de los dias cubiertos ")
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("AuxPor_DiasAdmon");
            entity.Property(e => e.AuxTra)
                .HasDefaultValueSql("((2))")
                .HasComment("Auxilio de Tansporte")
                .HasColumnName("aux_tra");
            entity.Property(e => e.CodAutol)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('01')")
                .IsFixedLength()
                .HasComment("Código de Autoliquidación")
                .HasColumnName("cod_autol");
            entity.Property(e => e.CodNomElec)
                .HasDefaultValueSql("('0')")
                .HasComment("Código Homologación Nómina electrónica ")
                .HasColumnName("Cod_NomElec");
            entity.Property(e => e.ConHon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Concepto para Honorarios")
                .HasColumnName("con_hon");
            entity.Property(e => e.DiaCes)
                .HasComment("Mínimo número de días para reconocer la Prima")
                .HasColumnName("dia_ces");
            entity.Property(e => e.DiaPri)
                .HasComment("Mínimo número de días para reconocer la Prima")
                .HasColumnName("dia_pri");
            entity.Property(e => e.Diasprima).HasComment("Número de días del semestre para prima");
            entity.Property(e => e.DurCon)
                .HasComment("Duración")
                .HasColumnName("dur_con");
            entity.Property(e => e.IbcMin)
                .HasDefaultValueSql("((1))")
                .HasComment("En caso de IBC inferior al mínimo")
                .HasColumnName("IBC_min");
            entity.Property(e => e.IbcPor)
                .HasDefaultValueSql("((0))")
                .HasComment("Porcentaje de aporte del patrón del IBC si en inf al mínimo")
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("IBC_por");
            entity.Property(e => e.IbcProySs)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("IBC Del Mes para cálculo de proyección de Seguridad Social")
                .HasColumnName("IBC_ProySS");
            entity.Property(e => e.IbcVac)
                .HasDefaultValueSql("((1))")
                .HasComment("IBC usado para los días de vacaciones")
                .HasColumnName("IBC_vac");
            entity.Property(e => e.IndAp8sal)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Aportar salud en caso de LNR")
                .HasColumnName("ind_ap8sal");
            entity.Property(e => e.IndAppen)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Aportar Pensión en caso de LNR")
                .HasColumnName("ind_appen");
            entity.Property(e => e.IndAppenEmp)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("El empleado aporta pensión en LNR")
                .HasColumnName("ind_appen_emp");
            entity.Property(e => e.IndApsalEmp)
                .HasComment("Calcula Salud Empleado en Licencia No Remunerada?")
                .HasColumnName("ind_apsal_emp");
            entity.Property(e => e.IndAusentVac)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Afecta Ausentismos con Interrupción de contrato?")
                .HasColumnName("Ind_AusentVac");
            entity.Property(e => e.IndAuxAdmon)
                .HasComment("Indicador para aplicar Auxilio a incapacidades mayores a 4 dias")
                .HasColumnName("Ind_AuxAdmon");
            entity.Property(e => e.IndAuxTra)
                .HasComment("Validar Pago Transporte (Ultimo Periodo) con lo Devengado ")
                .HasColumnName("ind_AuxTra");
            entity.Property(e => e.IndCesPromSalMen)
                .HasComment("Prima Promerio Sueldo Mensual ")
                .HasColumnName("Ind_CesPromSalMen");
            entity.Property(e => e.IndCtt)
                .HasComment("Indicador Contratista")
                .HasColumnName("ind_ctt");
            entity.Property(e => e.IndIbcdiasAdmon)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Auxilio Incapacidad con el IBC del mes anterior")
                .HasColumnName("Ind_IBCDiasAdmon");
            entity.Property(e => e.IndIbcdiasArl)
                .HasComment("Calcular Auxilio Incapacidad ARL con el IBC del mes anterior")
                .HasColumnName("Ind_IBCDiasARL");
            entity.Property(e => e.IndIbcdiasLma)
                .HasComment("Calcular Licencia Maternidad/Paternidad IBC del mes anterior o con el Salario Basico")
                .HasColumnName("Ind_IBCDiasLMA");
            entity.Property(e => e.IndIbcinc)
                .HasComment("IBC para el pago de Incapacidades")
                .HasColumnName("ind_IBCInc");
            entity.Property(e => e.IndInc31)
                .HasComment("Día 31 en incapacidades")
                .HasColumnName("ind_Inc31");
            entity.Property(e => e.IndIncSbas)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Incapacidad con el sueldo básico del mes anterior")
                .HasColumnName("ind_IncSBas");
            entity.Property(e => e.IndIndemLnr)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Dias LNR Afecta Calculo Dias Indemnizacion")
                .HasColumnName("IndIndemLNR");
            entity.Property(e => e.IndIndemSalVar)
                .HasDefaultValueSql("((1))")
                .HasComment("Indicador Indemnizacion Salario Variable")
                .HasColumnName("Ind_IndemSalVar");
            entity.Property(e => e.IndIndemSalVarLc)
                .HasDefaultValueSql("((1))")
                .HasComment("Indicador Indemnizacion Liquidacion de Contrato Salario Variable")
                .HasColumnName("Ind_IndemSalVarLC");
            entity.Property(e => e.IndIndemTf)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Indicador Indemnizacion Termino Fijo No pagar menos de 15 dias")
                .HasColumnName("ind_indemTF");
            entity.Property(e => e.IndIntCesLnr)
                .HasComment("Indicador LNR Int.Cesantias")
                .HasColumnName("Ind_IntCesLNR");
            entity.Property(e => e.IndIrpAsumido)
                .HasComment("Indicador Riesgos Profesionales Asumir 1 Día")
                .HasColumnName("Ind_IrpAsumido");
            entity.Property(e => e.IndIrpAuxilio)
                .HasComment("Indicador Pagar Auxilio")
                .HasColumnName("Ind_IrpAuxilio");
            entity.Property(e => e.IndLnr31)
                .HasComment("Pagar día 31 en LNR")
                .HasColumnName("ind_Lnr31");
            entity.Property(e => e.IndPara)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular parafiscales")
                .HasColumnName("ind_para");
            entity.Property(e => e.IndPrmLnr)
                .HasComment("Indicador Restar LNR Y SANCIONES")
                .HasColumnName("Ind_PrmLNR");
            entity.Property(e => e.IndPrmPromSalMen)
                .HasComment("Prima Promerio Sueldo Mensual ")
                .HasColumnName("Ind_PrmPromSalMen");
            entity.Property(e => e.IndRetNoAplBenAlim)
                .HasComment("Indicador No Aplica Beneficio Bonos Alimentación al calcular tope para AFP y APV")
                .HasColumnName("Ind_RetNoAplBenAlim");
            entity.Property(e => e.IndSueldoSvar)
                .HasDefaultValueSql("((1))")
                .HasComment("Indicador para Base Salario Empleados Variables")
                .HasColumnName("ind_SueldoSvar");
            entity.Property(e => e.IndVac31)
                .HasComment("No Contar Dia31 en Vacaciones, Cuando No se paga")
                .HasColumnName("Ind_Vac31");
            entity.Property(e => e.IndVacSalVar)
                .HasDefaultValueSql("((1))")
                .HasComment("Indicador Vacaciones Salario Variable")
                .HasColumnName("Ind_VacSalVar");
            entity.Property(e => e.IndVacSalVarLc)
                .HasComment("Indicador Vacaciones Liquidacion de Contrato Salario Variable")
                .HasColumnName("Ind_VacSalVarLC");
            entity.Property(e => e.IndVarbas)
                .HasComment("")
                .HasColumnName("ind_varbas");
            entity.Property(e => e.LiqCes)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Cesantías")
                .HasColumnName("liq_ces");
            entity.Property(e => e.LiqDeccuaEc)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Ecuador-Aplica Decimo Cuarta.")
                .HasColumnName("liq_deccua_ec");
            entity.Property(e => e.LiqDecterEc)
                .HasComment("Ecuador-Aplica Decimo Tercera.")
                .HasColumnName("liq_decter_ec");
            entity.Property(e => e.LiqFdoresEc)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Ecuador-Aplica fdo Reserva.")
                .HasColumnName("liq_fdores_ec");
            entity.Property(e => e.LiqPri)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Prima")
                .HasColumnName("liq_pri");
            entity.Property(e => e.LiqUtilEc)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Ecuador-Aplica Utilidades.")
                .HasColumnName("liq_util_ec");
            entity.Property(e => e.LiqVac)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Vacaciones")
                .HasColumnName("liq_vac");
            entity.Property(e => e.MesProm)
                .HasDefaultValueSql("((12))")
                .HasComment("Meses Para Promedio IBC")
                .HasColumnName("mes_prom");
            entity.Property(e => e.MetAca)
                .HasComment("Tipo Académico")
                .HasColumnName("met_aca");
            entity.Property(e => e.MetLiq)
                .HasDefaultValueSql("((1))")
                .HasComment("Método Liquidación")
                .HasColumnName("met_liq");
            entity.Property(e => e.ModLiq)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasComment("Modo de liquidación")
                .HasColumnName("mod_liq");
            entity.Property(e => e.NomCon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Nombre")
                .HasColumnName("nom_con");
            entity.Property(e => e.NroDiasPrueba)
                .HasComment("Nro de días para periodo de prueba")
                .HasColumnName("Nro_dias_prueba");
            entity.Property(e => e.PagCes)
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Cesantías")
                .HasColumnName("pag_ces");
            entity.Property(e => e.PagIndemn)
                .HasDefaultValueSql("((3))")
                .HasComment("Calculo Base Salario Indemnizacion")
                .HasColumnName("Pag_Indemn");
            entity.Property(e => e.PagPri)
                .HasDefaultValueSql("((1))")
                .HasComment("Calcular Prima")
                .HasColumnName("pag_pri");
            entity.Property(e => e.Pcesantia)
                .HasComment("No pagar con proporcionalidad a los dias definidos")
                .HasColumnName("PCesantia");
            entity.Property(e => e.PerVac)
                .HasDefaultValueSql("((4))")
                .HasComment("Número max de períodos a reconocer")
                .HasColumnName("Per_vac");
            entity.Property(e => e.Pprima).HasComment("No pagar con poroporcionalidad a 360");
            entity.Property(e => e.ProBas)
                .HasDefaultValueSql("((2))")
                .HasComment("Forma de promedio para las Bases")
                .HasColumnName("pro_bas");
            entity.Property(e => e.ProCes)
                .HasDefaultValueSql("((360))")
                .HasComment("Días para realizar promedio")
                .HasColumnName("pro_ces");
            entity.Property(e => e.ProIndemEnero).HasComment("Base Indemnizacion Solo Año Actual-Desde Enero");
            entity.Property(e => e.ProIntCes)
                .HasComment("Proporcionalidad Para Intereses de Cesantias")
                .HasColumnName("pro_intCes");
            entity.Property(e => e.ProPri)
                .HasDefaultValueSql("((360))")
                .HasComment("Días para Provisión Prima")
                .HasColumnName("Pro_pri");
            entity.Property(e => e.ProVac)
                .HasDefaultValueSql("((360))")
                .HasComment("Días para provisión Vacaciones")
                .HasColumnName("pro_vac");
            entity.Property(e => e.ProvAnualEc)
                .HasDefaultValueSql("((1))")
                .HasComment("Ecuador-numero de  meses a Provisionar.")
                .HasColumnName("Prov_anual_ec");
            entity.Property(e => e.ProvCesan)
                .HasComment("Porcentaje a provisionar por cesantías")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("prov_cesan");
            entity.Property(e => e.ProvIntces)
                .HasComment("Porcentaje a provisionar por intereses de cesantía")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("prov_intces");
            entity.Property(e => e.ProvPagCes)
                .HasComment("Calcular Provision Cesantias Segun Indicador Pag_ces")
                .HasColumnName("Prov_PagCes");
            entity.Property(e => e.ProvPagPri)
                .HasComment("Calcular Provision Prima Segun Indicador Pag_pri")
                .HasColumnName("Prov_PagPri");
            entity.Property(e => e.ProvPrima)
                .HasComment("Porcentaje a provisionar por Prima")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("prov_prima");
            entity.Property(e => e.ProvSueldoSvar)
                .HasComment("Calcular Provision Vacaciones Segun Indicador ind_SueldoSvar")
                .HasColumnName("Prov_SueldoSvar");
            entity.Property(e => e.ProvVacac)
                .HasComment("Porcentaje a provisionar por Vacaciones")
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("prov_vacac");
            entity.Property(e => e.ProyPriServ).HasComment("Proyectar Base Salario-Transporte para Prima Hasta FecCorte Liq.Prestacion");
            entity.Property(e => e.PrvMes)
                .HasDefaultValueSql("((12))")
                .HasColumnName("prv_mes");
            entity.Property(e => e.TipDur)
                .HasDefaultValueSql("((1))")
                .HasComment("Tipo Duración")
                .HasColumnName("tip_dur");
            entity.Property(e => e.TrnCes)
                .HasDefaultValueSql("((1))")
                .HasComment("Auxilio de Transporte para las Cesantías")
                .HasColumnName("trn_ces");
            entity.Property(e => e.TrnPri)
                .HasDefaultValueSql("((1))")
                .HasComment("Auxilio de Transporte para la Prima")
                .HasColumnName("trn_pri");
            entity.Property(e => e.TrnVac)
                .HasDefaultValueSql("((1))")
                .HasComment("Auxilio de transporte en vacaciones")
                .HasColumnName("trn_vac");
            entity.Property(e => e.VacUlremEc)
                .HasDefaultValueSql("((0))")
                .HasComment("Ecuador-Pagar Vacac. con Ult Remuner.")
                .HasColumnName("vac_ulrem_ec");

            entity.HasOne(d => d.ModLiqNavigation).WithMany(p => p.RhhTipcons)
                .HasForeignKey(d => d.ModLiq)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rhh_tipcon_rhh_tbModLiq");
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

        modelBuilder.Entity<WebGridmaestro>(entity =>
        {
            entity.HasKey(e => new { e.CodMae, e.NumPag, e.NumGrd, e.NomCmp });

            entity.ToTable("web_gridmaestros");

            entity.Property(e => e.CodMae)
                .HasComment("Código del maestro")
                .HasColumnName("cod_mae");
            entity.Property(e => e.NumPag)
                .HasComment("Número de la página")
                .HasColumnName("num_pag");
            entity.Property(e => e.NumGrd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Numero del grid asociado en web_maestros")
                .HasColumnName("num_grd");
            entity.Property(e => e.NomCmp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Nombre del campo")
                .HasColumnName("nom_cmp");
            entity.Property(e => e.FilHlp).HasColumnName("fil_hlp");
            entity.Property(e => e.ForCmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("formato del campo")
                .HasColumnName("for_cmp");
            entity.Property(e => e.IndAud).HasColumnName("ind_aud");
            entity.Property(e => e.IndLec).HasColumnName("ind_lec");
            entity.Property(e => e.JoinHlp).HasColumnName("join_hlp");
            entity.Property(e => e.KeyHlp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("key_hlp");
            entity.Property(e => e.NivSeg)
                .HasDefaultValueSql("((99))")
                .HasColumnName("niv_seg");
            entity.Property(e => e.NomHlp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_hlp");
            entity.Property(e => e.OrdCmp).HasColumnName("ord_cmp");
            entity.Property(e => e.ReqCmp)
                .HasComment("Indicador de requerido")
                .HasColumnName("req_cmp");
            entity.Property(e => e.TabHlp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tab_hlp");
            entity.Property(e => e.TitCmp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Titulo del campo")
                .HasColumnName("tit_cmp");
            entity.Property(e => e.ValidCmp)
                .HasComment("codigo de validacion del campo (en javascript)")
                .HasColumnName("valid_cmp");
            entity.Property(e => e.WhenCmp).HasColumnName("when_cmp");

           
        });

        modelBuilder.Entity<WebLabelmaestro>(entity =>
        {
            entity.HasKey(e => new { e.CodMae, e.NumPag, e.NomCmp });

            entity.ToTable("web_labelmaestros");

            entity.Property(e => e.CodMae).HasColumnName("cod_mae");
            entity.Property(e => e.NumPag).HasColumnName("num_pag");
            entity.Property(e => e.NomCmp)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("nom_cmp");
            entity.Property(e => e.AltCmp).HasColumnName("alt_cmp");
            entity.Property(e => e.AncCmp).HasColumnName("anc_cmp");
            entity.Property(e => e.BoldLbl).HasColumnName("bold_lbl");
            entity.Property(e => e.ColorLbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("color_lbl");
            entity.Property(e => e.EncCmp).HasColumnName("enc_cmp");
            entity.Property(e => e.FntLbl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fnt_lbl");
            entity.Property(e => e.ItalicLbl).HasColumnName("italic_lbl");
            entity.Property(e => e.PosxLbl).HasColumnName("posx_lbl");
            entity.Property(e => e.PosyLbl).HasColumnName("posy_lbl");
            entity.Property(e => e.SizeLbl).HasColumnName("size_lbl");
            entity.Property(e => e.TxtLbl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("txt_lbl");

            entity.HasOne(d => d.WebPaginasmae).WithMany(p => p.WebLabelmaestros)
                .HasForeignKey(d => new { d.CodMae, d.NumPag })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_web_labelmaestros_web_paginasmae");
        });

        modelBuilder.Entity<WebMaestro>(entity =>
        {
            entity.HasKey(e => new { e.CodMae, e.NomCmp, e.NumPag });

            entity.ToTable("web_maestros");

            entity.Property(e => e.CodMae)
                .HasComment("Código del maestro")
                .HasColumnName("cod_mae");
            entity.Property(e => e.NomCmp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Nombre del campo")
                .HasColumnName("nom_cmp");
            entity.Property(e => e.NumPag)
                .HasComment("Número de la página")
                .HasColumnName("num_pag");
            entity.Property(e => e.AltCmp)
                .HasComment("Alto del campo")
                .HasColumnName("alt_cmp");
            entity.Property(e => e.AncCmp)
                .HasComment("Ancho del campo")
                .HasColumnName("anc_cmp");
            entity.Property(e => e.EncCmp).HasColumnName("enc_cmp");
            entity.Property(e => e.ForCmp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Formato del campo")
                .HasColumnName("for_cmp");
            entity.Property(e => e.IndAud)
                .HasComment("Indicador de Auditoria")
                .HasColumnName("ind_aud");
            entity.Property(e => e.IndBus)
                .HasComment("Indicador de busqueda")
                .HasColumnName("ind_bus");
            entity.Property(e => e.IndLec)
                .HasComment("indicador de lectura")
                .HasColumnName("ind_lec");
            entity.Property(e => e.IndVal)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ind_val");
            entity.Property(e => e.KeyHlp)
                .HasComment("Llave de la tabla de ayuda")
                .HasColumnName("key_hlp");
            entity.Property(e => e.NivSeg)
                .HasDefaultValueSql("((99))")
                .HasColumnName("niv_seg");
            entity.Property(e => e.NomHlp)
                .HasComment("Nombre de la ayuda")
                .HasColumnName("nom_hlp");
            entity.Property(e => e.OpcCmp)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Opciones del campo")
                .HasColumnName("opc_cmp");
            entity.Property(e => e.OrdTab)
                .HasComment("orden de tabulacion del campo")
                .HasColumnName("ord_tab");
            entity.Property(e => e.PosxCmp)
                .HasComment("Posicion X del campo")
                .HasColumnName("posx_cmp");
            entity.Property(e => e.PosyCmp)
                .HasComment("Posicion Y del campo")
                .HasColumnName("posy_cmp");
            entity.Property(e => e.ReqCmp)
                .HasComment("Indicador de requerido")
                .HasColumnName("req_cmp");
            entity.Property(e => e.TabHlp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Tabla de ayuda")
                .HasColumnName("tab_hlp");
            entity.Property(e => e.TipCmp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Tipo de objeto")
                .HasColumnName("tip_cmp");
            entity.Property(e => e.ValOpc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("valores de la opcion(values)")
                .HasColumnName("val_opc");
            entity.Property(e => e.ValidCmp)
                .IsUnicode(false)
                .HasColumnName("valid_cmp");
            entity.Property(e => e.WhenCmp)
                .IsUnicode(false)
                .HasColumnName("when_cmp");

            entity.HasOne(d => d.CodMaeNavigation).WithMany(p => p.WebMaestros)
                .HasForeignKey(d => d.CodMae)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_web_maestros_web_maestrosgen");

            
        });

        modelBuilder.Entity<WebMaestrosgen>(entity =>
        {
            entity.HasKey(e => e.CodMae);

            entity.ToTable("web_maestrosgen", tb => tb.HasTrigger("tr_web_maestrosgen"));

            entity.Property(e => e.CodMae)
                .ValueGeneratedNever()
                .HasColumnName("cod_mae");
            entity.Property(e => e.EmpSector)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('P')")
                .IsFixedLength()
                .HasColumnName("emp_sector");
            entity.Property(e => e.FilDef).HasColumnName("fil_def");
            entity.Property(e => e.IndOrdLlaves)
                .HasComment("Ind Ordenamiento de Llaves alfabeticamente.")
                .HasColumnName("ind_ord_llaves");
            entity.Property(e => e.IndSta).HasColumnName("ind_sta");
            entity.Property(e => e.NomMae)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_mae");
            entity.Property(e => e.NomTab)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_tab");
            entity.Property(e => e.TipArc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tip_arc");
        });

        modelBuilder.Entity<WebPaginasmae>(entity =>
        {
            entity.HasKey(e => new { e.CodMae, e.NumPag }).HasName("PK_web_paginasmae_1");

            entity.ToTable("web_paginasmae");

            entity.Property(e => e.CodMae).HasColumnName("cod_mae");
            entity.Property(e => e.NumPag).HasColumnName("Num_Pag");
            entity.Property(e => e.AncPag).HasColumnName("Anc_Pag");
            entity.Property(e => e.IndSta).HasColumnName("ind_sta");
            entity.Property(e => e.NomPag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Nom_Pag");
            entity.Property(e => e.OrdPag).HasColumnName("ord_pag");
            entity.Property(e => e.SecPag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('M')")
                .IsFixedLength()
                .HasColumnName("sec_pag");

            entity.HasOne(d => d.CodMaeNavigation).WithMany(p => p.WebPaginasmaes)
                .HasForeignKey(d => d.CodMae)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_web_paginasmae_web_maestrosgen");
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
