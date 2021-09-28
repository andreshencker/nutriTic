using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public interface IRepositorioValoracion
    {
        IEnumerable<Valoracion> GetAllValoraciones();
        Valoracion GetOneValoracion(int idValoracion );
        Valoracion CreateValoracion(Valoracion valoracion );
        //Valoracion UpdateValoracion(string idValoracion,Valoracion valoracion );
        void DeleteValoracion(int idValoracion);
    }
}