using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Prestamos.Migrations
{
    /// <inheritdoc />
    public partial class Mantenimientos4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Direccion",
                newName: "Nombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Direccion",
                newName: "Name");
        }
    }
}
