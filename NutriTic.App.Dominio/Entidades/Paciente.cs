namespace NutriTic.App.Dominio.Entidades
{
    public class Paciente:Persona
    {
        public Date FechaNacimiento{get;set;}
        public int Estatura{get;set;}
        public string Latitud{get;set;}
        public string Longitud{get;set;}
    }
}