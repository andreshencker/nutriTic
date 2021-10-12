using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{   [Table("Medida")]
    public class Medida
    {   [Key]
        [Display(Name="Id Medida")]  
        public int IdMedida {get;set;} 
        
        [Column(TypeName="datetime")]
        [Required]
        [Display(Name="Fecha Medida")]    
        public DateTime Fecha {get;set;}

        [Required(ErrorMessage="Ingrese su peso")]
        [Display(Name="Peso")]
        public double Peso {get;set;}

        [Column(TypeName="varchar(15)")] 
        [Required] 
        public string IdPaciente { get; set; }
        
        [ForeignKey("IdPaciente")]
        public Paciente Paciente {get;set;}

    }
}