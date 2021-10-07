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
    public class ValoracionEModel : PageModel
    {
        public Paciente Paciente{get;set;}      

        private readonly IRepositorioEmpleado repositorioEmpleado;
         private readonly IRepositorioMedidas repositorioMedida; 
        private readonly IRepositorioPaciente repositorioPaciente;

         public IEnumerable<Medida> Medidas{get;set;} 
        public ValoracionEModel(IRepositorioEmpleado repositorioEmpleado,
                                IRepositorioPaciente repositorioPaciente,
                                IRepositorioMedidas repositorioMedida){
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioPaciente=repositorioPaciente;
            this.repositorioMedida=repositorioMedida;                           
        }       

        public void OnGet()
        {
            Medidas=repositorioMedida.GetAllMedidas();
            Paciente=repositorioPaciente.GetOnePaciente("1");
        }
    }
}
