using System;
using System.Globalization;

namespace ExemploDeFixação
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            ContaBancaria c = new ContaBancaria(conta, titular);

            Console.Write("Haverá depósito unicial (s/n)? ");
            c.StatusDeposito = Console.ReadLine();
           
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para o depósito: R$ ");
            c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para o saque: R$ ");
            c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c);
        }
    }
}
