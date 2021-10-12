using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;


namespace NutriTic.App.Persistencia
{
    public class RepositorioValoracion:IRepositorioValoracion
    {
        private readonly AppContext _appContext = new AppContext();
        Valoracion IRepositorioValoracion.CreateValoracion(Valoracion valoracion)
        {
            var valoracionAdicionado=_appContext.Valoracion.Add(valoracion);
            _appContext.SaveChanges();
            return valoracionAdicionado.Entity;
        }

         Valoracion IRepositorioValoracion.UpdateValoracion(Valoracion valoracion)
        {
            var ValoracionEncontrado=_appContext.Valoracion.FirstOrDefault(p => p.IdValoracion==valoracion.IdValoracion);
            if(ValoracionEncontrado!=null){
              ValoracionEncontrado.IdMedida=valoracion.IdMedida;
              ValoracionEncontrado.comentario=valoracion.comentario;
              ValoracionEncontrado.IdEmpleado=valoracion.IdEmpleado;
              ValoracionEncontrado.Fecha=valoracion.Fecha;
                _appContext.SaveChanges();

            }
            return ValoracionEncontrado;
        }

        

        void IRepositorioValoracion.DeleteValoracion(int idValoracion)
        {
            var valoracionEncontrado=_appContext.Valoracion.FirstOrDefault(p => p.IdValoracion==idValoracion);
            if(valoracionEncontrado==null)
            return;
            _appContext.Valoracion.Remove(valoracionEncontrado);
            _appContext.SaveChanges(); 
        }

        IEnumerable<Valoracion> IRepositorioValoracion.GetAllValoraciones()
        {
            return _appContext.Valoracion;
        }
        IEnumerable<VValoracion> IRepositorioValoracion.GetAllValoracionesByPacienteAndEmpleado(string IdPaciente,string IdEmpleado)
        {
            IEnumerable<VValoracion> valoraciones= (from v in _appContext.Valoracion
                                       join e in _appContext.Empleado on v.IdEmpleado equals e.IdEmpleado
                                       join m in _appContext.Medida on v.IdMedida equals m.IdMedida
                                       join ce in _appContext.CargoEmpleado on e.IdCargoEmpleado equals ce.IdCargoEmpleado
                                       join p in _appContext.Paciente on m.IdPaciente equals p.IdPaciente
                                       where v.IdEmpleado==IdEmpleado && m.IdPaciente==IdPaciente
                                       select new VValoracion(){
                                           IdValoracion=v.IdValoracion,
                                           IdMedida=v.IdMedida,
                                           Comentario=v.comentario,
                                           NombreCompleto=e.PrimerNombre+" "+e.SegundoNombre+" "+e.PrimerApellido+" "+e.SegundoApellido,
                                           NombreCargo=ce.NombreCargo,
                                           FechaValoracion=v.Fecha

                                       }).ToList();
            return valoraciones;
        }

        Valoracion IRepositorioValoracion.GetOneValoracion(int idValoracion)
        {
            return _appContext.Valoracion.FirstOrDefault(p => p.IdValoracion == idValoracion);

        }

    }
}