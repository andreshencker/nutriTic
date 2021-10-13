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
    public class ActualizarPacienteEmpleadoModel : PageModel
    {
        private readonly IRepositorioPacienteEmpleado repositorioPacienteEmpleado;
        private readonly IRepositorioPaciente repositorioPaciente;
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public PacienteEmpleado PacienteEmpleado {get;set;}
        public Paciente Paciente { get; set; }
        public Empleado Empleado { get; set; }
        public IEnumerable<VPacienteEmpleado> PacienteEmpleados{get;set;}   
        public IEnumerable<VEmpleado> Empleados{get;set;}   

        public ActualizarPacienteEmpleadoModel(IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
                                               IRepositorioEmpleado repositorioEmpleado,
                                               IRepositorioPaciente repositorioPaciente){
            this.repositorioPacienteEmpleado=repositorioPacienteEmpleado;
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioPaciente=repositorioPaciente;
        }        
        public IActionResult OnGet(int id)
        {   
            
            PacienteEmpleado=repositorioPacienteEmpleado.GetOnePacienteEmpleado(id);
            Paciente=repositorioPaciente.GetOnePaciente(PacienteEmpleado.IdPaciente);
            Empleado=repositorioEmpleado.GetOneEmpleado(PacienteEmpleado.IdEmpleado);           
            Empleados=repositorioEmpleado.GetVEmpleadoByCargo(Empleado.IdCargoEmpleado);
            if(PacienteEmpleado==null){
                return NotFound();
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(PacienteEmpleado pacienteEmpleado)
        {
            repositorioPacienteEmpleado.UpdatePacienteEmpleado(pacienteEmpleado);
            return RedirectToPage("./ListarPacienteEmpleado");
        }
    }

}
