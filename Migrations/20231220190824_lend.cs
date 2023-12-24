using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Prestamos.Migrations
{
    /// <inheritdoc />
    public partial class lend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetallePre",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "DireccionFiaPre",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "GastosLeyPre",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "MonedaPre",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "TelsFiaPre",
                table: "Prestamo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetallePre",
                table: "Prestamo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DireccionFiaPre",
                table: "Prestamo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GastosLeyPre",
                table: "Prestamo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonedaPre",
                table: "Prestamo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelsFiaPre",
                table: "Prestamo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
