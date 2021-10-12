using System;
using System.Diagnostics;

namespace NutriTic.App.Dominio
{

    public class VPaciente
    {
        public string IdPaciente { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string Correo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Estatuta { get; set; }

        public string NombreCargo { get; set; }
        public string NombreCompleto { get; set; }
        public string IdNombreCompleto { get; set; }
      

    }
}