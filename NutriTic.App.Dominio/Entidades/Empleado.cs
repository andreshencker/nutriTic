namespace NutriTic.App.Dominio
{
    public class Empleado
    {
        public CargoEmpleado CargoEmpleado{get;set;}
        public string Id {get;set;}
        public string PrimerNombre {get;set;}
        public string SegundoNombre {get;set;}
        public string PrimerApellido {get;set;}
        public string SegundoApellido {get;set;}
        public string Correo {get;set;}
        public string Telefono {get;set;}
    }
}