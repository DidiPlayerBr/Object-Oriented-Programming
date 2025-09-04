using System;
using System.Globalization;

namespace ExercicioDeFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();

            Console.Write("Nome do alune: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            A.Nota1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + A.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (A.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + A.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }
        }
    }
}
