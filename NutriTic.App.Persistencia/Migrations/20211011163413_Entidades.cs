using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NutriTic.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoEmpleado",
                columns: table => new
                {
                    IdCargoEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCargo = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoEmpleado", x => x.IdCargoEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IdPaciente = table.Column<string>(type: "varchar(15)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    Correo = table.Column<string>(type: "varchar(120)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(15)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estatura = table.Column<int>(type: "int", nullable: false),
                    Latitud = table.Column<string>(type: "varchar(50)", nullable: true),
                    Longitud = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<string>(type: "varchar(15)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    Correo = table.Column<string>(type: "varchar(120)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(15)", nullable: false),
                    IdCargoEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_CargoEmpleado_IdCargoEmpleado",
                        column: x => x.IdCargoEmpleado,
                        principalTable: "CargoEmpleado",
                        principalColumn: "IdCargoEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medida",
                columns: table => new
                {
                    IdMedida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medida", x => x.IdMedida);
                    table.ForeignKey(
                        name: "FK_Medida_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacienteEmpleado",
                columns: table => new
                {
                    IdPacienteEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<string>(type: "varchar(15)", nullable: false),
                    IdEmpleado = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteEmpleado", x => x.IdPacienteEmpleado);
                    table.ForeignKey(
                        name: "FK_PacienteEmpleado_Empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacienteEmpleado_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Valoracion",
                columns: table => new
                {
                    IdValoracion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentario = table.Column<string>(type: "text", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdEmpleado = table.Column<string>(type: "varchar(15)", nullable: false),
                    IdMedida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valoracion", x => x.IdValoracion);
                    table.ForeignKey(
                        name: "FK_Valoracion_Empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Valoracion_Medida_IdMedida",
                        column: x => x.IdMedida,
                        principalTable: "Medida",
                        principalColumn: "IdMedida",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdCargoEmpleado",
                table: "Empleado",
                column: "IdCargoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Medida_IdPaciente",
                table: "Medida",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteEmpleado_IdEmpleado",
                table: "PacienteEmpleado",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteEmpleado_IdPaciente",
                table: "PacienteEmpleado",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Valoracion_IdEmpleado",
                table: "Valoracion",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Valoracion_IdMedida",
                table: "Valoracion",
                column: "IdMedida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacienteEmpleado");

            migrationBuilder.DropTable(
                name: "Valoracion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Medida");

            migrationBuilder.DropTable(
                name: "CargoEmpleado");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
