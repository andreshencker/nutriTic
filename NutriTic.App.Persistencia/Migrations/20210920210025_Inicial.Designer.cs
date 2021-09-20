﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriTic.App.Persistencia;

namespace NutriTic.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210920210025_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.CargoEmpleado", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NonbreCargo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CargoEmpleado");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Medida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PacienteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Medida");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.PacienteEmpleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmpleadoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PacienteId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("PacienteEmpleado");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Persona", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNonbre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Valoracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmpleadoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MedidaId")
                        .HasColumnType("int");

                    b.Property<string>("comentario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("MedidaId");

                    b.ToTable("Valoracion");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Empleado", b =>
                {
                    b.HasBaseType("NutriTic.App.Dominio.Entidades.Persona");

                    b.Property<string>("CargoEmpleadoId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("CargoEmpleadoId");

                    b.HasDiscriminator().HasValue("Empleado");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Paciente", b =>
                {
                    b.HasBaseType("NutriTic.App.Dominio.Entidades.Persona");

                    b.Property<int>("Estatura")
                        .HasColumnType("int");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitud")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Medida", b =>
                {
                    b.HasOne("NutriTic.App.Dominio.Entidades.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.PacienteEmpleado", b =>
                {
                    b.HasOne("NutriTic.App.Dominio.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("NutriTic.App.Dominio.Entidades.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.Navigation("Empleado");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Valoracion", b =>
                {
                    b.HasOne("NutriTic.App.Dominio.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("NutriTic.App.Dominio.Entidades.Medida", "Medida")
                        .WithMany()
                        .HasForeignKey("MedidaId");

                    b.Navigation("Empleado");

                    b.Navigation("Medida");
                });

            modelBuilder.Entity("NutriTic.App.Dominio.Entidades.Empleado", b =>
                {
                    b.HasOne("NutriTic.App.Dominio.Entidades.CargoEmpleado", "CargoEmpleado")
                        .WithMany()
                        .HasForeignKey("CargoEmpleadoId");

                    b.Navigation("CargoEmpleado");
                });
#pragma warning restore 612, 618
        }
    }
}
