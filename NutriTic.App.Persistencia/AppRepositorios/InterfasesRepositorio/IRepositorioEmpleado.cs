using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;
namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleados();
        Empleado GetOneEmpleado(string idEmpleado );
        Empleado CreateEmpleado(Empleado empleado );
        //Paciente UpdateEmpleado(string idEmpleado,Empleado empleado );
        void DeleteEmpleado(string idEmpleado);
    }
}