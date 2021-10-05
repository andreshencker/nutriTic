using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{   [Table("Cargo_Empleado")]
    public class CargoEmpleado
    {   [Key] 
        [Display(Name="Id cargo")]  
        public int IdCargoEmpleado {get;set;}

        [Column(TypeName="varchar(50)")]
        [Required(ErrorMessage="Ingrese el nombre del cargo")]
        [Display(Name="Nombre cargo ")]
        public string NombreCargo {get;set;}
    }
}