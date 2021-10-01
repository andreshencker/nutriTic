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
    public class LoginModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente{get;set;}
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public Empleado Empleado { get; set; }

        public LoginModel(IRepositorioEmpleado repositorioEmpleado,IRepositorioPaciente repositorioPaciente){
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioPaciente=repositorioPaciente;
        }

       

        public IActionResult OnGet(String idUsuario,int rol)
        {
            
            if(rol==1){
               Empleado=repositorioEmpleado.GetOneEmpleado(idUsuario);
               if(Empleado==null){
                   return RedirectToPage("./NotFound");
               }else{
                   return Page();
                   
               } 
            }else{
                Paciente= repositorioPaciente.GetOnePaciente(idUsuario);
                if(Paciente==null){
                   return RedirectToPage("./NotFound");
               }else{
                   return Page();
               } 
            }
        }
    }
}
