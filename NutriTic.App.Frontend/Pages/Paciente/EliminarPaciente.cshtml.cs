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
    public class EliminarPacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;

        public Paciente Paciente{get;set;}

        public EliminarPacienteModel(IRepositorioPaciente repositorioPaciente){
            this.repositorioPaciente=repositorioPaciente;
        }
        public IActionResult OnGet(string id)
        {
            Paciente=repositorioPaciente.GetOnePaciente(id);
            if(Paciente==null){
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(string id){
            repositorioPaciente.DeletePaciente(id);
            return RedirectToPage("./ListarPacientes");
        }
        
    }
}
