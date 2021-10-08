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

    /*
          IEnumerable<PacienteEmpleado> IRepositorioPacienteEmpleado.GetEmpleadosAsignados(string IdUsurio){            
           
            
            Random random = new Random ();
            List<PacienteEmpleado> pacienteEmpleados = new List<PacienteEmpleado>();
            
            var nutricionistas= _appContext.Empleado.Where(p => p.IdCargoEmpleado == 1);
            var coaches= _appContext.Empleado.Where(p => p.IdCargoEmpleado == 2);
            Empleado nutricionista=nutricionistas;
            Empleado coach=coaches[random.Next(0,coaches.Count)];

            var nutricionistaPaciente=new PacienteEmpleado(IdUsurio,nutricionistas.IdEmpleado);
            var coachPaciente=new PacienteEmpleado(IdUsurio,coach.IdEmpleado);
            pacienteEmpleados.Add(coachPaciente);
            pacienteEmpleados.Add(nutricionistaPaciente);

            return pacienteEmpleados;
            
        }*/
    }
}