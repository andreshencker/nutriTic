using System;
namespace NutriTic.App.Dominio
{
    public class Medida
    {
        public int Id {get;set;}        
        public DateTime Fecha {get;set;}
        public int Peso {get;set;}
        public Paciente Paciente {get;set;}

    }
}