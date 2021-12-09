using System;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;
        private bool Valido;

        public void DefinirMedidas(double comprimento, double largura) 
        {
            if(comprimento > 0 && largura > 0) 
            {
                this.Comprimento = comprimento;
                this.Largura = largura;
                Valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores Inválidos!");
            }
        }

        public double ObterArea()
        {
            if(Valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Digite valores válidos");
                return 0;
            }
        }
    }
}