
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NutriTic.App.Dominio
{
    [Table("Empleado")]
    public class Empleado
    {
        
        [Key]
        [Column(TypeName="varchar(15)")]
        [Required(ErrorMessage="Ingrese su número de identificación")]
        [Display(Name="Número Identificación")]
        public string IdEmpleado {get;set;}
        
        [Column(TypeName="varchar(50)")]
        [Required(ErrorMessage="Ingrese su primer nombre")]
        [Display(Name="Primer Nombre")]

        public string PrimerNombre {get;set;}

        [Column(TypeName="varchar(50)")]
        [Display(Name="Segundo Nombre")]    
        public string SegundoNombre {get;set;}
        
        [Column(TypeName="varchar(50)")]
        [Required(ErrorMessage="Ingrese su primer apellido")]
        [Display(Name="Primer Apellido")]
        public string PrimerApellido {get;set;}
        
        [Column(TypeName="varchar(50)")]
        [Required(ErrorMessage="Ingrese su segundo apellido")]
        [Display(Name="Segundo Apellido")]
        public string SegundoApellido {get;set;}
        
        [Column(TypeName="varchar(120)")]
        [Required(ErrorMessage="Ingrese su correo")]
        [EmailAddress]        
        [Display(Name="Correo")]
        public string Correo {get;set;}
        
        [Column(TypeName="varchar(15)")]
        [Required(ErrorMessage="Ingrese su telefono")]
        [Display(Name="Telefono")]
        public string Telefono {get;set;}

        [Column(TypeName="int")]
        [Required(ErrorMessage="Ingrese su cargo")]
        [Display(Name="Cargo")]
        public int IdCargoEmpleado { get; set; }
        
        [ForeignKey("IdCargoEmpleado")]
        public CargoEmpleado CargoEmpleado{get;set;}
    }
}