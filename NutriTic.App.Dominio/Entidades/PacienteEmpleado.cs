using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriTic.App.Dominio
{
    public class PacienteEmpleado
    {   [Key]    
        public int IdPacienteEmpleado  {get;set;}

        [Column(TypeName="varchar(15)")]
        [Required]
        public string IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public Paciente Paciente  {get;set;}

        [Column(TypeName="varchar(15)")]
        [Required]
        public string IdEmpleado { get; set; }
        
        [ForeignKey("IdEmpleado")]
        public Empleado Empleado  {get;set;}

        public PacienteEmpleado(string IdPaciente, string IdEmpleado){
            this.IdEmpleado=IdEmpleado;
            this.IdPaciente=IdPaciente;
        }

     
    }

    
}