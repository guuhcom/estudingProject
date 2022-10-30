﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projetoIntegrador.Context;

namespace projetoIntegrador.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Carteira", b =>
                {
                    b.Property<int>("IDCART_CART")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ATIVO_CART")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DTCAD_CART")
                        .HasColumnType("datetime2");

                    b.Property<string>("NOMCART_CART")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IDCART_CART");

                    b.ToTable("TB_CARTEIRAS");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Cliente", b =>
                {
                    b.Property<int>("IDCLI_CLI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COMP_CLI")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DESDOC_CLI")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DTNAS_CLI")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMAIL_CLI")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("IDCONT_CLI")
                        .HasColumnType("int");

                    b.Property<int>("IDDOC_CLI")
                        .HasColumnType("int");

                    b.Property<int>("IDLOC_CLI")
                        .HasColumnType("int");

                    b.Property<string>("NOME_CLI")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("NOMMAE_CLI")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("NUM_CLI")
                        .HasColumnType("int");

                    b.Property<bool>("STATUS_CLI")
                        .HasColumnType("bit");

                    b.Property<string>("TEL_CLI")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("IDCLI_CLI");

                    b.HasIndex("IDCONT_CLI");

                    b.HasIndex("IDDOC_CLI");

                    b.HasIndex("IDLOC_CLI");

                    b.ToTable("TB_CLIENTE");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Conta", b =>
                {
                    b.Property<int>("IDCON_CON")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DTFIM_CON")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DTINI_CON")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DTMOD_CON")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDTIP_CON")
                        .HasColumnType("int");

                    b.Property<int>("NUMAG_CON")
                        .HasColumnType("int");

                    b.Property<int>("NUM_CON")
                        .HasColumnType("int");

                    b.Property<string>("SENHA_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("STATUS_CON")
                        .HasColumnType("bit");

                    b.Property<long>("VALSAL_CON")
                        .HasColumnType("bigint");

                    b.HasKey("IDCON_CON");

                    b.HasIndex("IDTIP_CON");

                    b.ToTable("TB_CONTA");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Documento", b =>
                {
                    b.Property<int>("IDDOC_DOC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESC_DOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DTINI_DOC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("STATUS_DOC")
                        .HasColumnType("bit");

                    b.HasKey("IDDOC_DOC");

                    b.ToTable("TB_DOCUMETO");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Estado", b =>
                {
                    b.Property<int>("IDEST_EST")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DDD_EST")
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<int>("IDPAI_EST")
                        .HasColumnType("int");

                    b.Property<string>("NOM_EST")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IDEST_EST");

                    b.HasIndex("IDPAI_EST");

                    b.ToTable("TB_ESTADO");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Local", b =>
                {
                    b.Property<int>("IDLOC_LOC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CEP_LOC")
                        .HasColumnType("int");

                    b.Property<int>("IDEST_LOC")
                        .HasColumnType("int");

                    b.Property<string>("RUA_LOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IDLOC_LOC");

                    b.HasIndex("IDEST_LOC");

                    b.ToTable("TB_LOCAL");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.LogUsu", b =>
                {
                    b.Property<int>("IDLOG_LOGUSU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESCLOG_LOGUSU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDSEC_LOGUSU")
                        .HasColumnType("int");

                    b.HasKey("IDLOG_LOGUSU");

                    b.HasIndex("IDSEC_LOGUSU");

                    b.ToTable("TB_LOGUSU");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Nivel", b =>
                {
                    b.Property<int>("IDNIV_NIV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ATIVO_NIVEL")
                        .HasColumnType("bit");

                    b.Property<string>("DESNIV_NIV")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DTCAD")
                        .HasColumnType("datetime2");

                    b.HasKey("IDNIV_NIV");

                    b.ToTable("TB_NIVEIS");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.NivelCarteira", b =>
                {
                    b.Property<int>("IDNIVCART_NIVCART")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ATIVO_NIVCART")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DTCAD_NIVCART")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDCART_NIVCART")
                        .HasColumnType("int");

                    b.Property<int>("IDNIV_NIVCART")
                        .HasColumnType("int");

                    b.HasKey("IDNIVCART_NIVCART");

                    b.HasIndex("IDCART_NIVCART");

                    b.HasIndex("IDNIV_NIVCART");

                    b.ToTable("TB_NIVEISCARTEIRA");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Pais", b =>
                {
                    b.Property<int>("IDPAI_PAI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DDI_PAI")
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<string>("NOM_PAI")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IDPAI_PAI");

                    b.ToTable("TB_PAIS");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Section", b =>
                {
                    b.Property<int>("IDSEC_SEC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ATIVO_SEC")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DTCAD_SEC")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDSUS_SUS")
                        .HasColumnType("int");

                    b.Property<string>("KEYSEC_SEC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDSEC_SEC");

                    b.HasIndex("IDSUS_SUS");

                    b.ToTable("TB_SECTION");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.TipoConta", b =>
                {
                    b.Property<int>("IDTPC_TPC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESC_TPC")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DTINI_TPC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("STATUS_TPC")
                        .HasColumnType("bit");

                    b.HasKey("IDTPC_TPC");

                    b.ToTable("TB_TIPOCONTA");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Usuario", b =>
                {
                    b.Property<int>("IDUSU_USU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ATIVO_USU")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DTCAD_USU")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HORAFIM_USU")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HORAINI_USU")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDCLI_USU")
                        .HasColumnType("int");

                    b.Property<int>("IDNIV_USU")
                        .HasColumnType("int");

                    b.Property<bool>("LOGADO_USU")
                        .HasColumnType("bit");

                    b.Property<string>("LOGIN_USU")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SENHA_USU")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IDUSU_USU");

                    b.HasIndex("IDCLI_USU");

                    b.HasIndex("IDNIV_USU");

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Cliente", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("IDCONT_CLI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projetoIntegrador.Models.DbClass.Documento", "Documento")
                        .WithMany()
                        .HasForeignKey("IDDOC_CLI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projetoIntegrador.Models.DbClass.Local", "Local")
                        .WithMany()
                        .HasForeignKey("IDLOC_CLI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Conta", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.TipoConta", "TipoConta")
                        .WithMany()
                        .HasForeignKey("IDTIP_CON")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Estado", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IDPAI_EST")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Local", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("IDEST_LOC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.LogUsu", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Section", "Section")
                        .WithMany()
                        .HasForeignKey("IDSEC_LOGUSU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.NivelCarteira", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Carteira", "Carteira")
                        .WithMany()
                        .HasForeignKey("IDCART_NIVCART")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projetoIntegrador.Models.DbClass.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("IDNIV_NIVCART")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Section", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IDSUS_SUS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projetoIntegrador.Models.DbClass.Usuario", b =>
                {
                    b.HasOne("projetoIntegrador.Models.DbClass.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IDCLI_USU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projetoIntegrador.Models.DbClass.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("IDNIV_USU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
