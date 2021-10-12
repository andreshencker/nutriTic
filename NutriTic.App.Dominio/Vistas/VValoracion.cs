using System;
namespace NutriTic.App.Dominio
{
    public class VValoracion
    {
        public int IdValoracion { get; set; }
        public string NombreCompleto { get; set; }
        public string Comentario { get; set; }
        public string NombreCargo { get; set; }
        public DateTime FechaValoracion { get; set; }

        public int IdMedida { get; set; }    


    }
}