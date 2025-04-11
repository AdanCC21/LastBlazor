﻿// <auto-generated />
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
    [Migration("20250410172124_initmig")]
    partial class initmig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entitties.Models.E_Carrera", b =>
                {
                    b.Property<int>("idCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCarrera"));

                    b.Property<int>("codigo")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCarrera");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("Entitties.Models.E_Materia", b =>
                {
                    b.Property<int>("idMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMateria"));

                    b.Property<int>("creditos")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMateria");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Entitties.Models.E_PlanDeEstudio", b =>
                {
                    b.Property<int>("idPlanEstudio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPlanEstudio"));

                    b.Property<int>("idCarrera")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreCarrera")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPlanEstudio");

                    b.ToTable("PlanDeEstudios");
                });
#pragma warning restore 612, 618
        }
    }
}
