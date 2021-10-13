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
    public class ContactarEModel : PageModel
    {
        private readonly IRepositorioPacienteEmpleado repositorioPacienteEmpleado;
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public IEnumerable<VPacienteEmpleado> vPacienteEmpleados { get; set; }

        public VEmpleado Empleado { get; set; }
        public ContactarEModel(IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
                               IRepositorioEmpleado repositorioEmpleado ){
            this.repositorioPacienteEmpleado=repositorioPacienteEmpleado;
            this.repositorioEmpleado=repositorioEmpleado;
        }
        public void OnGet(string IdEmpleado)
        {
            Empleado=repositorioEmpleado.GetOneVEmpleado("2");
            vPacienteEmpleados=repositorioPacienteEmpleado.GetAllPacienteEmpleadosByPaciente(Sesion.GetSesion().IdUsuario);
        }
    }
}
