using System;
using System.Globalization;

namespace ExercicioDeFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionário F = new Funcionário();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + F);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            Double porcent = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + F);
        }
    }
}
