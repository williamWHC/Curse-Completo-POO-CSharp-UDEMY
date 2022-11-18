// See https://aka.ms/new-console-template for more information
using System;

double? n1 = 10.0;
double? n2 = null;

Console.WriteLine($"Obtem valor ou valor padrão: {n1.GetValueOrDefault()}");
Console.WriteLine($"Obtem valor ou valor padrão: {n2.GetValueOrDefault()}");

if (n2.HasValue)
{
    Console.WriteLine($"Valor: {n2.Value}");
    Console.WriteLine($"Valor: {n2.GetType()}");
}
else
    Console.WriteLine("n2 não tem valor");

if (n1.HasValue)
{
    Console.WriteLine($"Valor: {n1.Value}");
}
else
    Console.WriteLine("n1 não tem valor");

Console.WriteLine($"Obtem o hash code: {n1.GetHashCode()}");
Console.WriteLine($"Obtem o hash code: {n2.GetHashCode()}");

Console.WriteLine($"Compara se variaveis são iguais: {n1.Equals(n2)}");
Console.WriteLine($"Compara se variaveis são iguais: {n2.Equals(n1)}");

//operador de coalesencia nula

double? x = 10.00;
double? a = null;

var result = x ?? a;
Console.WriteLine(result);



