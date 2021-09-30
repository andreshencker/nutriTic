using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
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