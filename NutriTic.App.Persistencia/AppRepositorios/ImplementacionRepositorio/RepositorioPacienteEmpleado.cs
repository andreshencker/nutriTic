using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
namespace NutriTic.App.Persistencia
{
    public class RepositorioPacienteEmpleado:IRepositorioPacienteEmpleado
    {
       private readonly AppContext _appContext = new AppContext();

        IEnumerable<PacienteEmpleado> IRepositorioPacienteEmpleado.GetAllPacienteEmpleados()
        {
            return _appContext.PacienteEmpleado;
        }

         PacienteEmpleado IRepositorioPacienteEmpleado.GetOnePacienteEmpleado(int idPacienteEmpleado)
        {
            return _appContext.PacienteEmpleado.FirstOrDefault(p => p.IdPacienteEmpleado == idPacienteEmpleado);

        }

        PacienteEmpleado IRepositorioPacienteEmpleado.CreatePacienteEmpleado(PacienteEmpleado pacienteempleado)
        {
            var pacienteempleadoAdicionado=_appContext.PacienteEmpleado.Add(pacienteempleado);
            _appContext.SaveChanges();
            return pacienteempleadoAdicionado.Entity;
        }

        void IRepositorioPacienteEmpleado.DeletePacienteEmpleado(int idPacienteEmpleado)
        {
            var pacienteempleadoEncontrado=_appContext.PacienteEmpleado.FirstOrDefault(p => p.IdPacienteEmpleado==idPacienteEmpleado);
            if(pacienteempleadoEncontrado==null)
            return;
            _appContext.PacienteEmpleado.Remove(pacienteempleadoEncontrado);
            _appContext.SaveChanges(); 
        }

     
    }
}