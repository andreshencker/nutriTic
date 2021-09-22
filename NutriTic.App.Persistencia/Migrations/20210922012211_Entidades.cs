using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NutriTic.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimerNonbre",
                table: "Paciente",
                newName: "PrimerNombre");

            migrationBuilder.RenameColumn(
                name: "PrimerNonbre",
                table: "Empleado",
                newName: "PrimerNombre");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Paciente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "Medida",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimerNombre",
                table: "Paciente",
                newName: "PrimerNonbre");

            migrationBuilder.RenameColumn(
                name: "PrimerNombre",
                table: "Empleado",
                newName: "PrimerNonbre");

            migrationBuilder.AlterColumn<string>(
                name: "FechaNacimiento",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Medida",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
