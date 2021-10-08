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

        public Sesion sesion { get; set; }

        public Usuario Usuario { get; set; }

        public Paciente Paciente { get; set; }
        public Empleado Empleado { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public LoginModel(IRepositorioEmpleado repositorioEmpleado,
                          IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioEmpleado = repositorioEmpleado;
            this.repositorioPaciente = repositorioPaciente;
        }



        public IActionResult OnPost(Usuario usuario)
        {
            var a =Sesion.Instance;
            if ( a!= null)
            {
                Sesion.Logout();
            }

                       
            if (usuario.TipoUsuario == TipoUsuario.Empleado)
            {   
                
                Empleado = repositorioEmpleado.GetOneEmpleado(usuario.IdUsuario);
                if (Empleado == null)
                {
                    return NotFound();
                }
                else
                {
                    Sesion.Login(usuario.IdUsuario); 
                    return RedirectToPage("/Empleado/Empleado");

                }
            }
            else if (usuario.TipoUsuario == TipoUsuario.Paciente)
            {
                Paciente = repositorioPaciente.GetOnePaciente(usuario.IdUsuario);
                if (Paciente == null)
                {
                    return NotFound();
                }
                else
                {
                    Sesion.Login(usuario.IdUsuario); 
                    return RedirectToPage("/Medidas/Medidas");
                }
               
            }
            else{
                return NotFound();
                }
             
        }
    }
}
