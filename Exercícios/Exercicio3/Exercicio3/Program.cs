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

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser remover ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}