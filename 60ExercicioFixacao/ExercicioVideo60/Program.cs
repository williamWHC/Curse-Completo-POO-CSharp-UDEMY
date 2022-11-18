// See https://aka.ms/new-console-template for more information
namespace ExercicioVideo60
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta = new Conta();

            Console.WriteLine("Bem-Vindo ao Bando Will");
            Console.WriteLine();

            Console.Write("Entre com o Numero da Conta: ");
            conta.NumeroContaTitular = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Entre com os Dados do Titular da Conta: ");
            conta.Titular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Havera Deposito Inicial (s/n): ");
            conta.bDepositoInicial = (Console.ReadLine().ToUpper());
            Console.WriteLine();

            if (conta.bDepositoInicial == "S")
            {
                Console.Write("Entre com o valor do deposito Inicial: ");
                conta.SaldoDaConta = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta.ToString());
            Console.WriteLine();

            Console.Write("Entre com o valor do deposito: ");
            var deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta.ToString());

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            var saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta.ToString());

        }
    }
}