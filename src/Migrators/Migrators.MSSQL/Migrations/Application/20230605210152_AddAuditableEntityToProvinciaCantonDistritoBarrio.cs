using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class AddAuditableEntityToProvinciaCantonDistritoBarrio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Provincias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Provincias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Provincias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Provincias",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Provincias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Provincias",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Distritos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Distritos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Distritos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Distritos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Distritos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Distritos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Cantones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Cantones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Cantones",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Cantones",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Cantones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Cantones",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Barrios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Barrios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Barrios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Barrios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Barrios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Barrios",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Distritos");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Distritos");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Distritos");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Distritos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Distritos");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Distritos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Cantones");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Cantones");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Cantones");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Cantones");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Cantones");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Cantones");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Catalog",
                table: "Barrios");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Catalog",
                table: "Barrios");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "Catalog",
                table: "Barrios");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "Catalog",
                table: "Barrios");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Catalog",
                table: "Barrios");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Catalog",
                table: "Barrios");
        }
    }
}
