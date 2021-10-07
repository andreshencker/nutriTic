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
    public class ProfileModel : PageModel
    {

          private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente {get;set;}

        public ProfileModel(IRepositorioPaciente repositorioPaciente){
            this.repositorioPaciente=repositorioPaciente;
        }        
        public IActionResult OnGet()
        {
            Paciente=repositorioPaciente.GetOnePaciente(Sesion.GetSesion().IdUsuario);
            if(Paciente==null){
                return NotFound();
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(Paciente paciente)
        {
            repositorioPaciente.UpdatePaciente(paciente);
            return RedirectToPage("/Medidas/Medidas");
        }
    }
}
