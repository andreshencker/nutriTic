using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public interface IRepositorioPacienteEmpleado
    {
        IEnumerable<PacienteEmpleado> GetAllPacienteEmpleados();
        PacienteEmpleado GetOnePacienteEmpleado(int idPacienteEmpleado );
        PacienteEmpleado CreatePacienteEmpleado(PacienteEmpleado Pacienteempleado );
        //PacienteEmpleado UpdatePacienteEmpleado(string idPacienteEmpleado,PacienteEmpleado Pacienteempleado );
        void DeletePacienteEmpleado(int idPacienteEmpleado);
    }
}