using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class AddSociedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sociedades",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreComercial = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    TipoIdentificacion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Canton = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Distrito = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    OtrasSenas = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodigoPaisPrincipal = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    NumTelefonoPrincipal = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CodigoPaisSecundario = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    NumTelefonoSecundario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CodigoPaisFax = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sociedades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SociedadesActividadEconomica",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SociedadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SociedadesActividadEconomica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SociedadesActividadEconomica_Sociedades_SociedadId",
                        column: x => x.SociedadId,
                        principalSchema: "Catalog",
                        principalTable: "Sociedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SociedadesDatosHacienda",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LlaveCriptografica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pin = table.Column<int>(type: "int", nullable: true),
                    UsuarioHacienda = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ClaveUsuarioHacienda = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmailEnvio = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    ClaveEmailEnvio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AsuntoEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ServidorSmtp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SociedadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SociedadesDatosHacienda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SociedadesDatosHacienda_Sociedades_SociedadId",
                        column: x => x.SociedadId,
                        principalSchema: "Catalog",
                        principalTable: "Sociedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SociedadesActividadEconomica_SociedadId",
                schema: "Catalog",
                table: "SociedadesActividadEconomica",
                column: "SociedadId");

            migrationBuilder.CreateIndex(
                name: "IX_SociedadesDatosHacienda_SociedadId",
                schema: "Catalog",
                table: "SociedadesDatosHacienda",
                column: "SociedadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SociedadesActividadEconomica",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "SociedadesDatosHacienda",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Sociedades",
                schema: "Catalog");
        }
    }
}
