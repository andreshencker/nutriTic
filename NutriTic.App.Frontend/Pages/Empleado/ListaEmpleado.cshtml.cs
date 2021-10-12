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
    public class ListaEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;       
        public IEnumerable<VEmpleado> Empleados{get;set;}      

        public ListaEmpleadoModel(IRepositorioEmpleado repositorioEmpleado ){
             this.repositorioEmpleado = repositorioEmpleado;         
        }

        public void OnGet()
        {   
            
            Empleados=repositorioEmpleado.GetAllVEmpleados();
           

        }

        
    }
}
