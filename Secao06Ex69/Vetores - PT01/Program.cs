// See https://aka.ms/new-console-template for more information
using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] vetor = new double[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

//Obtendo os valores do vator
double soma = 0.0;
for (int i = 0; i < n; i++)
{
    soma += vetor[i];
}

//Processamento media
double avg = soma / n;

//Saida da media
Console.WriteLine($"Media {avg.ToString("F2", CultureInfo.InvariantCulture)}"); //Operaador de interpolacao