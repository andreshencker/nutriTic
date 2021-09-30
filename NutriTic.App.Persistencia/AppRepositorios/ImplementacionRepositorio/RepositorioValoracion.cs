using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
using NutriTic.App.Dominio.Entidades;
using NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio;

namespace NutriTic.App.Persistencia.AppRepositorios.ImplementacionRepositorio
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

        void IRepositorioValoracion.DeleteValoracion(int idValoracion)
        {
            var valoracionEncontrado=_appContext.Valoracion.FirstOrDefault(p => p.Id==idValoracion);
            if(valoracionEncontrado==null)
            return;
            _appContext.Valoracion.Remove(valoracionEncontrado);
            _appContext.SaveChanges(); 
        }

        IEnumerable<Valoracion> IRepositorioValoracion.GetAllValoraciones()
        {
            return _appContext.Valoracion;
        }

        Valoracion IRepositorioValoracion.GetOneValoracion(int idValoracion)
        {
            return _appContext.Valoracion.FirstOrDefault(p => p.Id == idValoracion);

        }

    }
}