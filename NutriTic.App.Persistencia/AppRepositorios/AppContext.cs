using Microsoft.EntityFrameworkCore;
using NutriTic.App.Dominio;
using System.Linq;
using System.Collections.Generic;
namespace NutriTic.App.Persistencia
{
    public class AppContext:DbContext
    {
       
      // public DbSet<Persona> Persona{get;set;}

       public DbSet<CargoEmpleado> CargoEmpleado{get;set;}
       public DbSet<Empleado> Empleado{get;set;}
       public DbSet<Medida> Medida{get;set;}
       public DbSet<Paciente> Paciente{get;set;}
       public DbSet<PacienteEmpleado> PacienteEmpleado{get;set;}
       public DbSet<Valoracion> Valoracion{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB;Initial Catalog=NutriTicData");
            }
        }
    }
}