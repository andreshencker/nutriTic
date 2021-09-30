using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;
using NutriTic.App.Dominio.Entidades;
using NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio;

namespace NutriTic.App.Persistencia.AppRepositorios.ImplementacionRepositorio
{
    public class RepositorioMedidas : IRepositorioMedidas
    {
       private readonly AppContext _appContext = new AppContext();

        IEnumerable<Medida> IRepositorioMedidas.GetAllMedidas()
        {
            return _appContext.Medida;
        }

         Medida IRepositorioMedidas.GetOneMedida(int idMedida)
        {
            return _appContext.Medida.FirstOrDefault(p => p.Id == idMedida);

        }

        Medida IRepositorioMedidas.CreateMedida(Medida medida)
        {
            var medidaAdicionado=_appContext.Medida.Add(medida);
            _appContext.SaveChanges();
            return medidaAdicionado.Entity;
        }

        void IRepositorioMedidas.DeleteMedida(int idMedida)
        {
            var medidaEncontrado=_appContext.Medida.FirstOrDefault(p => p.Id==idMedida);
            if(medidaEncontrado==null)
            return;
            _appContext.Medida.Remove(medidaEncontrado);
            _appContext.SaveChanges(); 
        }

    }
}