using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{
    public class Paciente
    {   [Key][Column(TypeName="varchar(15)")]
        public string IdPaciente {get;set;}
        [Column(TypeName="varchar(50)")][Required]
        public string PrimerNombre {get;set;}
        [Column(TypeName="varchar(50)")][Required]
        public string SegundoNombre {get;set;}
        [Column(TypeName="varchar(50)")][Required]
        public string PrimerApellido {get;set;}
        [Column(TypeName="varchar(50)")][Required]
        public string SegundoApellido {get;set;}
        [Column(TypeName="varchar(120)")][Required][EmailAddress]
        public string Correo {get;set;}
        [Column(TypeName="varchar(15)")][Required]
        public string Telefono {get;set;}
        [Column(TypeName="datetime")][Required]    
        public DateTime FechaNacimiento{get;set;}
        public int Estatura{get;set;}
        [Column(TypeName="varchar(50)")][Required]
        public string Latitud{get;set;}
        [Column(TypeName="varchar(50)")][Required]
        public string Longitud{get;set;}
        
    }
}