using System;
using System.Globalization;

//Resolvendo exercício com classe Funcionário.

namespace Exercicio2 {

    class Program {

        static void Main(string[] args) {

            Funcionário f1 = new Funcionário();
            Funcionário f2 = new Funcionário();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salário + f2.Salário) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}