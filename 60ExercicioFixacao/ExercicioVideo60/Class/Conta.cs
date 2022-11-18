using System.Globalization;

namespace ExercicioVideo60
{
    public class Conta
    {
        private int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public string bDepositoInicial { get; set; }

        public Conta()
        {

        }

        public Conta(short numeroConta, string titularConta) : this()
        {
            NumeroConta = numeroConta;
            Titular = titularConta;
            Saldo = 0.0;
        }

        public Conta(short numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta)
        {
            Deposito(depositoInicial);
        }

        //Propriedades Customizadas
        public int NumeroContaTitular
        {
            get { return NumeroConta; }
            set
            {
                if (value >= 4)
                {
                    NumeroConta = value;
                }
            }
        }

        public double SaldoDaConta
        {
            get { return Saldo; }
            set { Saldo = value; }
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta.ToString()}, Titular: {Titular}, Saldo: $ {SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}