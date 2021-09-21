using System;
namespace NutriTic.App.Dominio.Entidades
{
    public class Medida
    {
        public int IdMedida {get;set;}        
        public DateTime Fecha {get;set;}
        public int Peso {get;set;}
        public Paciente Paciente {get;set;}

    }
}