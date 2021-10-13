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
    public class ActualizarValoracionModel : PageModel
    {
        private readonly IRepositorioValoracion repositorioValoracion;
        public Valoracion Valoracion { get; set; }

        public ActualizarValoracionModel(IRepositorioValoracion repositorioValoracion)
        {
            this.repositorioValoracion = repositorioValoracion;
        }

        public IActionResult OnGet(int id)
        {
            Valoracion = repositorioValoracion.GetOneValoracion(id);
            if(Valoracion==null){
                return NotFound();
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(Valoracion valoracion)
        {   
            //valoracion.Comentario="esto es un cambio";
            valoracion.Fecha = DateTime.Now;
            valoracion.IdEmpleado=Sesion.GetSesion().IdUsuario;            
            repositorioValoracion.UpdateValoracion(valoracion);
            return RedirectToPage("./ValoracionE");
        }
    }
}
