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
    public class ConsultasModel : PageModel
    {
        private readonly IRepositorioPacienteEmpleado repositorioPacienteEmpleado;
        private readonly IRepositorioEmpleado repositorioEmpleado;

        public ConsultasModel(IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
                              IRepositorioEmpleado repositorioEmpleado )
        {
            this.repositorioPacienteEmpleado = repositorioPacienteEmpleado;
            this.repositorioEmpleado=repositorioEmpleado;
        }

        public IEnumerable<PacienteEmpleado> EmpleadosAsignados { get; set; }
        public IEnumerable<Empleado> Empleados { get; set; }
        public Empleado Empleado { get; set; }
        public void OnGet()
        {   
            Empleados=repositorioEmpleado.GetEmpleadoByCargo(1);
           // repositorioPacienteEmpleado.GetEmpleadosAsignados(Sesion.GetSesion().IdUsuario);
        }
    }
}
