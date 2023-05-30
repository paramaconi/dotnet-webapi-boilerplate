using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class AddTableBarrios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barrios",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationID = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DistritoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Barrio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barrios_Distritos_DistritoId",
                        column: x => x.DistritoId,
                        principalSchema: "Catalog",
                        principalTable: "Distritos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barrios_DistritoId",
                schema: "Catalog",
                table: "Barrios",
                column: "DistritoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barrios",
                schema: "Catalog");
        }
    }
}
