using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriTic.App.Dominio;
using NutriTic.App.Persistencia;


namespace NutriTic.App.Frontend.Pages
{
    public class EliminarEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;

        public Empleado Empleado{get;set;}

        public EliminarEmpleadoModel(IRepositorioEmpleado repositorioEmpleado){
            this.repositorioEmpleado=repositorioEmpleado;
        }
        public IActionResult OnGet(string id)
        {
            Empleado=repositorioEmpleado.GetOneEmpleado(id);
            if(Empleado==null){
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(string id){
            repositorioEmpleado.DeleteEmpleado(id);
            return RedirectToPage("./ListaEmpleado");
        }
        
    }
}
