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
        public IEnumerable<Medida> Medidas{get;set;}       

        public MedidasModel(IRepositorioMedidas repositorioMedida){
            this.repositorioMedida=repositorioMedida;
        }
        public void OnGet()
        {
            
            Medidas=repositorioMedida.GetAllMedidas();
        }

        
    }
}
