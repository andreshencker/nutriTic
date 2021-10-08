using System.ComponentModel;
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
        private readonly IRepositorioPacienteEmpleado repositorioPacienteEmpleado;
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public Paciente Paciente { get; set; }

        public PacienteEmpleado pacienteEmpleado { get; set; }



        public RegistroModel(IRepositorioPaciente repositorioPaciente,
            IRepositorioPacienteEmpleado repositorioPacienteEmpleado)
        {
            this.repositorioPaciente = repositorioPaciente;
            this.repositorioPacienteEmpleado = repositorioPacienteEmpleado;

        }
        public IEnumerable<Paciente> Pacientes { get; set; }
        public IEnumerable<PacienteEmpleado> EmpleadosAsignados { get; set; }
        public void OnGet()
        {
            Paciente = new Paciente();
        }
        public IActionResult OnPost(Paciente paciente)
        {   //iniciando la sesión de usario
            var a =Sesion.Instance;
            if ( a!= null)
            {
                Sesion.Logout();
            }
           
            Paciente = repositorioPaciente.GetOnePaciente(paciente.IdPaciente);
            if (Paciente != null)
            {
                Sesion.Login(paciente.IdPaciente);
                repositorioPaciente.CreatePaciente(paciente);
                return RedirectToPage("/Medidas/Medidas");
            }
            else
            {
                return RedirectToPage("/Registro/registro");
            }
        }
    }
}
