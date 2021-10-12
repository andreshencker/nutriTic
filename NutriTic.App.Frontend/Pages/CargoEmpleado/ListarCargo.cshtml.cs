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
    public class ListarCargoModel : PageModel
    {
        private readonly IRepositorioCargoEmpleado repositorioCargoEmpleado;       
        public IEnumerable<CargoEmpleado> CargoEmpleados{get;set;}      

        public ListarCargoModel(IRepositorioCargoEmpleado repositorioCargoEmpleado ){
             this.repositorioCargoEmpleado = repositorioCargoEmpleado;         
        }

        public void OnGet()
        {   
            
            CargoEmpleados=repositorioCargoEmpleado.GetAllCargoEmpleados();
           

        }
    }
}
