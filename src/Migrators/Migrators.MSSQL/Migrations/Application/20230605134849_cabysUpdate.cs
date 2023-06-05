using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class cabysUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "Catalog",
                table: "CabysCatalogo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Catalog",
                table: "CabysCatalogo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                schema: "Catalog",
                table: "CabysCatalogo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "Catalog",
                table: "CabysCatalogo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "CabysCatalogo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "CabysCatalogo",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Catalog",
                table: "CabysCatalogo");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Catalog",
                table: "CabysCatalogo");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "Catalog",
                table: "CabysCatalogo");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "Catalog",
                table: "CabysCatalogo");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "CabysCatalogo");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "CabysCatalogo");
        }
    }
}
