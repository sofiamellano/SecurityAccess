using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class SubidaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    IdAlumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoAlumno = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.IdAlumno);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accesos",
                columns: table => new
                {
                    IdAcceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAlumno = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TipoAcceso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResultadoAcceso = table.Column<string>(type: "longtext", nullable: false)
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
                    TemplateHuella = table.Column<byte[]>(type: "longblob", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoHuella = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                table: "Alumnos",
                columns: new[] { "IdAlumno", "Apellido", "Direccion", "Dni", "Email", "EstadoAlumno", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Pérez", null, "12345678", null, "Activo", null, "Juan", null },
                    { 2, "García", null, "87654321", null, "Egresado", null, "Ana", null },
                    { 3, "Martínez", null, "11223344", null, "Suspendido", null, "Luis", null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accesos");

            migrationBuilder.DropTable(
                name: "Huellas");

            migrationBuilder.DropTable(
                name: "Alumnos");
        }
    }
}
