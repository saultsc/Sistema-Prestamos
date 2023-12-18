using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Prestamos.Migrations
{
    /// <inheritdoc />
    public partial class mantenimientoCobrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cobrador",
                newName: "Nombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Cobrador",
                newName: "Name");
        }
    }
}
