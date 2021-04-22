using System;
using System.Globalization;


namespace ExemploDeFixação
{
    class ContaBancaria
    {
      
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }
        public string StatusDeposito
        {
          set
            {
                if (value == "s")
                {
                    Console.Write("Entre o valor de depósito inicial: R$ ");
                    Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }

        public void Depositar(double depositar)
        {
            Saldo += depositar;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }
        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
