using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
using NutriTic.App.Dominio.Entidades;
using NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio;

namespace NutriTic.App.Persistencia.AppRepositorios.ImplementacionRepositorio
{
    public class RepositorioCargoEmpleado : IRepositorioCargoEmpleado
    {
         private readonly AppContext _appContext;
        public RepositorioCargoEmpleado(AppContext appContext)
        {
            _appContext=appContext;
        }

        IEnumerable<CargoEmpleado> IRepositorioCargoEmpleado.GetAllCargoEmpleados()
        {
            return _appContext.CargoEmpleado;
        }

         CargoEmpleado IRepositorioCargoEmpleado.GetOneCargoEmpleado(int idCargoEmpleado)
        {
            return _appContext.CargoEmpleado.FirstOrDefault(p => p.Id == idCargoEmpleado);

        }

        CargoEmpleado IRepositorioCargoEmpleado.CreateCargoEmpleado(CargoEmpleado cargoempleado)
        {
            var cargoempleadoAdicionado=_appContext.CargoEmpleado.Add(cargoempleado);
            _appContext.SaveChanges();
            return cargoempleadoAdicionado.Entity;
        }

        void IRepositorioCargoEmpleado.DeleteCargoEmpleado(int idCargoEmpleado)
        {
            var cargoempleadoEncontrado=_appContext.cargoempleado.FirstOrDefault(p => p.Id==idCargoEmpleado);
            if(cargoempleadoEncontrado==null)
            return;
            _appContext.cargoempleado.Remove(cargoempleadoEncontrado);
            _appContext.SaveChanges(); 
        }
    }
}