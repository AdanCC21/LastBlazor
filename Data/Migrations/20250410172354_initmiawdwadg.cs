using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initmiawdwadg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanDeEstudiosMaterias",
                columns: table => new
                {
                    idPlanEstudioMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planEstudioId = table.Column<int>(type: "int", nullable: false),
                    materiaId = table.Column<int>(type: "int", nullable: false),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    planEstudio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idMateria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDeEstudiosMaterias", x => x.idPlanEstudioMateria);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanDeEstudiosMaterias");
        }
    }
}
