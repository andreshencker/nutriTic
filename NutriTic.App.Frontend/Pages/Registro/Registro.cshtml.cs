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
        public Paciente Paciente{get;set;}
        public Empleado Empleado{get;set;}
        public PacienteEmpleado pacienteEmpleado{get;set;}

        

        public RegistroModel( IRepositorioPaciente repositorioPaciente, 
            IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
            IRepositorioEmpleado repositorioEmpleado){
            this.repositorioPaciente=repositorioPaciente;
            this.repositorioPacienteEmpleado=repositorioPacienteEmpleado;
            this.repositorioEmpleado=repositorioEmpleado;
        }
        public IEnumerable<Paciente> Pacientes { get; set; }
        public IEnumerable<Empleado> EmpleadosAsignados { get; set; }
        public void OnGet()
        {   
           Paciente= new Paciente();
        }
        public IActionResult OnPost(Paciente paciente)
        {   //iniciando la sesión de usario
            Sesion.Login(paciente.IdPaciente);
            
            //creando al paciente
            repositorioPaciente.CreatePaciente(paciente);
            //EmpleadosAsignados=repositorioEmpleado;
           /* 
            pacienteEmpleado.IdPaciente=id.paciente;
            foreach(e in EmpleadosAsignados){
               
                //pacienteEmpleado.IdEmpleado=id.empleado;
                pacienteEmpleado.IdEmpleado=e.IdEmpleado;
                repositorioPacienteEmpleado.CreatePacienteEmpleado(pacienteEmpleado);
            }
            
            */
          
            

            //consultar a los empleados
            // asignar un nutricionista aleatoriamente
            // asignar un coach aleatoriamente

            
            
            
            
            return RedirectToPage("/Medidas/Medidas");
            
           
        }
    }
}
