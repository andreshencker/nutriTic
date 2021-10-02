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
    public class EmpleadoModel : PageModel    {
        
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public Empleado Empleado{get;set;}

        public EmpleadoModel(IRepositorioEmpleado repositorioEmpleado) {
            this.repositorioEmpleado = repositorioEmpleado;

        }
        public void OnGet()
        {
            Empleado= new Empleado();
        }
        public IActionResult OnPost(Empleado empleado)
        {
            repositorioEmpleado.CreateEmpleado(empleado);
            return RedirectToPage("/ListaEmpleado");
        }
    }
}
