using System;
namespace NutriTic.App.Dominio.Entidades
{
    public class Valoracion
    {
        public int Id {get;set;}
        public string comentario {get;set;}
        public Empleado Empleado {get;set;}
        public Medida Medida {get;set;}
        public DateTime Fecha {get;set;}
    }
}