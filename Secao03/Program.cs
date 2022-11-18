// See https://aka.ms/new-console-template for more information
namespace Secao03
{
    class program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("tv", 10.00, 10);

            produto.Nome = "T";

            Console.WriteLine(produto.Nome);

            // Console.WriteLine("Entre com os dados do produto");
            // Console.Write("Nome do Produto: ");
            // string tName = Console.ReadLine();
            // produto.SetNome(tName);

            // Console.Write("Preço do Produto: ");
            // produto.Preco = double.Parse(Console.ReadLine());

            // Console.Write("Quantidade em estoque: ");
            // produto.Quantidade = int.Parse(Console.ReadLine());

            // Console.WriteLine("Dados do Produto");
            // Console.WriteLine(produto);

            // Console.WriteLine("Digite a quantidade de produto a ser adicionado.");
            // int qtd = int.Parse(Console.ReadLine());
            // produto.AdicionaProdutoEstoque(qtd);

            // Console.WriteLine("Estoque Atualizado:");
            // Console.WriteLine();
            // Console.WriteLine(produto);

            // Console.WriteLine("Digite a quantidade a ser removido");
            // int qtdRemovida = int.Parse(Console.ReadLine());
            // produto.RemoverQuantEstoque(qtdRemovida);

            // Console.WriteLine("Dados Atualizado:");
            // Console.WriteLine(produto);
        }
    }

}





