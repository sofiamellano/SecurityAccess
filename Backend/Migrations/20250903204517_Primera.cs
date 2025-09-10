using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accesos");

            migrationBuilder.DropTable(
                name: "Huellas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesos",
                columns: table => new
                {
                    IdAcceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAlumno = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ResultadoAcceso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoAcceso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ubicacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesos", x => x.IdAcceso);
                    table.ForeignKey(
                        name: "FK_Accesos_Alumnos_IdAlumno",
                        column: x => x.IdAlumno,
                        principalTable: "Alumnos",
                        principalColumn: "IdAlumno",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Huellas",
                columns: table => new
                {
                    IdHuella = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAlumno = table.Column<int>(type: "int", nullable: false),
                    EstadoHuella = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TemplateHuella = table.Column<byte[]>(type: "longblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huellas", x => x.IdHuella);
                    table.ForeignKey(
                        name: "FK_Huellas_Alumnos_IdAlumno",
                        column: x => x.IdAlumno,
                        principalTable: "Alumnos",
                        principalColumn: "IdAlumno",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Accesos",
                columns: new[] { "IdAcceso", "FechaHora", "IdAlumno", "ResultadoAcceso", "TipoAcceso", "Ubicacion" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 3, 16, 14, 28, 393, DateTimeKind.Local).AddTicks(1317), 1, "Permitido", "Entrada", "Puerta Principal" },
                    { 2, new DateTime(2025, 9, 3, 15, 44, 28, 393, DateTimeKind.Local).AddTicks(1320), 2, "Fallo", "Salida", "Puerta Lateral" },
                    { 3, new DateTime(2025, 9, 3, 15, 14, 28, 393, DateTimeKind.Local).AddTicks(1325), 3, "NoReconocido", "Entrada", "Puerta Trasera" }
                });

            migrationBuilder.InsertData(
                table: "Huellas",
                columns: new[] { "IdHuella", "EstadoHuella", "FechaRegistro", "IdAlumno", "TemplateHuella" },
                values: new object[,]
                {
                    { 1, "Activo", new DateTime(2025, 9, 3, 16, 14, 28, 393, DateTimeKind.Local).AddTicks(1255), 1, new byte[] { 1, 2, 3 } },
                    { 2, "Inactivo", new DateTime(2025, 9, 3, 16, 14, 28, 393, DateTimeKind.Local).AddTicks(1287), 2, new byte[] { 4, 5, 6 } },
                    { 3, "Activo", new DateTime(2025, 9, 3, 16, 14, 28, 393, DateTimeKind.Local).AddTicks(1291), 3, new byte[] { 7, 8, 9 } }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accesos_IdAlumno",
                table: "Accesos",
                column: "IdAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_Huellas_IdAlumno",
                table: "Huellas",
                column: "IdAlumno");
        }
    }
}
