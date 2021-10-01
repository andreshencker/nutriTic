using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{   [Table("Medida")]
    public class Medida
    {   [Key]
        public int IdMedida {get;set;} 
        [Column(TypeName="datetime")][Required]    
        public DateTime Fecha {get;set;}
        public int Peso {get;set;}
        [Column(TypeName="varchar(15)")][Required] 
        public string IdPaciente { get; set; }
        [ForeignKey("IdPaciente")]
        public Paciente Paciente {get;set;}

    }
}