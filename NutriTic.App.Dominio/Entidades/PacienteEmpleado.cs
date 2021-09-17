namespace NutriTic.App.Dominio.Entidades
{
    public class PacienteEmpleado
    {       
        public int IdPacienteEmpleado  {get;set;}
        public Paciente Paciente  {get;set;}
        public Empleado Empleado  {get;set;}
    }
}