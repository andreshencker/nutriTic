using System;
namespace NutriTic.App.Dominio
{
    public class VMedida
    {
       

        public int IdMedida { get; set; }
        public double  Peso { get; set; }
        public DateTime FechaMedida { get; set; }

        public string IdPaciente { get; set; }

        public int Estatura { get; set; }

        public double imc { get; set; }

        public double variacionImc { get; set; }

         public VMedida()
        {
        }

        public VMedida(int idMedida, double peso, DateTime fechaMedida, string idPaciente, int estatura, double imc, double variacionImc)
        {
            IdMedida = idMedida;
            Peso = peso;
            FechaMedida = fechaMedida;
            IdPaciente = idPaciente;
            Estatura = estatura;
            this.imc = imc;
            this.variacionImc = variacionImc;
        }

        double MedidaImc(double peso,int altura){
            return peso/Math.Pow(altura,2);
        }

        double VariacionImc(double imcAnterior,double imcActual){
            return ((imcAnterior-imcActual)/imcAnterior)*100;
        }
    }
}