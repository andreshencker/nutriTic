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
        private readonly IRepositorioCargoEmpleado repositorioCargoEmpleado;

        public ConsultasModel(IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
                              IRepositorioEmpleado repositorioEmpleado,
                              IRepositorioCargoEmpleado repositorioCargoEmpleado )
        {
            this.repositorioPacienteEmpleado = repositorioPacienteEmpleado;
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioCargoEmpleado=repositorioCargoEmpleado;
        }

        public IEnumerable<PacienteEmpleado> EmpleadosAsignados { get; set; }
        public IEnumerable<Empleado> Empleados { get; set; }
         public IEnumerable<CargoEmpleado> CargoEmpleados { get; set; }
        public Empleado Empleado { get; set; }
        public void OnGet()
        {   
            CargoEmpleados=repositorioCargoEmpleado.GetAllCargoEmpleados();
            Empleados=repositorioEmpleado.GetEmpleadoByCargo(1);
           // repositorioPacienteEmpleado.GetEmpleadosAsignados(Sesion.GetSesion().IdUsuario);
        }
    }
}
