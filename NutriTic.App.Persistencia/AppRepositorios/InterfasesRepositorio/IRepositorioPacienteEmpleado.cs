using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public class IRepositorioPacienteEmpleado
    {
        IEnumerable<PacienteEmpleado> GetAllPacienteEmpleados();
        PacienteEmpleado GetOnePacienteEmpleado(string idPacienteEmpleado );
        PacienteEmpleado CreatePacienteEmpleado(PacienteEmpleado Pacienteempleado );
        //PacienteEmpleado UpdatePacienteEmpleado(string idPacienteEmpleado,PacienteEmpleado Pacienteempleado );
        void DeletePacienteEmpleado(string idPacienteEmpleado);
    }
}