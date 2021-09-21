namespace NutriTic.App.Dominio.Entidades
{
    public class PacienteEmpleado
    {       
        public int Id  {get;set;}
        public Paciente Paciente  {get;set;}
        public Empleado Empleado  {get;set;}
    }
}