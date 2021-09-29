using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NutriTic.App.Persistencia.AppRepositorios;
using NutriTic.App.Dominio.Entidades;

 


namespace NutriTic.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;

        public RegistroModel( IRepositorioPaciente repositorioPaciente){
            this.repositorioPaciente=repositorioPaciente;
        }
        public IEnumerable<Paciente> Pacientes { get; set; }
        public void OnGet()
        {
            Pacientes= repositorioPaciente.GetAllPacientes();
        }
    }
}
