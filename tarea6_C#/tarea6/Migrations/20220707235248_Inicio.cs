using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea6.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "provicnias",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    cedula = table.Column<int>(type: "INTEGER", nullable: true),
                    Apellido = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provicnias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vacunas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacunas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "procesos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Personaid = table.Column<int>(type: "INTEGER", nullable: false),
                    Provicniaid = table.Column<int>(type: "INTEGER", nullable: false),
                    Vacunaid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procesos", x => x.id);
                    table.ForeignKey(
                        name: "FK_procesos_provicnias_Personaid",
                        column: x => x.Personaid,
                        principalTable: "provicnias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_procesos_provicnias_Provicniaid",
                        column: x => x.Provicniaid,
                        principalTable: "provicnias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_procesos_vacunas_Vacunaid",
                        column: x => x.Vacunaid,
                        principalTable: "vacunas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_procesos_Personaid",
                table: "procesos",
                column: "Personaid");

            migrationBuilder.CreateIndex(
                name: "IX_procesos_Provicniaid",
                table: "procesos",
                column: "Provicniaid");

            migrationBuilder.CreateIndex(
                name: "IX_procesos_Vacunaid",
                table: "procesos",
                column: "Vacunaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "procesos");

            migrationBuilder.DropTable(
                name: "provicnias");

            migrationBuilder.DropTable(
                name: "vacunas");
        }
    }
}
