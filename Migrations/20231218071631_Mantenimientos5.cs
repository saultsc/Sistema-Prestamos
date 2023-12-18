using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Prestamos.Migrations
{
    /// <inheritdoc />
    public partial class Mantenimientos5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zona",
                table: "Agente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zona",
                table: "Agente");
        }
    }
}
