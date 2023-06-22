using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class AddSociedadUniqueIndexByTipoIdentificacionAndIdentificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sociedades_TipoIdentificacion_Identificacion",
                schema: "Catalog",
                table: "Sociedades",
                columns: new[] { "TipoIdentificacion", "Identificacion" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sociedades_TipoIdentificacion_Identificacion",
                schema: "Catalog",
                table: "Sociedades");
        }
    }
}
