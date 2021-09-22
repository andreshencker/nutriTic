using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public class IRepositorioCargoEmpleado
    {
        IEnumerable<CargoEmpleado> GetAllCargoEmpleados();
        CargoEmpleado GetOneCargoEmpleado(string idCargoEmpleado );
        CargoEmpleado CreateCargoEmpleado(CargoEmpleado Cargoempleado );
        //CargoEmpleado UpdateCargoEmpleado(string idCargoEmpleado,CargoEmpleado Cargoempleado);
        void DeleteCargoEmpleado(string idCargoEmpleado);
    }
}