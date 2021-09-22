using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public class IRepositorioValoracion
    {
        IEnumerable<Valoracion> GetAllValoraciones();
        Valoracion GetOneValoracion(string idValoracion );
        Valoracion CreateValoracion(Empleado empleado );
        //Valoracion UpdateValoracion(string idValoracion,Valoracion valoracion );
        void DeleteValoracion(string idValoracion);
    }
}