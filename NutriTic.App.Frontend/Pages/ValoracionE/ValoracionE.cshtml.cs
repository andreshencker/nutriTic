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
        private readonly IRepositorioValoracion repositorioValoracion;

        public IEnumerable<VMedida> Medidas{get;set;}
        public IEnumerable<VPaciente> Pacientes{get;set;}
        public IEnumerable<VValoracion> Valoraciones{get;set;}
        public ValoracionEModel(IRepositorioEmpleado repositorioEmpleado,
                                IRepositorioPaciente repositorioPaciente,
                                IRepositorioMedidas repositorioMedida,
                                IRepositorioValoracion repositorioValoracion){
            this.repositorioEmpleado=repositorioEmpleado;
            this.repositorioPaciente=repositorioPaciente;
            this.repositorioMedida=repositorioMedida; 
            this.repositorioValoracion=repositorioValoracion;                          
        }       

        public void OnGet()
        {

            Pacientes=repositorioPaciente.GetAllVPacientes();
            Paciente=repositorioPaciente.GetOnePaciente("1037");
            Medidas=repositorioMedida.GetAllMedidasByPaciente("1037");
            Valoraciones=repositorioValoracion.GetAllValoracionesByPacienteAndEmpleado("1037",Sesion.GetSesion().IdUsuario);
        }
    }
}
