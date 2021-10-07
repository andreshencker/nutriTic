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
            var empleadoEncontrado=_appContext.Empleado.Find(idEmpleado);
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
        /*
        IActionResult IRepositorioEmpleado.GetEmpleadoByCargo(int idCargoEmpleado)
        {   
            var resultado = _appContext.Empleado.Where(p => p.IdCargoEmpleado == idCargoEmpleado);
            return resultado;
            
            List<Empleado> empleados=new List<Empleado>();
            empleados.Add(_appContext.Empleado.Where(p => p.IdCargoEmpleado == idCargoEmpleado));
            return empleados;
            

        }
        
        IEnumerable<Empleado> IRepositorioEmpleado.EmpleadosAsignados()
        {
            Random random = new Random();
            List<Empleado> empleadosAsignados = new List<Empleado>();
            List<Empleado> nutricionistas= IRepositorioEmpleado.GetEmpleadoByCargo(1);
            List<Empleado> coaches= IRepositorioEmpleado.GetEmpleadoByCargo(2);           
            Empleado nutricionista = nutricionistas[random.Next(0,nutricionistas.Count())];
            Empleado coach=coaches[random.Next(0,coaches.Count())];
            empleadosAsignados.Add(nutricionista);
            empleadosAsignados.Add(coach);
            return empleadosAsignados;

        }
        

    */
    }
}