using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioPacienteEmpleado
    {
        IEnumerable<VPacienteEmpleado> GetAllPacienteEmpleados();
        PacienteEmpleado GetOnePacienteEmpleado(int idPacienteEmpleado );
        IEnumerable<VPacienteEmpleado> GetOneVPacienteEmpleado(int idPacienteEmpleado );
        PacienteEmpleado CreatePacienteEmpleado(PacienteEmpleado Pacienteempleado );
        PacienteEmpleado UpdatePacienteEmpleado(PacienteEmpleado PacienteEmpleado);
        void DeletePacienteEmpleado(int idPacienteEmpleado);
        
        IEnumerable<PacienteEmpleado> GetEmpleadosAsignados(string IdPaciente);
        IEnumerable<VPacienteEmpleado> GetAllPacienteEmpleadosByPaciente(string IdPaciente);
        IEnumerable<VPacienteEmpleado> GetAllPacienteEmpleadosByEmpleado(string IdEmpleado);
    }
}