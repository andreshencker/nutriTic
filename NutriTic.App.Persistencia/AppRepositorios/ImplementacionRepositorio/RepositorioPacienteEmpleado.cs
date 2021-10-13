using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
namespace NutriTic.App.Persistencia
{
    public class RepositorioPacienteEmpleado:IRepositorioPacienteEmpleado
    {
       private readonly AppContext _appContext = new AppContext();

        IEnumerable<VPacienteEmpleado> IRepositorioPacienteEmpleado.GetAllPacienteEmpleados()
        {
            IEnumerable<VPacienteEmpleado> vPacienteEmpleado=(
                from pe in _appContext.PacienteEmpleado
                join p in _appContext.Paciente on pe.IdPaciente equals p.IdPaciente
                join e in _appContext.Empleado on pe.IdEmpleado equals e.IdEmpleado
                join ce in _appContext.CargoEmpleado on e.IdCargoEmpleado equals ce.IdCargoEmpleado               
                select new VPacienteEmpleado(){
                    IdPacienteEmpleado=pe.IdPacienteEmpleado,
                    IdPaciente=p.IdPaciente,
                    NombrePaciente=p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdEmpleado=e.IdEmpleado,
                    NombreEmpleado=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    NombreCargo=ce.NombreCargo,
                    IdNombrePaciente=p.IdPaciente+" "+p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdNombreEmpleado=e.IdEmpleado+" " + e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido
                    }
            ).ToList();
            return vPacienteEmpleado; 
        }
        IEnumerable<VPacienteEmpleado> IRepositorioPacienteEmpleado.GetAllPacienteEmpleadosByPaciente(string IdPaciente)
        {
            IEnumerable<VPacienteEmpleado> vPacienteEmpleado=(
                from pe in _appContext.PacienteEmpleado
                join p in _appContext.Paciente on pe.IdPaciente equals p.IdPaciente
                join e in _appContext.Empleado on pe.IdEmpleado equals e.IdEmpleado
                join ce in _appContext.CargoEmpleado on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                where pe.IdPaciente==IdPaciente               
                select new VPacienteEmpleado(){
                    IdPacienteEmpleado=pe.IdPacienteEmpleado,
                    IdPaciente=p.IdPaciente,
                    NombrePaciente=p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdEmpleado=e.IdEmpleado,
                    NombreEmpleado=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    NombreCargo=ce.NombreCargo,
                    IdNombrePaciente=p.IdPaciente+" "+p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdNombreEmpleado=e.IdEmpleado+" " + e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido
                    }
            ).ToList();
            return vPacienteEmpleado; 
        }
        IEnumerable<VPacienteEmpleado> IRepositorioPacienteEmpleado.GetAllPacienteEmpleadosByEmpleado(string IdEmpleado)
        {
            IEnumerable<VPacienteEmpleado> vPacienteEmpleado=(
                from pe in _appContext.PacienteEmpleado
                join p in _appContext.Paciente on pe.IdPaciente equals p.IdPaciente
                join e in _appContext.Empleado on pe.IdEmpleado equals e.IdEmpleado
                join ce in _appContext.CargoEmpleado on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                where pe.IdEmpleado==IdEmpleado               
                select new VPacienteEmpleado(){
                    IdPacienteEmpleado=pe.IdPacienteEmpleado,
                    IdPaciente=p.IdPaciente,
                    NombrePaciente=p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdEmpleado=e.IdEmpleado,
                    NombreEmpleado=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    NombreCargo=ce.NombreCargo,
                    IdNombrePaciente=p.IdPaciente+" "+p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdNombreEmpleado=e.IdEmpleado+" " + e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido
                    }
            ).ToList();
            return vPacienteEmpleado; 
        }

         PacienteEmpleado IRepositorioPacienteEmpleado.GetOnePacienteEmpleado(int idPacienteEmpleado)
        {
            return _appContext.PacienteEmpleado.FirstOrDefault(p => p.IdPacienteEmpleado == idPacienteEmpleado);

        }
        IEnumerable<VPacienteEmpleado> IRepositorioPacienteEmpleado.GetOneVPacienteEmpleado(int idPacienteEmpleado)
        {
           IEnumerable<VPacienteEmpleado> vPacienteEmpleado=(
                from pe in _appContext.PacienteEmpleado
                join p in _appContext.Paciente on pe.IdPaciente equals p.IdPaciente
                join e in _appContext.Empleado on pe.IdEmpleado equals e.IdEmpleado
                join ce in _appContext.CargoEmpleado on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                where pe.IdPacienteEmpleado == idPacienteEmpleado
                select new VPacienteEmpleado(){
                    IdPacienteEmpleado=pe.IdPacienteEmpleado,
                    IdPaciente=p.IdPaciente,
                    NombrePaciente=p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,                   
                    IdEmpleado=e.IdEmpleado,
                    NombreEmpleado=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,                   
                    NombreCargo=ce.NombreCargo,
                    IdNombrePaciente=p.IdPaciente+" "+p.PrimerNombre+" "+p.SegundoNombre+" "+p.PrimerApellido+" "+p.SegundoApellido,
                    IdNombreEmpleado=e.IdEmpleado+" " + e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    }).ToList();
            return vPacienteEmpleado; 
            

        }

        PacienteEmpleado IRepositorioPacienteEmpleado.CreatePacienteEmpleado(PacienteEmpleado pacienteempleado)
        {
            var pacienteempleadoAdicionado=_appContext.PacienteEmpleado.Add(pacienteempleado);
            _appContext.SaveChanges();
            return pacienteempleadoAdicionado.Entity;
        }
        
        PacienteEmpleado IRepositorioPacienteEmpleado.UpdatePacienteEmpleado(PacienteEmpleado PacienteEmpleado)
        {
            var pacienteEmpleadoEncontrado=_appContext.PacienteEmpleado.FirstOrDefault(p => p.IdPacienteEmpleado==PacienteEmpleado.IdPacienteEmpleado);
            if(pacienteEmpleadoEncontrado!=null){
                pacienteEmpleadoEncontrado.IdPaciente=PacienteEmpleado.IdPaciente;
                pacienteEmpleadoEncontrado.IdEmpleado=PacienteEmpleado.IdEmpleado;
                _appContext.SaveChanges();
            }
            return pacienteEmpleadoEncontrado;
        }

        void IRepositorioPacienteEmpleado.DeletePacienteEmpleado(int idPacienteEmpleado)
        {
            var pacienteempleadoEncontrado=_appContext.PacienteEmpleado.FirstOrDefault(p => p.IdPacienteEmpleado==idPacienteEmpleado);
            if(pacienteempleadoEncontrado==null)
            return;
            _appContext.PacienteEmpleado.Remove(pacienteempleadoEncontrado);
            _appContext.SaveChanges(); 
        }

    
          IEnumerable<PacienteEmpleado> IRepositorioPacienteEmpleado.GetEmpleadosAsignados(string IdPaciente){            
           
            
            Random random = new Random ();
            List<PacienteEmpleado> pacienteEmpleados = new List<PacienteEmpleado>();
            
            var nutricionistas= _appContext.Empleado.Where(p => p.IdCargoEmpleado == 1).ToList();
            var coaches= _appContext.Empleado.Where(p => p.IdCargoEmpleado == 2).ToList();
            Empleado nutricionista=nutricionistas[random.Next(0,nutricionistas.Count())];
            Empleado coach=coaches[random.Next(0,coaches.Count())];

            PacienteEmpleado nutricionistaPaciente = new PacienteEmpleado();
            nutricionistaPaciente.IdEmpleado=nutricionista.IdEmpleado;
            nutricionistaPaciente.IdPaciente=IdPaciente;
            
            PacienteEmpleado coachPaciente = new PacienteEmpleado();
            coachPaciente.IdEmpleado=coach.IdEmpleado;
            coachPaciente.IdPaciente=IdPaciente;    
            
          
           
            pacienteEmpleados.Add(coachPaciente);
            pacienteEmpleados.Add(nutricionistaPaciente);

            return pacienteEmpleados;
            
        }
    }
}