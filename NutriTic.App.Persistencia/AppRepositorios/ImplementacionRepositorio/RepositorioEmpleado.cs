using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;


namespace NutriTic.App.Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
      private readonly AppContext _appContext = new AppContext();


        Empleado IRepositorioEmpleado.CreateEmpleado(Empleado empleado)
        {
            var empleadoAdicionado=_appContext.Empleado.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }

        Empleado IRepositorioEmpleado.UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado=_appContext.Empleado.FirstOrDefault(p => p.IdEmpleado==empleado.IdEmpleado);
            if(empleadoEncontrado!=null){
                empleadoEncontrado.PrimerNombre=empleado.PrimerNombre;
                empleadoEncontrado.SegundoNombre=empleado.SegundoNombre;
                empleadoEncontrado.PrimerApellido=empleado.PrimerApellido;
                empleadoEncontrado.SegundoApellido=empleado.SegundoApellido;
                empleadoEncontrado.Correo=empleado.Correo;
                empleadoEncontrado.Telefono=empleado.Telefono;
                empleadoEncontrado.IdCargoEmpleado=empleado.IdCargoEmpleado;
                _appContext.SaveChanges();
            }
           
            return empleadoEncontrado;
        }

        void IRepositorioEmpleado.DeleteEmpleado(string idEmpleado)
        {
            var empleadoEncontrado=_appContext.Empleado.FirstOrDefault(p => p.IdEmpleado==idEmpleado);
            if(empleadoEncontrado==null)
            return;
            _appContext.Empleado.Remove(empleadoEncontrado);
            _appContext.SaveChanges(); 
        }

        IEnumerable<Empleado> IRepositorioEmpleado.GetAllEmpleados()
        {
            return _appContext.Empleado.ToList();
        }

        Empleado IRepositorioEmpleado.GetOneEmpleado(string idEmpleado)
        {
            return _appContext.Empleado.FirstOrDefault(p => p.IdEmpleado == idEmpleado);

        }
    }
}