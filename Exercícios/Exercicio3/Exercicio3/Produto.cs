using System.Globalization;

namespace Exercicio3
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidade, Total: & "
                + ValorTotalEmEstoque().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
