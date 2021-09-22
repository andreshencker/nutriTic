using System;
namespace NutriTic.App.Dominio.Entidades
{
    public class Paciente
    {//hola
    
        public DateTime FechaNacimiento{get;set;}
        public int Estatura{get;set;}
        public string Latitud{get;set;}
        public string Longitud{get;set;}
        public string Id {get;set;}
        public string PrimerNombre {get;set;}
        public string SegundoNombre {get;set;}
        public string PrimerApellido {get;set;}
        public string SegundoApellido {get;set;}
        public string Correo {get;set;}
        public string Telefono {get;set;}
    }
}