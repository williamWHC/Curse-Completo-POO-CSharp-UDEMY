using System.Globalization;

namespace Secao03
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome.ToUpper(); }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value.ToUpper();
                }
            }
        }

        //Metodo 
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaProdutoEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverQuantEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Valor Total => R$:{ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}