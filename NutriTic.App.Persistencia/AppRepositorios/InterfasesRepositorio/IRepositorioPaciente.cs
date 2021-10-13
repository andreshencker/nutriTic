using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        
        IEnumerable<Paciente> GetAllPacientes();
        IEnumerable<VPaciente> GetAllVPacientes();
        Paciente GetOnePaciente(string idPaciente );
        //VPaciente GetOnevPaciente(string idPaciente );
        Paciente CreatePaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente );
        void DeletePaciente(string idPaciente );
    }
}