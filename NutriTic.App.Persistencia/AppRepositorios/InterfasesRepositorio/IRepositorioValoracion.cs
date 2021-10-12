using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioValoracion
    {
        IEnumerable<Valoracion> GetAllValoraciones();
        IEnumerable<VValoracion> GetAllValoracionesByPacienteAndEmpleado(string IdPaciente,string IdEmpleado);
        
        Valoracion GetOneValoracion(int idValoracion );
        Valoracion CreateValoracion(Valoracion valoracion );
        Valoracion UpdateValoracion(Valoracion valoracion);
        void DeleteValoracion(int idValoracion);
    }
}