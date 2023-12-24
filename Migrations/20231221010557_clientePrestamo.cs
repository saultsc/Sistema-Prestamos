using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Prestamos.Migrations
{
    /// <inheritdoc />
    public partial class clientePrestamo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_ClienteId",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Prestamo");

            migrationBuilder.AddColumn<string>(
                name: "NombreClient",
                table: "Prestamo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreClient",
                table: "Prestamo");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_ClienteId",
                table: "Prestamo",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
