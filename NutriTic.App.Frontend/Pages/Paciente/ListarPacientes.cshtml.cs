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
    public class ListarPacientesModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;       
        public IEnumerable<Paciente> Pacientes{get;set;}      

        public ListarPacientesModel(IRepositorioPaciente repositorioPaciente ){
             this.repositorioPaciente=repositorioPaciente;        
        }

        public void OnGet()
        {   
            
            Pacientes=repositorioPaciente.GetAllPacientes();
           

        }
    }
}
