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
    public class ActualizarMedidaModel : PageModel
    {
        private readonly IRepositorioMedidas repositorioMedidas;
        public Medida Medida {get;set;}

        public ActualizarMedidaModel(IRepositorioMedidas repositorioMedidas){
            this.repositorioMedidas=repositorioMedidas;
        }        
        public IActionResult OnGet(int id)
        {
            Medida=repositorioMedidas.GetOneMedida(id);
            if(Medida==null){
                return NotFound();
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(Medida medida)
        {
            medida.Fecha=DateTime.Now;
            medida.IdPaciente=Sesion.GetSesion().IdUsuario;
            repositorioMedidas.UpdateMedida(medida);
            return RedirectToPage("./Medidas");
        }
    }
}
