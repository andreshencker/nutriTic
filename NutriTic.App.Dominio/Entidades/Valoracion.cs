using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{
    public class Valoracion
    {   [Key]
        public int IdValoracion {get;set;}
        [Column(TypeName="text")][Required]
        public string comentario {get;set;}
        [Column(TypeName="datetime")][Required] 
        public DateTime Fecha {get;set;}
        public string IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public Empleado Empleado {get;set;}
        public int IdMedida { get; set; }
        [ForeignKey("IdMedida")]
        public Medida Medida {get;set;}
        
    }
}