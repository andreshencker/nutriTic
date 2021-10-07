using System.ComponentModel.Design;
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
        private readonly IRepositorioEmpleado repositorioEmpleado;

        Sesion sesion;

        public Paciente Paciente{get;set;}
        public Empleado Empleado { get; set; }

        public LoginModel(IRepositorioEmpleado repositorioEmpleado,
                          IRepositorioPaciente repositorioPaciente){
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioPaciente=repositorioPaciente;
        }

       
        /*        
        public IActionResult OnGet()
        {
            
            if("Empleado"){
               Empleado=repositorioEmpleado.GetOneEmpleado(Sesion.GetSesion().IdUsuario);
               if(Empleado==null){
                   return RedirectToPage("./NotFound");
               }else{
                   return RedirectToPage("/Empleado/Empleado");
                   
               } 
            }else{
                Paciente= repositorioPaciente.GetOnePaciente(Sesion.GetSesion().IdUsuario);
                if(Paciente==null){
                   return RedirectToPage("./NotFound");
               }else{
                   return RedirectToPage("/Medidas/Medidas");
               } 
            }
        }*/
    }
}
