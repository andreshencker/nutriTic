using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;



namespace NutriTic.App.Persistencia
{
    public class RepositorioCargoEmpleado : IRepositorioCargoEmpleado
    {
       private readonly AppContext _appContext = new AppContext();

        IEnumerable<CargoEmpleado> IRepositorioCargoEmpleado.GetAllCargoEmpleados()
        {
            return _appContext.CargoEmpleado;
        }

         CargoEmpleado IRepositorioCargoEmpleado.GetOneCargoEmpleado(int idCargoEmpleado)
        {
            return _appContext.CargoEmpleado.FirstOrDefault(p => p.IdCargoEmpleado == idCargoEmpleado);

        }

        CargoEmpleado IRepositorioCargoEmpleado.CreateCargoEmpleado(CargoEmpleado cargoempleado)
        {
            var cargoempleadoAdicionado=_appContext.CargoEmpleado.Add(cargoempleado);
            _appContext.SaveChanges();
            return cargoempleadoAdicionado.Entity;
        }

        void IRepositorioCargoEmpleado.DeleteCargoEmpleado(int idCargoEmpleado)
        {
            var cargoempleadoEncontrado=_appContext.CargoEmpleado.FirstOrDefault(p => p.IdCargoEmpleado==idCargoEmpleado);
            if(cargoempleadoEncontrado==null)
            return;
            _appContext.CargoEmpleado.Remove(cargoempleadoEncontrado);
            _appContext.SaveChanges(); 
        }
    }
}