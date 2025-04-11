using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AllTheTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codigo",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Carrera");

            migrationBuilder.RenameColumn(
                name: "semestre",
                table: "PlanDeEstudiosMaterias",
                newName: "Semestre");

            migrationBuilder.RenameColumn(
                name: "idMateria",
                table: "PlanDeEstudiosMaterias",
                newName: "IdMateria");

            migrationBuilder.RenameColumn(
                name: "idPlanEstudioMateria",
                table: "PlanDeEstudiosMaterias",
                newName: "IdPlanEstudioMateria");

            migrationBuilder.RenameColumn(
                name: "planEstudioId",
                table: "PlanDeEstudiosMaterias",
                newName: "IdTipoMateria");

            migrationBuilder.RenameColumn(
                name: "planEstudio",
                table: "PlanDeEstudiosMaterias",
                newName: "Estatus");

            migrationBuilder.RenameColumn(
                name: "materiaId",
                table: "PlanDeEstudiosMaterias",
                newName: "IdSeriacion");

            migrationBuilder.RenameColumn(
                name: "idCarrera",
                table: "PlanDeEstudios",
                newName: "IdCarrera");

            migrationBuilder.RenameColumn(
                name: "idPlanEstudio",
                table: "PlanDeEstudios",
                newName: "IdPlanEstudio");

            migrationBuilder.RenameColumn(
                name: "nombreCarrera",
                table: "PlanDeEstudios",
                newName: "PerfilDelIngreso");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "PlanDeEstudios",
                newName: "PerfilDeEgreso");

            migrationBuilder.RenameColumn(
                name: "idMateria",
                table: "Materias",
                newName: "IdMateria");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Materias",
                newName: "PropositoGeneral");

            migrationBuilder.RenameColumn(
                name: "creditos",
                table: "Materias",
                newName: "IdEstadoCaptura");

            migrationBuilder.RenameColumn(
                name: "idCarrera",
                table: "Carrera",
                newName: "IdCarrera");

            migrationBuilder.AddColumn<int>(
                name: "IdAreaConocimiento",
                table: "PlanDeEstudiosMaterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEtapa",
                table: "PlanDeEstudiosMaterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPlanEstudio",
                table: "PlanDeEstudiosMaterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CampoOcupacional",
                table: "PlanDeEstudios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClavePlanEstudio",
                table: "PlanDeEstudios",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "PlanDeEstudios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estatus",
                table: "PlanDeEstudios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "PlanDeEstudios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlanEstudioNombre",
                table: "PlanDeEstudios",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TotalCreditos",
                table: "PlanDeEstudios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BibliografiaBasica",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BibliografiaComplementaria",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CR",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClaveMateria",
                table: "Materias",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Competencia",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Criterios",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EstadoMateria",
                table: "Materias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Evidencia",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HC",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HCL",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HE",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HL",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HPC",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HT",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Metodologia",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreMateria",
                table: "Materias",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PathPUA",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerfilDocente",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AliasCarrera",
                table: "Carrera",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaveCarrera",
                table: "Carrera",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EstadoCarrera",
                table: "Carrera",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Estatus",
                table: "Carrera",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCarrera",
                table: "Carrera",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "E_AreaDeConocimiento",
                columns: table => new
                {
                    IdAreaConocimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaveAreaConocimiento = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DescripcionAreaConocimiento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_AreaDeConocimiento", x => x.IdAreaConocimiento);
                });

            migrationBuilder.CreateTable(
                name: "E_Etapa",
                columns: table => new
                {
                    IdEtapa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaveEtapa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NombreEtapa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_Etapa", x => x.IdEtapa);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanDeEstudiosMaterias_IdAreaConocimiento",
                table: "PlanDeEstudiosMaterias",
                column: "IdAreaConocimiento");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDeEstudiosMaterias_IdEtapa",
                table: "PlanDeEstudiosMaterias",
                column: "IdEtapa");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDeEstudiosMaterias_IdMateria",
                table: "PlanDeEstudiosMaterias",
                column: "IdMateria");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDeEstudiosMaterias_IdPlanEstudio",
                table: "PlanDeEstudiosMaterias",
                column: "IdPlanEstudio");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDeEstudios_IdCarrera",
                table: "PlanDeEstudios",
                column: "IdCarrera");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDeEstudios_Carrera_IdCarrera",
                table: "PlanDeEstudios",
                column: "IdCarrera",
                principalTable: "Carrera",
                principalColumn: "IdCarrera",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDeEstudiosMaterias_E_AreaDeConocimiento_IdAreaConocimiento",
                table: "PlanDeEstudiosMaterias",
                column: "IdAreaConocimiento",
                principalTable: "E_AreaDeConocimiento",
                principalColumn: "IdAreaConocimiento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDeEstudiosMaterias_E_Etapa_IdEtapa",
                table: "PlanDeEstudiosMaterias",
                column: "IdEtapa",
                principalTable: "E_Etapa",
                principalColumn: "IdEtapa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDeEstudiosMaterias_Materias_IdMateria",
                table: "PlanDeEstudiosMaterias",
                column: "IdMateria",
                principalTable: "Materias",
                principalColumn: "IdMateria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDeEstudiosMaterias_PlanDeEstudios_IdPlanEstudio",
                table: "PlanDeEstudiosMaterias",
                column: "IdPlanEstudio",
                principalTable: "PlanDeEstudios",
                principalColumn: "IdPlanEstudio",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanDeEstudios_Carrera_IdCarrera",
                table: "PlanDeEstudios");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanDeEstudiosMaterias_E_AreaDeConocimiento_IdAreaConocimiento",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanDeEstudiosMaterias_E_Etapa_IdEtapa",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanDeEstudiosMaterias_Materias_IdMateria",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanDeEstudiosMaterias_PlanDeEstudios_IdPlanEstudio",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropTable(
                name: "E_AreaDeConocimiento");

            migrationBuilder.DropTable(
                name: "E_Etapa");

            migrationBuilder.DropIndex(
                name: "IX_PlanDeEstudiosMaterias_IdAreaConocimiento",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropIndex(
                name: "IX_PlanDeEstudiosMaterias_IdEtapa",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropIndex(
                name: "IX_PlanDeEstudiosMaterias_IdMateria",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropIndex(
                name: "IX_PlanDeEstudiosMaterias_IdPlanEstudio",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropIndex(
                name: "IX_PlanDeEstudios_IdCarrera",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "IdAreaConocimiento",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropColumn(
                name: "IdEtapa",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropColumn(
                name: "IdPlanEstudio",
                table: "PlanDeEstudiosMaterias");

            migrationBuilder.DropColumn(
                name: "CampoOcupacional",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "ClavePlanEstudio",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "PlanEstudioNombre",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "TotalCreditos",
                table: "PlanDeEstudios");

            migrationBuilder.DropColumn(
                name: "BibliografiaBasica",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "BibliografiaComplementaria",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "CR",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "ClaveMateria",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "Competencia",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "Criterios",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "EstadoMateria",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "Evidencia",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "HC",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "HCL",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "HE",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "HL",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "HPC",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "HT",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "Metodologia",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "NombreMateria",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "PathPUA",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "PerfilDocente",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "AliasCarrera",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "ClaveCarrera",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "EstadoCarrera",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "NombreCarrera",
                table: "Carrera");

            migrationBuilder.RenameColumn(
                name: "Semestre",
                table: "PlanDeEstudiosMaterias",
                newName: "semestre");

            migrationBuilder.RenameColumn(
                name: "IdMateria",
                table: "PlanDeEstudiosMaterias",
                newName: "idMateria");

            migrationBuilder.RenameColumn(
                name: "IdPlanEstudioMateria",
                table: "PlanDeEstudiosMaterias",
                newName: "idPlanEstudioMateria");

            migrationBuilder.RenameColumn(
                name: "IdTipoMateria",
                table: "PlanDeEstudiosMaterias",
                newName: "planEstudioId");

            migrationBuilder.RenameColumn(
                name: "IdSeriacion",
                table: "PlanDeEstudiosMaterias",
                newName: "materiaId");

            migrationBuilder.RenameColumn(
                name: "Estatus",
                table: "PlanDeEstudiosMaterias",
                newName: "planEstudio");

            migrationBuilder.RenameColumn(
                name: "IdCarrera",
                table: "PlanDeEstudios",
                newName: "idCarrera");

            migrationBuilder.RenameColumn(
                name: "IdPlanEstudio",
                table: "PlanDeEstudios",
                newName: "idPlanEstudio");

            migrationBuilder.RenameColumn(
                name: "PerfilDelIngreso",
                table: "PlanDeEstudios",
                newName: "nombreCarrera");

            migrationBuilder.RenameColumn(
                name: "PerfilDeEgreso",
                table: "PlanDeEstudios",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdMateria",
                table: "Materias",
                newName: "idMateria");

            migrationBuilder.RenameColumn(
                name: "PropositoGeneral",
                table: "Materias",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdEstadoCaptura",
                table: "Materias",
                newName: "creditos");

            migrationBuilder.RenameColumn(
                name: "IdCarrera",
                table: "Carrera",
                newName: "idCarrera");

            migrationBuilder.AddColumn<int>(
                name: "codigo",
                table: "Carrera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Carrera",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
