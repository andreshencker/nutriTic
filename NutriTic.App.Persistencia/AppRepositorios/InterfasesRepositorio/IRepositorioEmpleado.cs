using System.Collections.Generic;
using NutriTic.App.Dominio;
namespace NutriTic.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleados();
        IEnumerable<VEmpleado> GetAllVEmpleados();
        Empleado GetOneEmpleado(string idEmpleado );
        VEmpleado GetOneVEmpleado(string idEmpleado );
        Empleado CreateEmpleado(Empleado empleado );
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(string idEmpleado);

       IEnumerable<Empleado> GetEmpleadoByCargo(int idCargoEmpleado);
       IEnumerable<VEmpleado> GetVEmpleadoByCargo(int idCargoEmpleado);
       
       


    }
}