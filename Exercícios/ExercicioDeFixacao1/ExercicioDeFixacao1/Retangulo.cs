using System;

namespace ExercicioDeFixacao1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perímetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }
    }
}
