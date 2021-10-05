using System.Collections.Generic;
using NutriTic.App.Dominio;
namespace NutriTic.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleados();
        Empleado GetOneEmpleado(string idEmpleado );
        Empleado CreateEmpleado(Empleado empleado );
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(string idEmpleado);
    }
}