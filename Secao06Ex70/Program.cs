using Secao06Ex70;
using System.Globalization;

Console.Write("Quantidade de Produtos: ");
int n1 = int.Parse(Console.ReadLine());

Product[] vetor = new Product[n1];

for (int i = 0; i < n1; i++)
{
    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Preco: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    vetor[i] = new Product { Name = name, Price = price };
}

//somar preço dos produto

double soma = 0.0;

for (int i = 0; i < n1; i++)
{
    soma += vetor[i].Price;
}

Console.WriteLine($"Soma dos Produtos: {soma.ToString("F2")}");

double avg = soma / n1;
Console.WriteLine($"Media de valor dos Produtos: {avg}");