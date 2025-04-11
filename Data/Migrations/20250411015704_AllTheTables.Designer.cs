﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250411015704_AllTheTables")]
    partial class AllTheTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entitties.Models.E_AreaDeConocimiento", b =>
                {
                    b.Property<int>("IdAreaConocimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAreaConocimiento"));

                    b.Property<string>("ClaveAreaConocimiento")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("DescripcionAreaConocimiento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdAreaConocimiento");

                    b.ToTable("E_AreaDeConocimiento");
                });

            modelBuilder.Entity("Entitties.Models.E_Carrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"));

                    b.Property<string>("AliasCarrera")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClaveCarrera")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<bool>("EstadoCarrera")
                        .HasColumnType("bit");

                    b.Property<string>("Estatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdCarrera");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("Entitties.Models.E_Etapa", b =>
                {
                    b.Property<int>("IdEtapa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEtapa"));

                    b.Property<string>("ClaveEtapa")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("NombreEtapa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEtapa");

                    b.ToTable("E_Etapa");
                });

            modelBuilder.Entity("Entitties.Models.E_Materia", b =>
                {
                    b.Property<int>("IdMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMateria"));

                    b.Property<string>("BibliografiaBasica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BibliografiaComplementaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CR")
                        .HasColumnType("int");

                    b.Property<string>("ClaveMateria")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Competencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Criterios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstadoMateria")
                        .HasColumnType("bit");

                    b.Property<string>("Evidencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HC")
                        .HasColumnType("int");

                    b.Property<int>("HCL")
                        .HasColumnType("int");

                    b.Property<int>("HE")
                        .HasColumnType("int");

                    b.Property<int>("HL")
                        .HasColumnType("int");

                    b.Property<int>("HPC")
                        .HasColumnType("int");

                    b.Property<int>("HT")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoCaptura")
                        .HasColumnType("int");

                    b.Property<string>("Metodologia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreMateria")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PathPUA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerfilDocente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropositoGeneral")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMateria");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Entitties.Models.E_PlanDeEstudio", b =>
                {
                    b.Property<int>("IdPlanEstudio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlanEstudio"));

                    b.Property<string>("CampoOcupacional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClavePlanEstudio")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCarrera")
                        .HasColumnType("int");

                    b.Property<string>("PerfilDeEgreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerfilDelIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanEstudioNombre")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("TotalCreditos")
                        .HasColumnType("int");

                    b.HasKey("IdPlanEstudio");

                    b.HasIndex("IdCarrera");

                    b.ToTable("PlanDeEstudios");
                });

            modelBuilder.Entity("Entitties.Models.E_PlanDeMateria", b =>
                {
                    b.Property<int>("IdPlanEstudioMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlanEstudioMateria"));

                    b.Property<string>("Estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAreaConocimiento")
                        .HasColumnType("int");

                    b.Property<int>("IdEtapa")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("IdPlanEstudio")
                        .HasColumnType("int");

                    b.Property<int>("IdSeriacion")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoMateria")
                        .HasColumnType("int");

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.HasKey("IdPlanEstudioMateria");

                    b.HasIndex("IdAreaConocimiento");

                    b.HasIndex("IdEtapa");

                    b.HasIndex("IdMateria");

                    b.HasIndex("IdPlanEstudio");

                    b.ToTable("PlanDeEstudiosMaterias");
                });

            modelBuilder.Entity("Entitties.Models.E_PlanDeEstudio", b =>
                {
                    b.HasOne("Entitties.Models.E_Carrera", "Carreras")
                        .WithMany("PlanesEstudio")
                        .HasForeignKey("IdCarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carreras");
                });

            modelBuilder.Entity("Entitties.Models.E_PlanDeMateria", b =>
                {
                    b.HasOne("Entitties.Models.E_AreaDeConocimiento", "AreaConocimiento")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdAreaConocimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entitties.Models.E_Etapa", "Etapas")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdEtapa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entitties.Models.E_Materia", "Materias")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entitties.Models.E_PlanDeEstudio", "PlanEstudio")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdPlanEstudio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AreaConocimiento");

                    b.Navigation("Etapas");

                    b.Navigation("Materias");

                    b.Navigation("PlanEstudio");
                });

            modelBuilder.Entity("Entitties.Models.E_AreaDeConocimiento", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entitties.Models.E_Carrera", b =>
                {
                    b.Navigation("PlanesEstudio");
                });

            modelBuilder.Entity("Entitties.Models.E_Etapa", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entitties.Models.E_Materia", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entitties.Models.E_PlanDeEstudio", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });
#pragma warning restore 612, 618
        }
    }
}
