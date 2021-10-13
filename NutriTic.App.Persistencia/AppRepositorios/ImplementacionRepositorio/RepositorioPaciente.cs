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

        IEnumerable<VPaciente> IRepositorioPaciente.GetAllVPacientes()
        {
             IEnumerable<VPaciente> vPaciente = (
                        from e in _appContext.Paciente                                             
                        select new VPaciente() {
                        IdPaciente= e.IdPaciente,
                        PrimerNombre=e.PrimerNombre,
                        SegundoNombre= e.SegundoNombre,
                        PrimerApellido=e.PrimerApellido,
                        SegundoApellido=e.SegundoApellido,
                        Correo=e.Correo,
                        Telefono=e.Telefono,
                        Estatuta=e.Estatura,
                        NombreCompleto=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                        IdNombreCompleto=e.IdPaciente+" "+ e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido }).ToList();
            return vPaciente;
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Paciente;
        }

        Paciente IRepositorioPaciente.GetOnePaciente(string idPaciente)
        {
            return _appContext.Paciente.FirstOrDefault(p => p.IdPaciente == idPaciente);

        }

        /*
        VPaciente IRepositorioPaciente.GetOnevPaciente(string idPaciente)
        {
            vPaciente=(
                from e in _appContext.Paciente
                where e.IdPaciente == idPaciente
                select new VPaciente(){
                    IdPaciente= e.IdPaciente,
                    PrimerNombre=e.PrimerNombre,
                    SegundoNombre= e.SegundoNombre,
                    PrimerApellido=e.PrimerApellido,
                    SegundoApellido=e.SegundoApellido,
                    Correo=e.Correo,
                    Telefono=e.Telefono,
                    Estatuta=e.Estatura,
                    NombreCompleto=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                    IdNombreCompleto=e.IdPaciente+" "+ e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido     
                });

                return vPaciente;

        }*/

           Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var PacienteEncontrado=_appContext.Paciente.FirstOrDefault(p => p.IdPaciente==paciente.IdPaciente);
            if(PacienteEncontrado!=null){
               PacienteEncontrado.PrimerNombre=paciente.PrimerNombre;
               PacienteEncontrado.SegundoNombre=paciente.SegundoNombre;
               PacienteEncontrado.PrimerApellido=paciente.PrimerApellido;
               PacienteEncontrado.SegundoApellido=paciente.SegundoApellido;
               PacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
               PacienteEncontrado.Correo=paciente.Correo;
               PacienteEncontrado.Telefono=paciente.Telefono;
               PacienteEncontrado.Estatura=paciente.Estatura;
               PacienteEncontrado.Longitud=paciente.Longitud;
               PacienteEncontrado.Latitud=paciente.Latitud;
                
                _appContext.SaveChanges();
            }
           
            return PacienteEncontrado;
        }

        
    }



}
