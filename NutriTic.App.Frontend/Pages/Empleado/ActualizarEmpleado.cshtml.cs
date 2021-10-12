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
    public class ActualizarEmpleadoModel : PageModel
    {       
        private readonly IRepositorioEmpleado repositorioEmpleado;
        private readonly IRepositorioCargoEmpleado repositorioCargoEmpleado;
        public Empleado Empleado {get;set;}
        public IEnumerable<CargoEmpleado> CargoEmpleados{get;set;}   

        public ActualizarEmpleadoModel(IRepositorioEmpleado repositorioEmpleado,
                                       IRepositorioCargoEmpleado repositorioCargoEmpleado){
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioCargoEmpleado=repositorioCargoEmpleado;
        }        
        public IActionResult OnGet(string id)
        {
            Empleado=repositorioEmpleado.GetOneEmpleado(id);
            CargoEmpleados=repositorioCargoEmpleado.GetAllCargoEmpleados();
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
            return RedirectToPage("./ListaEmpleado");
        }
    }
}
