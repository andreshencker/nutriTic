
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NutriTic.App.Dominio
{
    [Table("Empleado")]
    public class Empleado
    {
        
        [Key] [Column(TypeName="varchar(15)")]
        public string IdEmpleado {get;set;}
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
        [Column(TypeName="int")][Required]
        public int IdCargoEmpleado { get; set; }
        [ForeignKey("IdCargoEmpleado")]
        public CargoEmpleado CargoEmpleado{get;set;}
    }
}