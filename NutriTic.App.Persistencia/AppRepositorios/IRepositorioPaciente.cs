using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente GetOnePaciente(int idPaciente );
        Paciente CreatePaciente(Paciente paciente );
        Paciente UpdatePaciente(Paciente paciente );
        void DeletePaciente(int idPaciente );
    }
}