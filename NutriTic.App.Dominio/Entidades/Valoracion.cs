using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{
    public class Valoracion
    {   [Key]
        public int IdValoracion {get;set;}

        [Column(TypeName="text")]
        [Required(ErrorMessage="Ingrese la valoración del paciente")]
        [Display(Name="Valoración")]
        public string comentario {get;set;}
        
        [Column(TypeName="datetime")]
        [Required]
        [Display(Name="Fecha valoración")]
        public DateTime Fecha {get;set;}
        
        [Required]
        public string IdEmpleado { get; set; }
        
        [Required]
        [Display(Name="Id Medida")]
        public int IdMedida { get; set; }
        
        [ForeignKey("IdMedida")]
        public Medida Medida {get;set;}

        [ForeignKey("IdEmpleado")]
        public Empleado Empleado {get;set;}

        
    }
}