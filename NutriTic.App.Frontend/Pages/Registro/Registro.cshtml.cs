using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NutriTic.App.Persistencia;
using NutriTic.App.Dominio;


namespace NutriTic.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente{get;set;}

        public RegistroModel( IRepositorioPaciente repositorioPaciente){
            this.repositorioPaciente=repositorioPaciente;
        }
        public IEnumerable<Paciente> Pacientes { get; set; }
        public void OnGet()
        {   
           Paciente= new Paciente();
        }
        public IActionResult OnPost(Paciente paciente)
        {
            repositorioPaciente.CreatePaciente(paciente);
            return RedirectToPage("/Medidas/Medidas");
        }
    }
}
