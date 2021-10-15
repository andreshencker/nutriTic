using System.Security.Permissions;
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
    public class CrearValoracionModel : PageModel
    {   
        private readonly IRepositorioValoracion repositorioValoracion;

        public Valoracion Valoracion { get; set; }

        public Medida Media { get; set; }

        public CrearValoracionModel(IRepositorioValoracion repositorioValoracion){
            this.repositorioValoracion=repositorioValoracion;
        }
        public IActionResult OnGet(int id)
        {
            
            Valoracion=new Valoracion();
            Valoracion.IdMedida=id;
            return Page();
            
        }

        public IActionResult OnPost(Valoracion valoracion)
        {   

            Valoracion=repositorioValoracion.GetOneValoracionByMedidaAndEmpledo(valoracion.IdMedida,Sesion.GetSesion().IdUsuario);
            if(Valoracion==null){
                valoracion.Fecha = DateTime.Now;
                valoracion.IdEmpleado=Sesion.GetSesion().IdUsuario;
                repositorioValoracion.CreateValoracion(valoracion);
                return RedirectToPage("./ValoracionE");
            }else{
                return NotFound("la valoracion ya existe");
            }
            
           
        }
    }
}
