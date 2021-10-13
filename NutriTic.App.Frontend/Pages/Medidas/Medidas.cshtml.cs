using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriTic.App.Persistencia;
using NutriTic.App.Dominio;

namespace NutriTic.App.Frontend.Pages
{
    public class MedidasModel : PageModel
    {
        private readonly IRepositorioMedidas repositorioMedida; 
        private readonly IRepositorioValoracion repositorioValoracion; 
        public IEnumerable<VMedida> Medidas{get;set;}       
        public IEnumerable<VValoracion> Valoraciones{get;set;}       

        public MedidasModel(IRepositorioMedidas repositorioMedida,
                            IRepositorioValoracion repositorioValoracion){
            this.repositorioMedida=repositorioMedida;
            this.repositorioValoracion=repositorioValoracion;
        }
        public void OnGet()
        {
            Valoraciones=repositorioValoracion.GetAllValoracionesByPaciente(Sesion.GetSesion().IdUsuario);
            Medidas=repositorioMedida.GetAllMedidasByPaciente(Sesion.GetSesion().IdUsuario);
        }

        
    }
}
