using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioValoracion
    {
        IEnumerable<Valoracion> GetAllValoraciones();
        IEnumerable<VValoracion> GetAllValoracionesByPacienteAndEmpleado(string IdPaciente,string IdEmpleado);
        IEnumerable<VValoracion> GetAllValoracionesByPaciente(string IdPaciente);
        
        Valoracion GetOneValoracion(int idValoracion );
        Valoracion GetOneValoracionByMedida(int IdMedida );
        Valoracion GetOneValoracionByMedidaAndEmpledo(int IdMedida,string IdEmpleado );
        Valoracion CreateValoracion(Valoracion valoracion );
        Valoracion UpdateValoracion(Valoracion valoracion);
        void DeleteValoracion(int idValoracion);
    }
}