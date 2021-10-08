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
    public class CrearMedidaModel : PageModel
    {
        private readonly IRepositorioMedidas repositorioMedida; 
        public Medida Medida { get; set; }
        
        public CrearMedidaModel(IRepositorioMedidas repositorioMedida){
            this.repositorioMedida=repositorioMedida;
        }
        public void OnGet()
        {
            Medida = new Medida();
        }

        public IActionResult OnPost(Medida medida)
        {
            medida.Fecha=DateTime.Now;
            medida.IdPaciente= Sesion.GetSesion().IdUsuario;
            repositorioMedida.CreateMedida(medida);
            return RedirectToPage("./Medidas");
        }
    }
}
