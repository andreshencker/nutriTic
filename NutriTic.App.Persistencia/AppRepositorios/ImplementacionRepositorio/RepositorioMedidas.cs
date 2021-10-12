using System;
using System.Linq;
using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public class RepositorioMedidas : IRepositorioMedidas
    {
       private readonly AppContext _appContext = new AppContext();

        IEnumerable<Medida> IRepositorioMedidas.GetAllMedidas()
        {
            return _appContext.Medida;
        }
        
        IEnumerable<VMedida> IRepositorioMedidas.GetAllMedidasByPaciente(string idPaciente)
        {
           IEnumerable<VMedida> vMedidas= ( from m in _appContext.Medida
                                            join p in _appContext.Paciente 
                                            on m.IdPaciente equals p.IdPaciente
                                            where m.IdPaciente==idPaciente    
                                            select new VMedida(){
                                             IdMedida = m.IdMedida,
                                             Peso = m.Peso,
                                             IdPaciente=m.IdPaciente,
                                             FechaMedida = m.Fecha,
                                             Estatura=p.Estatura                                            
                                            }).ToList();

          
            return vMedidas;
        }

         Medida IRepositorioMedidas.GetOneMedida(int idMedida)
        {
            return _appContext.Medida.FirstOrDefault(p => p.IdMedida == idMedida);

        }

        Medida IRepositorioMedidas.CreateMedida(Medida medida)
        {
            var medidaAdicionado=_appContext.Medida.Add(medida);
            _appContext.SaveChanges();
            return medidaAdicionado.Entity;
        }

        Medida IRepositorioMedidas.UpdateMedida(Medida medida)
        {
            var medidaEncontrado=_appContext.Medida.FirstOrDefault(p => p.IdMedida==medida.IdMedida);
            if(medidaEncontrado!=null){
                medidaEncontrado.Peso=medida.Peso;
                medidaEncontrado.Fecha=medida.Fecha;
                medidaEncontrado.IdPaciente=medida.IdPaciente;               
                _appContext.SaveChanges();
            }
           
            return medidaEncontrado;
        }

        void IRepositorioMedidas.DeleteMedida(int idMedida)
        {
            var medidaEncontrado=_appContext.Medida.FirstOrDefault(p => p.IdMedida==idMedida);
            if(medidaEncontrado==null)
            return;
            _appContext.Medida.Remove(medidaEncontrado);
            _appContext.SaveChanges(); 
        }

    }
}