using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    public partial class dddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.CreateTable(
                name: "Carrera",
                schema: "HR",
                columns: table => new
                {
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarreraName = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.CarreraId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                schema: "HR",
                columns: table => new
                {
                    EstudiantesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudiantesName = table.Column<string>(type: "varchar(250)", nullable: false),
                    EstudiantesLastName = table.Column<string>(type: "varchar(250)", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudiantesId);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Carrera_CarreraId",
                        column: x => x.CarreraId,
                        principalSchema: "HR",
                        principalTable: "Carrera",
                        principalColumn: "CarreraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_CarreraId",
                schema: "HR",
                table: "Estudiantes",
                column: "CarreraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Carrera",
                schema: "HR");
        }
    }
}
