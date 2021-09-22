using System.Collections.Generic;
using NutriTic.App.Dominio.Entidades;

namespace NutriTic.App.Persistencia.AppRepositorios.InterfasesRepositorio
{
    public interface IRepositorioMedidas
    {
        IEnumerable<Medida> GetAllMedidas();
        Medida GetOneMedida(int idMedida );
        Medida CreateMedida(Medida medida );
        //Medida UpdateMedida(int idMedida ,Medida medida );
        void DeleteMedida(int idMedida);
    }
}