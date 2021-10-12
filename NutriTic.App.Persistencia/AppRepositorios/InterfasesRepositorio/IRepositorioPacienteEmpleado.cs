using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioPacienteEmpleado
    {
        IEnumerable<PacienteEmpleado> GetAllPacienteEmpleados();
        PacienteEmpleado GetOnePacienteEmpleado(int idPacienteEmpleado );
        PacienteEmpleado CreatePacienteEmpleado(PacienteEmpleado Pacienteempleado );
        //PacienteEmpleado UpdatePacienteEmpleado(string idPacienteEmpleado,PacienteEmpleado Pacienteempleado );
        void DeletePacienteEmpleado(int idPacienteEmpleado);
        
        IEnumerable<PacienteEmpleado> GetEmpleadosAsignados(string IdPaciente);
    }
}