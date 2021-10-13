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
    public class ListarPacienteEmpleadoModel : PageModel
    {
        private readonly IRepositorioPacienteEmpleado repositorioPacienteEmpleado;       
        public IEnumerable<VPacienteEmpleado> PacienteEmpleados{get;set;}      
        private readonly IRepositorioPaciente repositorioPaciente;       
        public IEnumerable<VPaciente> Pacientes{get;set;}      

        public ListarPacienteEmpleadoModel(IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
                                           IRepositorioPaciente repositorioPaciente){
            this.repositorioPacienteEmpleado=repositorioPacienteEmpleado; 
            this.repositorioPaciente=repositorioPaciente;       
        }

        public void OnGet(string idPaciente)
        {   
            Pacientes=repositorioPaciente.GetAllVPacientes();
            PacienteEmpleados=repositorioPacienteEmpleado.GetAllPacienteEmpleadosByPaciente("1037"); 

        }
    }
}
