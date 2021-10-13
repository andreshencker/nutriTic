using System.Reflection;
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
    public class ValoracionEModel : PageModel
    {
        public Paciente Paciente{get;set;}      

        private readonly IRepositorioEmpleado repositorioEmpleado;
        private readonly IRepositorioMedidas repositorioMedida; 
        private readonly IRepositorioPaciente repositorioPaciente;
        private readonly IRepositorioPacienteEmpleado repositorioPacienteEmpleado;
        private readonly IRepositorioValoracion repositorioValoracion;

        public IEnumerable<VMedida> Medidas{get;set;}
        public IEnumerable<VPacienteEmpleado> vPacienteEmpleados{get;set;}
        public IEnumerable<VValoracion> Valoraciones{get;set;}
        public ValoracionEModel(IRepositorioEmpleado repositorioEmpleado,
                                IRepositorioPacienteEmpleado repositorioPacienteEmpleado,
                                IRepositorioPaciente repositorioPaciente,
                                IRepositorioMedidas repositorioMedida,
                                IRepositorioValoracion repositorioValoracion){
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioPacienteEmpleado=repositorioPacienteEmpleado;
            this.repositorioPaciente=repositorioPaciente;
            this.repositorioMedida=repositorioMedida; 
            this.repositorioValoracion=repositorioValoracion;                          
        }       

        public void OnGet()
        {

            vPacienteEmpleados=repositorioPacienteEmpleado.GetAllPacienteEmpleadosByEmpleado(Sesion.GetSesion().IdUsuario);
            Paciente=repositorioPaciente.GetOnePaciente("1037");
            Medidas=repositorioMedida.GetAllMedidasByPaciente("1037");
            Valoraciones=repositorioValoracion.GetAllValoracionesByPaciente("1037");
        }
    }
}
