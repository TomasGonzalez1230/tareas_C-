using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea6.Migrations
{
    public partial class Inicio1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_procesos_provicnias_Personaid",
                table: "procesos");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "provicnias");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "provicnias");

            migrationBuilder.DropColumn(
                name: "cedula",
                table: "provicnias");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "vacunas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "provicnias",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cedula = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_procesos_personas_Personaid",
                table: "procesos",
                column: "Personaid",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_procesos_personas_Personaid",
                table: "procesos");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.AlterColumn<int>(
                name: "Nombre",
                table: "vacunas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Nombre",
                table: "provicnias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Apellido",
                table: "provicnias",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "provicnias",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "cedula",
                table: "provicnias",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_procesos_provicnias_Personaid",
                table: "procesos",
                column: "Personaid",
                principalTable: "provicnias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
