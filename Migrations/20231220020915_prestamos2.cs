using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Prestamos.Migrations
{
    /// <inheritdoc />
    public partial class prestamos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    GarantiaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetallePre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiadorPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionFiaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelsFiaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonedaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuotasPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuotasPagadaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GastosLeyPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BalancePre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontoPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InteresPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiasCuotaPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoPre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamo_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_ClienteId",
                table: "Prestamo",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamo");
        }
    }
}
