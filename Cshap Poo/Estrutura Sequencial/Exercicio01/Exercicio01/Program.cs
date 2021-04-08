using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 30;

            int n3 = -30;
            int n4 = 10;

            int n5 = 0;
            int n6 = 0;

            int soma1 = n1 + n2;
            int soma2 = n3 + n4;
            int soma3 = n5 + n6;

            Console.WriteLine("Soma de {0} com {1} é {2}.", n1, n2, soma1);
            Console.WriteLine($"Soma de {n3} com {n4} é {soma2}.");
            Console.WriteLine("Soma de " + n5 + " com " + n6 + " é " + soma3);
        }
    }
}
