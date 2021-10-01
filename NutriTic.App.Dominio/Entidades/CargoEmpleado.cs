using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NutriTic.App.Dominio
{   [Table("Cargo_Empleado")]
    public class CargoEmpleado
    {  [Key] 
        public int IdCargoEmpleado {get;set;}

        [Column(TypeName="varchar(50)")][Required]
        public string NombreCargo {get;set;}
    }
}