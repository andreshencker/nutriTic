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
    public class ProfileEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public Empleado Empleado {get;set;}

        public ProfileEmpleadoModel(IRepositorioEmpleado repositorioEmpleado){
            this.repositorioEmpleado=repositorioEmpleado;
        }        
        public IActionResult OnGet()
        {
            Empleado=repositorioEmpleado.GetOneEmpleado(Sesion.GetSesion().IdUsuario);
            if(Empleado==null){
                return NotFound();
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(Empleado empleado)
        {
            repositorioEmpleado.UpdateEmpleado(empleado);
            return RedirectToPage("/ValoracionE/ValoracionE");
        }
    }
}
