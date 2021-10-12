using System.Collections.Generic;
using NutriTic.App.Dominio;

namespace NutriTic.App.Persistencia
{
    public interface IRepositorioMedidas
    {
        IEnumerable<Medida> GetAllMedidas();
        IEnumerable<VMedida> GetAllMedidasByPaciente(string idPaciente);
        Medida GetOneMedida(int idMedida );
        Medida CreateMedida(Medida medida );
        Medida UpdateMedida(Medida medida );
        void DeleteMedida(int idMedida);
    }
}