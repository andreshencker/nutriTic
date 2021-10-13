using System.Security.Cryptography.X509Certificates;
using System;
using System.Linq;
using System.Collections;
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
    IEnumerable<Empleado> IRepositorioEmpleado.GetAllEmpleados(){
            return _appContext.Empleado;
    }

        IEnumerable<VEmpleado> IRepositorioEmpleado.GetAllVEmpleados()
        {

            IEnumerable<VEmpleado> vEmpleados = (
                from e in _appContext.Empleado 
                join ce in _appContext.CargoEmpleado
                on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                select new VEmpleado() {
                    IdEmpleado= e.IdEmpleado,
                    PrimerNombre=e.PrimerNombre,
                    SegundoNombre= e.SegundoNombre,
                    PrimerApellido=e.PrimerApellido,
                    SegundoApellido=e.SegundoApellido,
                    Correo=e.Correo,
                    Telefono=e.Telefono,
                    NombreCargo=ce.NombreCargo,
                    NombreCompleto=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    IdNombreCompleto=e.IdEmpleado+" "+e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido}).ToList();
            return vEmpleados;
             
        }

        VEmpleado IRepositorioEmpleado.GetOneVEmpleado(string idEmpleado)
        {
           VEmpleado vEmpleados = (from e in _appContext.Empleado 
                    join ce in _appContext.CargoEmpleado
                    on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                    where e.IdEmpleado==idEmpleado
                    select new VEmpleado() {
                        IdEmpleado= e.IdEmpleado,
                        PrimerNombre=e.PrimerNombre,
                        SegundoNombre= e.SegundoNombre,
                        PrimerApellido=e.PrimerApellido,
                        SegundoApellido=e.SegundoApellido,
                        Correo=e.Correo,
                        Telefono=e.Telefono,
                        NombreCargo=ce.NombreCargo}).FirstOrDefault();
            return vEmpleados;
        }
        Empleado IRepositorioEmpleado.GetOneEmpleado(string idEmpleado)
        {
            return _appContext.Empleado.FirstOrDefault(p => p.IdEmpleado == idEmpleado);

        }
        
         IEnumerable<Empleado> IRepositorioEmpleado.GetEmpleadoByCargo(int idCargoEmpleado)
        {   
            return _appContext.Empleado.Where(p => p.IdCargoEmpleado == idCargoEmpleado);

        }
        IEnumerable<VEmpleado> IRepositorioEmpleado.GetVEmpleadoByCargo(int idCargoEmpleado)
        {   
            IEnumerable<VEmpleado> vEmpleados =(
                from e in _appContext.Empleado
                join ce in _appContext.CargoEmpleado on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                where e.IdCargoEmpleado==idCargoEmpleado
                select new VEmpleado(){
                    IdEmpleado= e.IdEmpleado,
                    PrimerNombre=e.PrimerNombre,
                    SegundoNombre= e.SegundoNombre,
                    PrimerApellido=e.PrimerApellido,
                    SegundoApellido=e.SegundoApellido,
                    Correo=e.Correo,
                    Telefono=e.Telefono,
                    NombreCargo=ce.NombreCargo,
                    NombreCompleto=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    IdNombreCompleto=e.IdEmpleado+" "+e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido        
                }).ToList();
            return vEmpleados;
        }
        
        

    
    }
}