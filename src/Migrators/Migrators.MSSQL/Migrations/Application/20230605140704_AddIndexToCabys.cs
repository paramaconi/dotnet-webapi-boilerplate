using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class AddIndexToCabys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IDX_Cabys_CabysId",
                schema: "Catalog",
                table: "CabysCatalogo",
                column: "CabysID");

            migrationBuilder.CreateIndex(
                name: "IDX_Cabys_Descripcion",
                schema: "Catalog",
                table: "CabysCatalogo",
                column: "Descripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Cabys_CabysId",
                schema: "Catalog",
                table: "CabysCatalogo");

            migrationBuilder.DropIndex(
                name: "IDX_Cabys_Descripcion",
                schema: "Catalog",
                table: "CabysCatalogo");
        }
    }
}
