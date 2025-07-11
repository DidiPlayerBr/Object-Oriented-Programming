using System;
using System.Globalization;
//aula 01 - Primeiro resolvendo um problema sem Programação Orientada a Objeto.
//aula 02 - Substituindo as variáveis para os atributos da classe triângulo.Duas variáveis do tipo triângulo.
//aula 03 - Criando um Método.Movendo o cálculo da área para a classe triângulo.

namespace OOPCourse
{
    class Program
    {
        static void Main(string[] args) 
        {
            Triângulo x, y;

            x = new Triângulo();
            y = new Triângulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area(); //Abre e fecha parenteses para indicar que é um método.

            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));  

            if (areaX > areaY) 
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
        
}