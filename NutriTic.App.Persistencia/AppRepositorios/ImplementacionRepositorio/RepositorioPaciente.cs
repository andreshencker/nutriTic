using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
using NutriTic.App.Dominio.Entidades;
using NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio;

namespace NutriTic.App.Persistencia.AppRepositorios

{

    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext();
       
        Paciente IRepositorioPaciente.CreatePaciente(Paciente paciente)
        {
            var pacienteAdicionado=_appContext.Paciente.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(string idPaciente)
        {
            var pacienteEncontrado=_appContext.Paciente.FirstOrDefault(p => p.Id==idPaciente);
            if(pacienteEncontrado==null)
            return;
            _appContext.Paciente.Remove(pacienteEncontrado);
            _appContext.SaveChanges(); 
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Paciente;
        }

        Paciente IRepositorioPaciente.GetOnePaciente(string idPaciente)
        {
            return _appContext.Paciente.FirstOrDefault(p => p.Id == idPaciente);

        }

        
    }



}
