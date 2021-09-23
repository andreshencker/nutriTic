using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
using NutriTic.App.Dominio.Entidades;
using NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio;
namespace NutriTic.App.Persistencia.AppRepositorios.ImplementacionRepositorio
{
    public class RepositorioPacienteEmpleado:IRepositorioPacienteEmpleado
    {
         private readonly AppContext _appContext;
        public RepositorioPacienteEmpleado(AppContext appContext)
        {
            _appContext=appContext;
        }

        IEnumerable<PacienteEmpleado> IRepositorioPacienteEmpleado.GetAllPacienteEmpleados()
        {
            return _appContext.PacienteEmpleado;
        }

         PacienteEmpleado IRepositorioPacienteEmpleado.GetOnePacienteEmpleado(int idPacienteEmpleado)
        {
            return _appContext.PacienteEmpleado.FirstOrDefault(p => p.Id == idPacienteEmpleado);

        }

        PacienteEmpleado IRepositorioPacienteEmpleado.CreatePacienteEmpleado(PacienteEmpleado pacienteempleado)
        {
            var pacienteempleadoAdicionado=_appContext.PacienteEmpleado.Add(pacienteempleado);
            _appContext.SaveChanges();
            return pacienteempleadoAdicionado.Entity;
        }

        void IRepositorioPacienteEmpleado.DeletePacienteEmpleado(int idPacienteEmpleado)
        {
            var pacienteempleadoEncontrado=_appContext.pacienteempleado.FirstOrDefault(p => p.Id==idPacienteEmpleado);
            if(pacienteempleadoEncontrado==null)
            return;
            _appContext.pacienteempleado.Remove(pacienteempleadoEncontrado);
            _appContext.SaveChanges(); 
        }
    }
}