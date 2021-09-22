using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
using NutriTic.App.Dominio.Entidades;
using NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio;

namespace NutriTic.App.Persistencia.AppRepositorios.ImplementacionRepositorio
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AppContext _appContext;
        public RepositorioEmpleado(AppContext appContext)
        {
            _appContext = appContext;
        }


         Empleado IRepositorioEmpleado.CreateEmpleado(Empleado empleado)
        {
            var empleadoAdicionado=_appContext.Empleado.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }

        void IRepositorioEmpleado.DeleteEmpleado(string idEmpleado)
        {
            var empleadoEncontrado=_appContext.Empleado.FirstOrDefault(p => p.Id==idEmpleado);
            if(empleadoEncontrado==null)
            return;
            _appContext.Empleado.Remove(empleadoEncontrado);
            _appContext.SaveChanges(); 
        }

        IEnumerable<Empleado> IRepositorioEmpleado.GetAllEmpleados()
        {
            return _appContext.Empleado;
        }

        Empleado IRepositorioEmpleado.GetOneEmpleado(string idEmpleado)
        {
            return _appContext.Empleado.FirstOrDefault(p => p.Id == idEmpleado);

        }
    }
}