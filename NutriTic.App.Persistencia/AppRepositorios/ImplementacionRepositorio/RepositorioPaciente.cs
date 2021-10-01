using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;



namespace NutriTic.App.Persistencia

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
            var pacienteEncontrado=_appContext.Paciente.FirstOrDefault(p => p.IdPaciente==idPaciente);
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
            return _appContext.Paciente.FirstOrDefault(p => p.IdPaciente == idPaciente);

        }

        
    }



}
