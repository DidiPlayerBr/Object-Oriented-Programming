using System;
using System.Globalization;

//Exercício 3 - Criando uma classe object ToString na classe Produto.

namespace Exercicio3
{
    class Programs
    {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produtos: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}