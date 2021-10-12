using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioCargoEmpleado
    {
        IEnumerable<CargoEmpleado> GetAllCargoEmpleados();
        CargoEmpleado GetOneCargoEmpleado(int idCargoEmpleado );
        CargoEmpleado CreateCargoEmpleado(CargoEmpleado Cargoempleado );
        CargoEmpleado UpdateCargoEmpleado(CargoEmpleado Cargoempleado);
        void DeleteCargoEmpleado(int idCargoEmpleado);
    }
}